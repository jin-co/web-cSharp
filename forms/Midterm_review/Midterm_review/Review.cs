using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm_review
{
    public partial class Review : Form
    {
        string[,] truckWeights = new string[5, 5];
        string record;
        int i = 0, empty = -1;
        public Review()
        {
            InitializeComponent();
        }

        // validate a string contains a number
        private void btnNumeric_Click(object sender, EventArgs e)
        {
            // 7 7.50 763576 -7 -7.5 -763576 .5 -.75
            Regex pattern = new Regex(@"^-?(\d+\.?\d*|\.\d+)$");
            if (pattern.IsMatch(txtNumber.Text))
            {
                txtMessages.Text = "number";
            }
            else
                txtMessages.Text = "no";
        }

        // on load, set the max date to today
        private void Review_Load(object sender, EventArgs e)
        {
            datRecorded.MaxDate = DateTime.Today;
        }

        // add a new record to the array
        // - or update an existing one.
        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            int recordId, truckId;
            double gross, tare;
            txtMessages.Text = "";
            if (!int.TryParse(txtTruckId.Text, out truckId))
            {
                txtMessages.Text = "truck ID is not an integer\n";
            }
            if (!double.TryParse(txtGross.Text, out gross))
            {
                txtMessages.Text += "gross weight is not a number\n"; 
            }
            // if turckId and gross weight are OK,
            // - go see if there's a measure on file for this truck
            if (txtMessages.Text == "")
            {
                for (i = 0; i < truckWeights.GetLength(0); i++)
                {
                    if (truckId.ToString() == truckWeights[i, 1])
                    {
                        truckWeights[i, 3] = gross.ToString();
                        txtMessages.Text = "truck weight is updated\n";
                        return;
                    }
                }
            }

            if (!int.TryParse(txtRecordId.Text, out recordId))
            {
                txtMessages.Text = "record Id is not numeric\n"
                    + txtMessages.Text;
            }
            else // see if recordId is on file
            {
                for (i = 0; i < truckWeights.GetLength(0); i++)
                {
                    if (truckWeights[i, 0] == recordId.ToString())
                    {
                        txtMessages.Text = "record Id is already on file";
                        break;
                    }
                    else if (truckWeights[i, 0] == null)
                    {
                        break;
                    }
                }
            }

            if (!double.TryParse(txtTare.Text, out tare))
            {
                txtMessages.Text += "tare weight is not numeric";
            }
            if (txtMessages.Text != "")
            {
                return;
            }
            // have all valid inputs and no duplicate ID
            if (i == truckWeights.GetLength(0))
            {
                txtMessages.Text = "array is full";
                return;
            }
            truckWeights[i, 0] = recordId.ToString();
            truckWeights[i, 1] = truckId.ToString();
            truckWeights[i, 2] = datRecorded.Value.ToString("dd MMM yyyy");
            truckWeights[i, 3] = gross.ToString();
            truckWeights[i, 4] = tare.ToString();
            txtMessages.Text = "new record saved";

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            txtMessages.Text = "";
            for (i = 0; i < truckWeights.GetLength(0); i++)
            {
                if (truckWeights[i, 0] == null)
                    return;
                
                txtMessages.Text +=
                    $"{truckWeights[i, 0].PadRight(15)}\t{truckWeights[i, 1].PadRight(15)}\t" +
                    $"{truckWeights[i, 2].PadRight(15)}\t{truckWeights[i, 3].PadRight(15)}\t" +
                    $"{truckWeights[i, 4].PadRight(15)}\n";
            }
        }

        private void btnOhip_Click(object sender, EventArgs e)
        {
            txtMessages.Text = "";
            Regex pattern = new Regex(@"\s\w*z+\w*");
            if (pattern.IsMatch(txtNumber.Text))
            {
                txtMessages.Text = "correct";
            }
            else
            {
                txtMessages.Text = "invalid";
            }
        }

        private void btnPrime_Click(object sender, EventArgs e)
        {
            int input = 0;
            txtMessages.Text = "";
            if (int.TryParse(txtNumber.Text, out input))
            {
                if (input < 100 || input > 99999)
                {
                    txtMessages.Text = "input can't be less than 100 or more than 5 string";
                }
            }
            else
            {
                txtMessages.Text = "input is not a number";
            }
            if (txtMessages.Text != "")
            {
                return;
            }


            if (lstPrime.Items.Count < 50)
            {
                PrimGenerator();
            }
            //int input = Convert.ToInt32(txtNumber.Text);
            if (lstPrime.Items.Contains(input))
            {
                txtMessages.Text = "Prime";
            }
            else
            {
                txtMessages.Text = "Not prime";
            }
        }

        // prime
        private void PrimGenerator()
        {
            lstPrime.Items.Add(2);
            bool isPrime = true;
            for (int i = 3; i.ToString().Length < 6; i += 2)
            {
                isPrime = true;
                foreach (var item in lstPrime.Items)
                {
                    if (i % Convert.ToInt32(item) == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    lstPrime.Items.Add(i);
                }
            }
        }
    }
}
