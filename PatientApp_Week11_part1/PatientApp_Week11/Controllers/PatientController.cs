using Microsoft.AspNetCore.Mvc;
using PatientApp_Week11.Helpers;
using PatientApp_Week11.Models;
using PatientApp_Week11.Models.DBGenerated;
using PatientApp_Week11.Models.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace PatientApp_Week11.Controllers
{
    public class PatientController : Controller
    {
        private PatientContext context;

        public PatientController(PatientContext patientContext)
        {
            context = patientContext;
        }

        [HttpGet]
        public IActionResult PatientList(string cityFilter = "All", int nameGroupFilterId = 0)
        {
            var patientList = context.Patients.ToList();
            List<string> cityFilterList = patientList.Select(s => s.PatientCity).Distinct().ToList();
            List<NameGroupFilter> nameGroupFilterList = PatientHelper.GetNameGroupFilters();

            cityFilterList.Insert(0, "All");
            nameGroupFilterList.Insert(0, new NameGroupFilter() { NameGroupId = 0, GroupName = "All", LowerLetter = 'A', UpperLetter = 'Z' });

            var selectedCityFilter = cityFilter;
            var selectedGroupNameFilterId = nameGroupFilterId;

            if (selectedCityFilter != "All")
            {
                patientList = patientList.Where(w => w.PatientCity == selectedCityFilter).ToList();
            }

            if (selectedGroupNameFilterId != 0)
            {
                var selectedNameGroup = nameGroupFilterList
                    .Where(w => w.NameGroupId == selectedGroupNameFilterId)
                    .FirstOrDefault();

                // a b c d e f g h i j ...
                // 0 1 2 3 4 5 6 7 8 9 ...

                patientList = patientList
                    .Where(w => w.PatientName[0] >= selectedNameGroup.LowerLetter
                            && w.PatientName[0] <= selectedNameGroup.UpperLetter)
                    .OrderBy(ob => ob.PatientName)
                    .ToList();
            }

            PatientListViewModel plvm = new PatientListViewModel()
            {
                Patients = patientList,
                CityFilters = cityFilterList,
                SelectedCityFilter = selectedCityFilter,
                SelectedGroupNameFilterId = selectedGroupNameFilterId,
                NameGroupFilters = nameGroupFilterList
            };
                
            return View(plvm);
        }

        public IActionResult SoftDelete(int patientId)
        {
            var patientRecord = context.Patients.Find(patientId);

            if (patientRecord != null)
            {
                patientRecord.IsDeleted = true;
                context.Update(patientRecord);
                context.SaveChanges();

                TempData["DeletePatientName"] = patientRecord.PatientName;
                TempData["PatientID"] = patientRecord.PatientId;
            }

            return RedirectToAction("PatientList");
        }

        public IActionResult UndoDelete(int patientId)
        {
            var patientDeletedRecord = context.Patients.Find(patientId);

            if (patientDeletedRecord != null)
            {
                patientDeletedRecord.IsDeleted = false;
                context.Update(patientDeletedRecord);
                context.SaveChanges();
            }

            return RedirectToAction("PatientList");
        }
    }
}
