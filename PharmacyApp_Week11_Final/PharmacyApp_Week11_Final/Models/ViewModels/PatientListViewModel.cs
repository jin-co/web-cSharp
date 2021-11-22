using PharmacyApp_Week11_Final.Models.DBGenerated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyApp_Week11_Final.Models.ViewModels
{
    public class PatientListViewModel
    {
        public List<Patient> Patients { get; set; }

        public List<string> CityFilters { get; set; }

        public List<NameGroupFilter> NameGroupFilters { get; set; }

        public string SelectedCity { get; set; }

        public int SelectedGroupNameFilterId { get; set; }

        public string GetActiveCityFilter(string cityFilter)
        {
            return cityFilter == SelectedCity ? "active" : "";
        }

        public string GetActiveGroupNameFilter(int groupNameFilterId)
        {
            return groupNameFilterId == SelectedGroupNameFilterId ? "active" : "";
        }
    }
}
