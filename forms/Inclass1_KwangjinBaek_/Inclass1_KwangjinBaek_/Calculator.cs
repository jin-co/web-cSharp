using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inclass1_KwangjinBaek_
{
    // this application is a calculator which performs basic operation (+,-,/,*)
    public partial class Calculator : Form
    {
        double x = 0;
        string peddingAction = "";
        bool newNumber = true;

        public Calculator()
        {
            InitializeComponent();
        }

        // gets the values 
        private void button_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" || newNumber)
            {
                txtResult.Clear();
            }
            Button button = (Button)sender;

            if (button.Text == ".")
            {
                if (!txtResult.Text.Contains("."))
                {
                    txtResult.Text = txtResult.Text + button.Text;
                }
            }
            else
            {
                txtResult.Text = txtResult.Text + button.Text;
            }
            newNumber = false;
        }

        // put 'x' value with operation to the operation label and clear
        private void operation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            newNumber = true;
            peddingAction = button.Text;
            x = double.Parse("0" + txtResult.Text);
            lblOperation.Text = x + " " + peddingAction;
            txtResult.Clear();
        }

        // clear only current value int the text box
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
        }

        // clear both values in text box and label
        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            lblOperation.Text = "";
            x = 0;
        }

        // determine the operator 
        // do the calculation
        // show the result
        // clear all
        private void equation_Click(object sender, EventArgs e)
        {
            switch (peddingAction)
            {
                case "+":
                    lblOperation.Text += " " + txtResult.Text;
                    txtResult.Text = (x + double.Parse(txtResult.Text)).ToString();
                    lblOperation.Text += " = " + txtResult.Text;
                    newNumber = true;
                    break;
                case "-":
                    lblOperation.Text += " " + txtResult.Text;
                    txtResult.Text = (x - double.Parse(txtResult.Text)).ToString();
                    lblOperation.Text += " = " + txtResult.Text;
                    newNumber = true;
                    break;
                case "*":
                    lblOperation.Text += " " + txtResult.Text;
                    txtResult.Text = (x * double.Parse(txtResult.Text)).ToString();
                    lblOperation.Text += " = " + txtResult.Text;
                    newNumber = true;
                    break;
                case "/":
                    lblOperation.Text += " " + txtResult.Text;
                    txtResult.Text = (x / double.Parse(txtResult.Text)).ToString();
                    lblOperation.Text += " = " + txtResult.Text;
                    newNumber = true;
                    break;
                case "%":
                    lblOperation.Text += " " + txtResult.Text;
                    txtResult.Text = (x % double.Parse(txtResult.Text)).ToString();
                    lblOperation.Text += " = " + txtResult.Text;
                    newNumber = true;
                    break;
            }
        }
    }
}
