using PharmacyApp_Week11_Final.Models.DBGenerated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyApp_Week11_Final.Models.ViewModels
{
    public class PatientRecordViewModel
    {
        public string ActionName { get; set; }

        public Patient Patient { get; set; }

        public int SelectedGroupNameFilterId { get; set; }

        public List<HealthInsurance> HealthInsurances { get; set; }

        public List<PharmacyAccount> PharmacyAccounts { get; set; }
    }
}
