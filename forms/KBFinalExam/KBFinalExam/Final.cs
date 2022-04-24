using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBFinalExam
{
    // Final exam, written by Kwangjin Baek / 29-Apr-2021
    public partial class Final : Form
    {
        public Final()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            int id;
            Vaccination vaccination = new Vaccination();

            // Id
            if (!int.TryParse(txtVaccinationId.Text, out id))
            {
                lblMessage.Text += "Vaccination id: Enter digits\n";
            }

            if (lblMessage.Text == "")
            {
                vaccination.VaccinationId = id;
                vaccination.PatientName = txtPatientName.Text;
                vaccination.Contact = txtContact.Text;
                vaccination.AppointmentDate = datAppointmentDate.Value;
                vaccination.AppointmentTime = datAppointmentTime.Value;
                if (chkFollowUpRequired.Checked)
                {
                    vaccination.FollowupRequired = chkFollowUpRequired.Checked;
                }
            }
            else
            {
                return;
            }

            try
            {
                vaccination.Save();
                lblMessage.Text = "New record saved";
            }
            catch (Exception ex)
            {
                lblMessage.Text = "** Error occurred while saving:\n" + ex.Message;
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            gridView.Columns.Clear();

            // column count
            gridView.ColumnCount = 6;
            gridView.Columns[0].Name = "ID";
            gridView.Columns[1].Name = "Name";
            gridView.Columns[2].Name = "Appointment date";
            gridView.Columns[3].Name = "Appointment time";
            gridView.Columns[4].Name = "Follow-up date";
            gridView.Columns[5].Name = "Follow-up time";

            // display
            List<Vaccination> list = Vaccination.GetVaccinationRecords();
            list = list.OrderBy(a => a.PatientName).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                string[] record = list[i].ToString().Split('\t');
                if (Convert.ToDateTime(record[3]) > DateTime.Now)
                {
                    if (Convert.ToBoolean(record[5]))
                    {
                        gridView.Rows.Add(record[0]);
                        gridView.Rows.Add(record[1]);
                        gridView.Rows.Add(record[3]);
                        gridView.Rows.Add(record[4]);
                        gridView.Rows.Add(record[6]);
                        gridView.Rows.Add(record[7]);
                    }
                    else
                    {
                        gridView.Rows.Add(record[0]);
                        gridView.Rows.Add(record[1]);
                        gridView.Rows.Add(record[3]);
                        gridView.Rows.Add(record[4]);
                    }
                }
            }
        }

        // Close the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNewAppointment_Click(object sender, EventArgs e)
        {
            gridView.Columns.Clear();
            lblMessage.Text = "";

            txtVaccinationId.Text = Vaccination.GetUniqueVaccinationId().ToString();
            txtPatientName.Text = "";
            txtContact.Text = "";
            datAppointmentDate.Value = DateTime.Now;
            datAppointmentTime.Value = DateTime.Now;
            chkFollowUpRequired.Checked = false;

        }
    }
}
