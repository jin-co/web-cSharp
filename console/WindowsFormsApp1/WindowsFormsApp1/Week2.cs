using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Week2 : Form
    {
        double firstValue = 0;
        string operation = "";
        string result = "";

        public Week2()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            lblOperation.Text = "";
        }
        private void btnOperation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            if (lblOperation.Text == "...")
            {
                lblOperation.Text = "";
            }
            firstValue = double.Parse(txtResult.Text);
            lblOperation.Text += txtResult.Text + " " + button.Text + " ";
            txtResult.Clear();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtResult.Text += button.Text;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    result = (firstValue + double.Parse(txtResult.Text)).ToString();
                    lblOperation.Text += " " + txtResult.Text + " =  " + result;
                    txtResult.Clear();
                    break;
                case "-":
                    result = (firstValue - double.Parse(txtResult.Text)).ToString();
                    lblOperation.Text += " " + txtResult.Text + " =  " + result;
                    txtResult.Clear();
                    break;
                case "*":
                    result = (firstValue * double.Parse(txtResult.Text)).ToString();
                    lblOperation.Text += " " + txtResult.Text + " =  " + result;
                    txtResult.Clear();
                    break;
                case "/":
                    result = (firstValue / double.Parse(txtResult.Text)).ToString();
                    lblOperation.Text += " " + txtResult.Text + " =  " + result;
                    txtResult.Clear();
                    break;
                case "%":
                    result = (firstValue / double.Parse(txtResult.Text)).ToString();
                    lblOperation.Text += " " + txtResult.Text + " =  " + result;
                    txtResult.Clear();
                    break;
            }
        }

        private void btnPeriod_Click(object sender, EventArgs e)
        {
            if (!txtResult.Text.Contains("."))
            {
                btn_Click(sender, e);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string errors = "";
            if (ddName.SelectedIndex == -1)
            {
                if (errors == "")
                {
                    ddName.Focus();
                }
                errors += "please select a name\n";
            }
            if (lstClass.SelectedIndex == -1)
            {
                if (errors == "")
                {
                    ddName.Focus();
                }
                errors += "please select a class\n";
            }
            if (lstSize.SelectedIndex == -1)
            {
                if (errors == "")
                {
                    ddName.Focus();
                }
                errors += "please select a parking size\n";
            }

            txtMessage.Text = errors;
            lblSelection.Text = errors;

            if (errors == "")
            {
                lblSelection.Text = "record saved\n";
            }
            //else
            //{
            //    txtMessage.Text = errors;
            //    lblSelection.Text = errors;
            //}
        }


    }
}
