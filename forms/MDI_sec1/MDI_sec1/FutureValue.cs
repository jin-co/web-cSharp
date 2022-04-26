using MDI_sec1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    // calculate the future value of an investment
    // - or the investment required to get a future value
    // compounded monthly
    // d.turton 20 Jan 2021
    public partial class FutureValue : Form
    {
        public FutureValue()
        {
            InitializeComponent();
        }

        // close the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // calculate the future value or the investment required
        private void btnCompute_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";

            double years = 0, annualInterest = 0, monthlyInterest = 0,
                months = 0, initialInvestment = 0, futureValue = 0;

            string errors = lblMessage.Text = "";
            double result = 0;
            if (Double.TryParse(txtAnnualInterest.Text, out result))
                annualInterest = result;
            else
                errors +="annual interest is not a number\n";

            if (Double.TryParse(txtYears.Text, out result))
                years = result;
            else
                errors += "years is not a number\n";

            if (errors != "")
            {
                lblMessage.Text = errors;
                string reply = MessageBox.Show(errors, "data errors", 
                    MessageBoxButtons.YesNoCancel, 
                    MessageBoxIcon.Question).ToString();
                return;
            }


            years = Convert.ToDouble(txtYears.Text);
            months = years * 12;
            annualInterest = Convert.ToDouble(txtAnnualInterest.Text);
            monthlyInterest = annualInterest / 12;

            try
            {
                if (radFutureValue.Checked)
                {
                    initialInvestment = Convert.ToDouble(txtInitialInvestment.Text);
                    futureValue = initialInvestment * Math.Pow(1 + monthlyInterest, months);
                    txtFutureValue.Text = futureValue.ToString("c");
                    lblMessage.Text = "future value calculated";
                }
                else
                {
                    futureValue = Convert.ToDouble(txtFutureValue.Text);
                    initialInvestment = futureValue / Math.Pow(1 + monthlyInterest, months);
                    txtInitialInvestment.Text = initialInvestment.ToString("c2");
                    lblMessage.Text = "required investment calculated";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "exception attempting to calculate result: " +
                    ex.Message;
            }
        }
    }
}
