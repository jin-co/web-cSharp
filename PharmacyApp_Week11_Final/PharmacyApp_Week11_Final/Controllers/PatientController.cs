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

        [HttpGet]
        public IActionResult PatientList(string cityFilter = "All", int nameGroupFilterId = 0)
        {
            List<Patient> patientList = dbContext.Patients.ToList();
            List<NameGroupFilter> nameGroupFilters = PatientHelper.GetNameGroupFilters();
            List<string> cityfilterList = patientList.Select(s => s.PatientCity).Distinct().ToList();

            // Enhancement, don't show yet (after returning from "Edit" page
            if (HttpContext.Request.Cookies["groupNameFilter"] != null)
            {
                HttpContext.Response.Cookies.Append("groupNameFilter", nameGroupFilterId.ToString());
            }

            var selectedCityFilter = cityFilter;
            var selectedGroupNameFilterId = nameGroupFilterId;

            cityfilterList.Insert(0, "All");
            nameGroupFilters.Insert(0, new NameGroupFilter() { NameGroupId = 0, GroupName = "All", LowerLetter = 'A', UpperLetter = 'Z' });

            if (selectedCityFilter != "All")
            {
                patientList = patientList.Where(w => w.PatientCity == cityFilter).ToList();
            }

            var selectedNameGroup = new NameGroupFilter();

            selectedNameGroup = nameGroupFilters.Where(w => w.NameGroupId == nameGroupFilterId).FirstOrDefault();

            patientList = patientList
                            .Where(w => w.PatientName[0] >= selectedNameGroup.LowerLetter
                                    && w.PatientName[0] <= selectedNameGroup.UpperLetter)
                            .OrderBy(ob => ob.PatientName)
                            .ToList();

            patientList = patientList.Where(w => w.IsDeleted == false).ToList();

            // Enhancement, don't show yet (after returning from "Edit" page)
            //if (HttpContext.Request.Cookies["groupNameFilter"] != null)
            //{
            //    selectedGroupNameFilterId = int.Parse(HttpContext.Request.Cookies["groupNameFilter"]);
            //}

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

        public IActionResult SoftDelete(int patientId)
        {
            var patientRecord = dbContext.Patients.Find(patientId);

            if (patientRecord != null)
            {
                patientRecord.IsDeleted = true;
                dbContext.Update(patientRecord);
                dbContext.SaveChanges();
                TempData["DeletedPatientName"] = patientRecord.PatientName;
                TempData["PatientID"] = patientRecord.PatientId;
            }

            return RedirectToAction("PatientList");
        }

        public IActionResult UndoDelete(int patientId)
        {
            var patientDeletedRecord = dbContext.Patients.Find(patientId);

            if (patientDeletedRecord != null)
            {
                patientDeletedRecord.IsDeleted = false;
                dbContext.Update(patientDeletedRecord);
                dbContext.SaveChanges();
            }

            return RedirectToAction("PatientList");
        }

        [HttpGet]
        public IActionResult PatientRecord(string actionType, int groupNameFilterId, int patientId = 0)
        {
            Patient patient = null;

            if (actionType == "Add")
            {
                patient = new Patient();
            }
            else if (actionType == "Edit")
            {
                patient = dbContext.Patients.Find(patientId);
            }

            HttpContext.Response.Cookies.Append("groupNameFilter", groupNameFilterId.ToString());
            HttpContext.Response.Cookies.Append("actionType", actionType);

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

        [HttpPost]
        public IActionResult PatientRecord(Patient patient, int selectedGroupNameFilterId)
        {
            if (ModelState.IsValid)
            {
                if (patient.PatientId == 0)
                {
                    dbContext.Patients.Add(patient);
                    dbContext.SaveChanges();
                }
                else
                {
                    var patientRecord = dbContext.Patients.Find(patient.PatientId);
                    dbContext.Update(patientRecord);
                    dbContext.SaveChanges();
                }
                
                return RedirectToAction("PatientList");
            }

            ModelState.AddModelError("", "There are errors in the form below.");

            int groupNameFilterId = 0;
            string actionType = string.Empty;

            if (HttpContext.Request.Cookies["groupNameFilter"] != null)
            {
                groupNameFilterId = int.Parse(HttpContext.Request.Cookies["groupNameFilter"]);
            }

            if (HttpContext.Request.Cookies["actionType"] != null)
            {
                actionType = HttpContext.Request.Cookies["actionType"];
            }

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

        [HttpGet]
        public IActionResult PatientPrescriptionList(int patientId, int prescriptionId = 0)
        {
            var patients = dbContext.Patients.Include(i => i.Prescriptions);
            var patientRecord = patients.Where(w => w.PatientId == patientId).FirstOrDefault();
            var healthInsurance = dbContext.HealthInsurances.Find(patientRecord.DefaultHealthInsuranceId);
            var pharmarcy = dbContext.PharmacyAccounts.Find(patientRecord.DefaultPharmacyNumber);
            var prescriptions = patientRecord.Prescriptions.ToList();
            var nameGroupFilter = new NameGroupFilter();

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

            if (prescriptionId != 0)
            {
                selectedPrescriptionID = prescriptionId;
                selectedPrescription = prescriptions.Where(w => w.PrescriptionId == selectedPrescriptionID).FirstOrDefault();
                prescriptionLineItems = dbContext.PrescriptionLineItems.Where(w => w.PrescriptionId == selectedPrescriptionID).ToList();
            }
            else if (prescriptions.Count() > 0)
            {
                selectedPrescriptionID = prescriptions.First().PrescriptionId;
                selectedPrescription = prescriptions.First();
                prescriptionLineItems = dbContext.PrescriptionLineItems.Where(w => w.PrescriptionId == selectedPrescriptionID).ToList();
            }

            PatientPrescriptionViewModel ppvm = new PatientPrescriptionViewModel()
            {
                PatientName = patientRecord.PatientName,
                HealthInsurance = healthInsurance.HealthInsuranceDescription,
                PharmacyName = pharmarcy.PharmacyDescription,
                NameGroupFilter = nameGroupFilter,
                Prescriptions = prescriptions,
                SelectedPrescriptionID = selectedPrescriptionID,
                SelectedPrescription = selectedPrescription,
                PrescriptionsLineItems = prescriptionLineItems
            };

            return View(ppvm);
        }

        [HttpPost]
        public IActionResult PatientPrescriptionList()
        {
            return View();
        }
    }
}
