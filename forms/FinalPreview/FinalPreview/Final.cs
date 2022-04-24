using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPreview
{
    public partial class Final : Form
    {
        public Final()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            int truckId, tare;
            Truck truck = new Truck();
            if (int.TryParse(txtTruckId.Text, out truckId))
            {
                truck.TruckId = truckId;
            }
            else
            {
                lblMessage.Text = "truckId must be an integer > 0\n";
            }
            truck.DateMeasured = datDateMeasure.Value;
            if (int.TryParse(txtWeightInKG.Text, out tare))
            {
                truck.TareWeight = tare;
            }
            else
            {
                lblMessage.Text = "weight must be an integer > 0\n";
            }

            if (lblMessage.Text != "")
            {
                return;
            }
            try
            {
                truck.Save();
                lblMessage.Text = "record save for truck ID " + txtTruckId.Text;
            }
            catch (Exception ex)
            {
                lblMessage.Text = "exception saving record: " + ex.Message;
            }
        }

        private void Final_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            rtbResult.Text = "Truck ID    Date Measured    Tare    Gross    Net\n";
            List<Truck> trucks = Truck.GetTruck();
            trucks = trucks.OrderBy(a => a.TruckId).ToList();
            foreach (var truck in trucks)
            {
                rtbResult.Text += $"{truck.TruckId}    " +
                    $"{truck.DateMeasured.ToString("yyyy MM dd")}    " +
                    $"{truck.TareWeight.ToString("n0")}    " +
                    $"{truck.GrossWeight.ToString("n0")}    " +
                    $"{truck.NetWeight.ToString("n0")}\n";
            }
        }
    }
}
