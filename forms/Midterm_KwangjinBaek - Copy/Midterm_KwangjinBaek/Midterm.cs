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

namespace Midterm_KwangjinBaek
{
    // Kwangjin Baek #8707943
    // Midterm
    public partial class Midterm : Form
    {
        string[,] items = new string[5, 5];
        int recordIdCount = 0;
        public Midterm()
        {
            InitializeComponent();
        }

        // question 4
        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            txtMessage.Text = "";
            lblMessage.Text = "";
            int recordId = 0, itemId = 0;

            bool isUpdate = false;

            // Record Id validation
            if (!int.TryParse(txtRecordId.Text, out recordId))
            {
                lblMessage.Text = "Record Id must be a number\n";
            }

            for (int i = 0; i < items.GetLength(0); i++)
            {
                if (items[i, 0] == txtRecordId.Text)
                {
                    if (txtItemId.Text == items[i, 1])
                    {
                        recordIdCount = i;
                        isUpdate = true;
                        break;
                    }

                    else
                    {
                        lblMessage.Text += "Record already exists";
                        break;
                    }
                }
            }

            // item id validation
            if (!int.TryParse(txtItemId.Text, out itemId))
            {
                lblMessage.Text += "Item Id must be a number\n";
            }

            // Date validation
            DateTime today = DateTime.Today;
            DateTime inputDate = Convert.ToDateTime(datDateChosen.Value);
            TimeSpan difference = today.Subtract(inputDate);
            if (difference.Days < 0)
            {
                lblMessage.Text += "Date can not be in the future\n";
            }

 
            // add items
            if (lblMessage.Text == "")
            {
                if (recordIdCount > 4)
                {
                    lblMessage.Text = "Record is full";
                }
                else
                {
                    items[recordIdCount, 0] = recordId.ToString();
                    items[recordIdCount, 1] = itemId.ToString();
                    items[recordIdCount, 2] = inputDate.ToString("dd MMM yyyy");
                    //items[recordIdCount, 3] = ;
                    //items[recordIdCount, 4] = ;
                    if (isUpdate)
                    {
                        lblMessage.Text = "Record Updated";
                    }
                    else
                    {
                        lblMessage.Text = "New Record Saved";
                    }
                    recordIdCount++;
                }
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            txtMessage.Text = "";
            lblMessage.Text = "";
            for (int i = 0; i < items.GetLength(0); i++)
            {
                for (int j = 0; j < items.GetLength(1); j++)
                {
                    txtMessage.Text += items[i, j] + "\t";
                }
                txtMessage.Text += "\n";
            }
        }

        // question 1
        private void btnQuestionOne_Click(object sender, EventArgs e)
        {
            Regex pattern = new Regex(@"^-?(\.?\d+|\d+\.?\d*)$");
            if (pattern.IsMatch(txtInput.Text))
            {
                lblMessage.Text = "Match";
            }
            else
            {
                lblMessage.Text = "No match";
            }
        }

        // question 3
        private void btnQuestionThree_Click(object sender, EventArgs e)
        {
            Regex pattern = new Regex(@"^[\w]{4}-([\w]{3}-){2}[A-Z]{2}$");
            if (pattern.IsMatch(txtInput.Text))
            {
                lblMessage.Text = "Match";
            }
            else
            {
                lblMessage.Text = "No match";
            }
        }

        // question 2
        private void btnQuestionTwo_Click(object sender, EventArgs e)
        {
            txtMessage.Text = "";
            lblMessage.Text = "";
            int limit = 50;
            int value1 = 1, value2 = 2, input = 0;

            // check if the input is digit
            if (!int.TryParse(txtInput.Text, out input))
            {
                lblMessage.Text = "Invalid number";
            }

            else
            {
                // check if the input is within the range given
                if (input < 0 || input > 100)
                {
                    lblMessage.Text += "Out of Range";
                }

                else
                {
                    for (int i = 0; i < limit; i++)
                    {
                        lstFibonach.Items.Add(value1);
                        lstFibonach.Items.Add(value2);
                        value1 += value2;
                        value2 += value1;
                    }
                }
            }
                       
            if (lstFibonach.Items.Contains(input))
            {
                txtMessage.Text = "good";
            }
        }


    }
}
