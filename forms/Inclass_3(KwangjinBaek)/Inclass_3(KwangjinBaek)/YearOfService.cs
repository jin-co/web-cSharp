using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inclass_3_KwangjinBaek_
{
    /* In class 3 year of service, 
     * written by KwangjinBaek / #8707943 / 2021.Mar.26.
     * this application is a years of service calculator 
     * that shows how many year a worker has worked 
     * based on the starting date a user put in
    */
    public partial class YearOfService : Form
    {
        double annualSalary = 0;
        public YearOfService()
        {
            InitializeComponent();
        }

        // instantiate an object for employee class
        // store the input to the object
        // show the result if there were no errors
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            lblMessage.Text = "";
            
            // check if the annual input is digit
            // if not show an error message
            if (!double.TryParse(txtAnnualSalary.Text, out annualSalary))
            {
                lblMessage.Text = "Please enter digits";
                txtAnnualSalary.Focus();
            }

            #region instantiation
            Employee employee = new Employee();
            employee.FirstName = txtFirstName.Text;
            employee.LastName = txtLastName.Text;
            employee.StartDate = datStartDate.Value;
            employee.AnnualSalary = annualSalary;
            #endregion

            // check if there were errors
            // if not show the result
            if (lblMessage.Text == "")
            {
                txtResult.Text = employee.GetYearsOfService().ToString();
            }
        }

        // close the form
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        // contact information
        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Author: Kwangjin Baek\n" +
                "Email: lilijk@hanmail.net",
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
