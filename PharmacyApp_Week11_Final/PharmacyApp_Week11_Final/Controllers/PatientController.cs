using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PharmacyApp_Week11_Final.Helpers;
using PharmacyApp_Week11_Final.Models;
using PharmacyApp_Week11_Final.Models.DBGenerated;
using PharmacyApp_Week11_Final.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyApp_Week11_Final.Controllers
{
    public class PatientController : Controller
    {
        private PatientContext dbContext = null;

        public PatientController(PatientContext patientDBContext)
        {
            dbContext = patientDBContext;
        }

        /// <summary>
        /// GET method to retrieve the list of patients (first page)
        /// </summary>
        /// <param name="cityFilter">Binds a city Filter string from the PatientList.cshtml view page</param>
        /// <param name="nameGroupFilterId">Binds a name group filter ID from the PatientList.cshtml view page</param>
        /// <returns>The PatientList.cshtml view page</returns>
        [HttpGet]
        public IActionResult PatientList(string cityFilter = "All", int nameGroupFilterId = 0)
        {
            // Initialize a list of patients (for the table), a list of name group filters (e.g. "A-E"), and the city filter options (non-duplicate entries).
            List<Patient> patientList = dbContext.Patients.ToList();
            List<NameGroupFilter> nameGroupFilters = PatientHelper.GetNameGroupFilters();
            List<string> cityfilterList = patientList.Select(s => s.PatientCity).Distinct().ToList();

            // Check to see if the group name filter cookie exists, if so, update it's value from the passed name group filter id to be re-used in other view pages.
            if (HttpContext.Request.Cookies["groupNameFilter"] != null)
            {
                HttpContext.Response.Cookies.Append("groupNameFilter", nameGroupFilterId.ToString());
            }

            // Retain a local copy of the currently selected city filter and name group filter.
            var selectedCityFilter = cityFilter;
            var selectedGroupNameFilterId = nameGroupFilterId;

            // Insert a placeholder record in both the city filters and the name group filters that act as a way to display all entries in the patient list table.
            cityfilterList.Insert(0, "All");
            nameGroupFilters.Insert(0, new NameGroupFilter() { NameGroupId = 0, GroupName = "All", LowerLetter = 'A', UpperLetter = 'Z' });

            // If the user selected any other city filter entries other than "All", then filter down the patient record based on the selected city filter.
            if (selectedCityFilter != "All")
            {
                patientList = patientList.Where(w => w.PatientCity == cityFilter).ToList();
            }

            // Find the filter name group as passed by the user by searching through the list of name group filters and retrieving the first match from the list.
            var selectedNameGroup = nameGroupFilters.Where(w => w.NameGroupId == nameGroupFilterId).FirstOrDefault();

            // filter the patient list based on two conditions: 1) that the first character of the patient's name is greater than or equal to the lower letter set in the name group.
            //                                                  2) that the first character of the patient's name is less than or equal to the upper letter set in the name group.
            patientList = patientList
                            .Where(w => w.PatientName[0] >= selectedNameGroup.LowerLetter
                                    && w.PatientName[0] <= selectedNameGroup.UpperLetter)
                            .OrderBy(ob => ob.PatientName)
                            .ToList();

            // Filter out all patient records that are "soft-deleted". Only display to users the patient records that are set to IsDeleted == false.
            patientList = patientList.Where(w => w.IsDeleted == false).ToList();

            // Create a view model to retain information to the following properties to load up in the PatientList.cshtml view page.
            PatientListViewModel plvm = new PatientListViewModel()
            {
                Patients = patientList,
                CityFilters = cityfilterList,
                SelectedCity = selectedCityFilter,
                SelectedGroupNameFilterId = selectedGroupNameFilterId,
                NameGroupFilters = nameGroupFilters
            };

            return View(plvm);
        }

        /// <summary>
        /// Implementing the "Soft Delete" pattern on patient records (Called from action link inside the patient list table)
        /// </summary>
        /// <param name="patientId">Binds a patient ID from a record in the patient list table</param>
        /// <returns>A filtered list of patient records in PatientList.cshtml</returns>
        public IActionResult SoftDelete(int patientId)
        {
            // Try to find the patient record inside the database
            var patientRecord = dbContext.Patients.Find(patientId);

            if (patientRecord != null)
            {
                // This triggers the soft delete pattern by updating a simple field from the patient table to be leveraged as a way to mark a record as "deleted".
                patientRecord.IsDeleted = true;
                dbContext.Update(patientRecord);
                dbContext.SaveChanges();

                // Declare some tempdata messages to display temporary message above patient list table.
                TempData["DeletedPatientName"] = patientRecord.PatientName;
                TempData["PatientID"] = patientRecord.PatientId;
            }

            return RedirectToAction("PatientList");
        }

        /// <summary>
        /// Attempts to restore a "Soft Deleted" patient record back into the patient list table
        /// </summary>
        /// <param name="patientId">Binds a patient ID from the hidden patient record</param>
        /// <returns>A restored patient record into the user's view</returns>
        public IActionResult UndoDelete(int patientId)
        {
            // Attempt to find the hidden patient record in the patient table
            var patientDeletedRecord = dbContext.Patients.Find(patientId);

            if (patientDeletedRecord != null)
            {
                // If a record is found, toggle the IsDeleted field back to false so that the user
                // can see the patient record once more in the patient list table
                patientDeletedRecord.IsDeleted = false;
                dbContext.Update(patientDeletedRecord);
                dbContext.SaveChanges();
            }

            return RedirectToAction("PatientList");
        }

        /// <summary>
        /// Redirects user to the "Add" or "Edit" a patient record view page (PatientRecord.cshtml)
        /// </summary>
        /// <param name="actionType">Binds the action type of the form (e.g. "Add" or "Edit")</param>
        /// <param name="groupNameFilterId">Binds the group name filter ID to be used to return a filtered list view in the PatientList.cshml view page</param>
        /// <param name="patientId">Binds a patient ID for the patient record to edit or to start a new patient record (ID = 0)</param>
        /// <returns>The patient record view page</returns>
        [HttpGet]
        public IActionResult PatientRecord(string actionType, int groupNameFilterId, int patientId = 0)
        {
            Patient patient = null;

            // Need to check if we are dealing with a new patient record or an existing one.
            if (actionType == "Add")
            {
                patient = new Patient();
            }
            else if (actionType == "Edit")
            {
                patient = dbContext.Patients.Find(patientId);
            }

            // Create two cookies to keep track of the group name filter passed, as well as the action type that the user clicked previously.
            HttpContext.Response.Cookies.Append("groupNameFilter", groupNameFilterId.ToString());
            HttpContext.Response.Cookies.Append("actionType", actionType);

            // Create the view model with the following properties to load into the view page.
            PatientRecordViewModel prvm = new PatientRecordViewModel()
            {
                Patient = patient,
                ActionName = actionType,
                SelectedGroupNameFilterId = groupNameFilterId,
                HealthInsurances = dbContext.HealthInsurances.ToList(),
                PharmacyAccounts = dbContext.PharmacyAccounts.ToList()
            };

            return View(prvm);
        }

        /// <summary>
        /// Method used for when user submits the form to create a new patient record or to update an existing one
        /// </summary>
        /// <param name="patient">Binds a patient record to the Patient Model from the submitted form</param>
        /// <param name="nameGroupFilterId">Binds the name group filter ID from the submitted form</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult PatientRecord(Patient patient, int nameGroupFilterId)
        {
            // Check to see if there's any issues with the entries within the submitted form
            if (ModelState.IsValid)
            {
                // Code executed when dealing with a new patient
                if (patient.PatientId == 0)
                {
                    dbContext.Patients.Add(patient);
                    dbContext.SaveChanges();
                }
                // Code executed when updating an existing patient record
                else
                {
                    dbContext.Update(patient);
                    dbContext.SaveChanges();
                }
                
                return RedirectToAction("PatientList", new { nameGroupFilterId });
            }

            // This line adds a generic error message to the top of the view page to help
            // indicate to users that there are errors with the form entries.
            ModelState.AddModelError("", "There are errors in the form below.");

            int groupNameFilterId = 0;
            string actionType = string.Empty;

            // Check to see if the cookie for the group name filter is not empty to retrieve
            // the stored filter ID, otherwise, store the name group filter ID passed from the
            // view page.
            if (HttpContext.Request.Cookies["groupNameFilter"] != null)
            {
                groupNameFilterId = int.Parse(HttpContext.Request.Cookies["groupNameFilter"]);
            }
            else
            {
                groupNameFilterId = nameGroupFilterId;
            }

            // Keep track of the action type that the user initially passed when calling this view page (e.g. "Add" or "Edit")
            if (HttpContext.Request.Cookies["actionType"] != null)
            {
                actionType = HttpContext.Request.Cookies["actionType"];
            }

            // Create the view model for the Patient Record view page once more
            PatientRecordViewModel patientRecordViewModel = new PatientRecordViewModel()
            {
                Patient = patient,
                SelectedGroupNameFilterId = groupNameFilterId,
                ActionName = actionType,
                HealthInsurances = dbContext.HealthInsurances.ToList(),
                PharmacyAccounts = dbContext.PharmacyAccounts.ToList()
            };

            return View(patientRecordViewModel);
        }

        /// <summary>
        /// Retrieves and loads up various components for the PatientPrescriptionList.cshtml view page
        /// </summary>
        /// <param name="patientId">Binds the Patient ID as passed from the PatientList.cshtml page</param>
        /// <param name="prescriptionId">Binds the Prescription ID as passed from the PatientList.cshtml page</param>
        /// <returns>A complex view page containing all the prescriptions (and their line items) for a particular patient</returns>
        [HttpGet]
        public IActionResult PatientPrescriptionList(int patientId, int prescriptionId = 0)
        {
            // The following 'var' items load various records, lists, and parameters to process and display in the PatientPrescriptionList view page
            // The following line does a Many-To-Many relationship loading from the database. Remember, there is a linking table between Prescriptions
            // and the PrescriptionLineItems (the table is called PharmacyAccounts). In order to do a linking LINQ statement just like below, we start
            // by getting a list of patients, then we include the associated prescriptions, and then we can go one step further and include the associated
            // prescription line items to load up in the right-hand side table.
            var patients = dbContext.Patients.Include(i => i.Prescriptions).ThenInclude(ti => ti.PrescriptionLineItems);
            var patientRecord = patients.Where(w => w.PatientId == patientId).FirstOrDefault();
            var healthInsurance = dbContext.HealthInsurances.Find(patientRecord.DefaultHealthInsuranceId);
            var pharmarcy = dbContext.PharmacyAccounts.Find(patientRecord.DefaultPharmacyNumber);
            var prescriptions = patientRecord.Prescriptions.ToList();
            var nameGroupFilter = new NameGroupFilter();

            // Check to see if the cookie for the group name filter is not empty to retrieve
            // the stored filter ID and also the name group filter record to which it is associated to.
            if (!string.IsNullOrEmpty(HttpContext.Request.Cookies["groupNameFilter"]))
            {
                int nameGroupFilterId = int.Parse(HttpContext.Request.Cookies["groupNameFilter"]);
                nameGroupFilter = PatientHelper.GetNameGroupFilters()
                    .Where(w => w.NameGroupId == nameGroupFilterId)
                    .FirstOrDefault();
            }

            var selectedPrescriptionID = 0;
            Prescription selectedPrescription = null;
            List<PrescriptionLineItem> prescriptionLineItems = new List<PrescriptionLineItem>();

            // Check to see if the user has selected a different prescription from the list populated in the view page, if so,
            // load up the information for that prescrition, otherwise, fetch the first prescription record in the list and load
            // its information in the table.
            if (prescriptionId != 0)
            {
                selectedPrescriptionID = prescriptionId;
                selectedPrescription = prescriptions.Where(w => w.PrescriptionId == selectedPrescriptionID).FirstOrDefault();
                prescriptionLineItems = selectedPrescription.PrescriptionLineItems.ToList();
            }
            else if (prescriptions.Count() > 0)
            {
                selectedPrescriptionID = prescriptions.First().PrescriptionId;
                selectedPrescription = prescriptions.First();
                prescriptionLineItems = selectedPrescription.PrescriptionLineItems.ToList();
            }

            // Create the view model required for the view page
            PatientPrescriptionViewModel ppvm = new PatientPrescriptionViewModel()
            {
                PatientName = patientRecord.PatientName,
                HealthInsurance = healthInsurance.HealthInsuranceDescription,
                PharmacyName = pharmarcy.PharmacyDescription,
                NameGroupFilter = nameGroupFilter,
                Prescriptions = prescriptions,
                SelectedPharmacyID = patientRecord.DefaultPharmacyNumber,
                SelectedPrescriptionID = selectedPrescriptionID,
                SelectedPrescription = selectedPrescription,
                PrescriptionsLineItems = prescriptionLineItems
            };

            return View(ppvm);
        }

        /// <summary>
        /// Method used to add new prescription line item and reload the PatientPrescriptionList.cshtml view page
        /// </summary>
        /// <param name="patientId">Binds Patient ID from view page (routing parameter)</param>
        /// <param name="prescriptionId">Binds Prescription ID from view page (routing parameter)</param>
        /// <param name="pharmacyNumber">Binds Pharmacy Number from view page (routing parameter)</param>
        /// <param name="description">Binds the newly inserted description value</param>
        /// <param name="amount">Binds the newly inserted amount value</param>
        /// <returns>An updated prescription line items table for a particular prescription ID</returns>
        [HttpPost]
        public IActionResult AddNewPrescriptionLineItem(int patientId, int prescriptionId, int pharmacyNumber, string description, string amount)
        {
            // Retrieve the last prescription line item sequence in order to be able to increment it by 1
            // in order to be able to add a new prescription line item for the selected prescription.
            var lastPrescriptionSequence = dbContext.PrescriptionLineItems
                .Where(w => w.PrescriptionId == prescriptionId)
                .OrderByDescending(obd => obd.PrescritionSequence)
                .Select(s => s.PrescritionSequence)
                .FirstOrDefault();

            lastPrescriptionSequence += 1;

            // Create a temporary prescription line item record and prepare it with
            // the fields passed from the form on the view page and add it as a new
            // record to the database.
            PrescriptionLineItem lineItem = new PrescriptionLineItem()
            {
                PrescriptionId = prescriptionId,
                PrescritionSequence = lastPrescriptionSequence,
                PharmacyNumber = pharmacyNumber,
                LineItemAmount = decimal.Parse(amount),
                LineItemDescription = description
            };

            dbContext.PrescriptionLineItems.Add(lineItem);

            // Update the associated prescription record with the newly calculated total
            // from the pre-exisiting stored total amount in the prescription record and
            // by adding the new amount as passed by the submitted form.
            var prescription = dbContext.Prescriptions.Find(prescriptionId);
            prescription.PrescriptionTotal += decimal.Parse(amount);

            dbContext.Prescriptions.Update(prescription);
            dbContext.SaveChanges();

            return RedirectToAction("PatientPrescriptionList", new { patientId, prescriptionId });
        }
    }
}
