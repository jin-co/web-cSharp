using PatientApp_Week11.Models.DBGenerated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientApp_Week11.Models.ViewModels
{
    public class PatientListViewModel
    {
        public List<Patient> Patients { get; set; }

        public List<string> CityFilters { get; set; }

        public string SelectedCityFilter { get; set; }

        public List<NameGroupFilter> NameGroupFilters { get; set; }

        public int SelectedGroupNameFilterId { get; set; }

        public string GetActiveCityFilter(string cityFilterName)
        {
            return SelectedCityFilter == cityFilterName ? "active" : "";
        }

        public string GetActiveGroupNameFilter(int groupNameFilterId)
        {
            return SelectedGroupNameFilterId == groupNameFilterId ? "active" : "";
        }
    }
}
