using PharmacyApp_Week11_Final.Models.DBGenerated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyApp_Week11_Final.Models.ViewModels
{
    public class PatientPrescriptionViewModel
    {
        public string PatientName { get; set; }

        public string PharmacyName { get; set; }

        public string HealthInsurance { get; set; }

        public int SelectedPrescriptionID { get; set; }

        public NameGroupFilter NameGroupFilter { get; set; }

        public List<Prescription> Prescriptions { get; set; }

        public Prescription SelectedPrescription { get; set; }

        public List<PrescriptionLineItem> PrescriptionsLineItems { get; set; }

        public string GetActivePrescription(int prescriptionId)
        {
            return SelectedPrescriptionID == prescriptionId ? "active" : string.Empty;
        }
    }
}
