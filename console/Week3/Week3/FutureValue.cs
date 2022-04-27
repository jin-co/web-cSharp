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
    // this program will calculate the future value of an investment
    // ... or the investment required for a future value
    // ... compunding monthly
    // d.turton 18 Jan 2021
    public partial class FutureValue : Form
    {
        public FutureValue()
        {
            InitializeComponent();
        }

        // exit the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // compute future value or initial investoment 
        //... depends on radio buttons
        private void btnCompute_Click(object sender, EventArgs e)
        {
            string errors = "";
            double output;
            if (!double.TryParse(txtYears.Text, out output))
            {
                errors += "Years is not a number\n";
            }
            if (!double.TryParse(txtAnnualInterest.Text, out output))
            {
                errors += "annual interest is not a number\n";
            }

            if (errors != "")
            {
                var result = MessageBox.Show(errors, "you have edit errors",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop);
                if (result.ToString() == "No")
                    lblMessage.Text = "you said NO";
                return;
            }

            double initialInvestment=0, annualInterest=0, futureValue=0, 
                years=0, monthlyInterest, months;
            years = Convert.ToDouble(txtYears.Text);
            months = years * 12;
            annualInterest = Convert.ToDouble(txtAnnualInterest.Text);
            monthlyInterest = annualInterest / 12;
            if (radFutureValue.Checked)
            {
                initialInvestment = Convert.ToDouble(txtInitialInvestment.Text);
                futureValue = initialInvestment * Math.Pow(1 + monthlyInterest, months);
                txtFutureValue.Text = futureValue.ToString("c");
            } else 
            if (radInitialInvestment.Checked)
            {
                futureValue = Convert.ToDouble(txtFutureValue.Text);
                initialInvestment = futureValue / Math.Pow(1 + monthlyInterest, months);
                txtInitialInvestment.Text = initialInvestment.ToString("c");
            }
        }
    }
}
