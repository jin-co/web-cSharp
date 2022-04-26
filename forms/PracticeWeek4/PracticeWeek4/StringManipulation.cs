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

namespace PracticeWeek4
{
    public partial class StringManipulation : Form
    {
        public StringManipulation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            /*
            if ((txtInput.Text + "").ToLower().Contains("sta")) // if it is null it will die like trim - check!?
            {
                txtResult.Text += "contains\n";
            }
            else
            {
                txtResult.Text = "not contains\n";
            }
            if (txtInput.Text.ToLower().StartsWith("sta"))
            {
                txtResult.Text += "contains\n";
            }
            else
            {
                txtResult.Text = "not contains\n";
            }
            if (txtInput.Text.ToLower().EndsWith("sta"))
            {
                txtResult.Text += "contains\n";
            }
            else
            {
                txtResult.Text = "not contains\n";
            }

            int firstIndex = txtInput.Text.IndexOf(@"\"); // @nullifies the escape
            txtResult.Text += "'\\' is at index " + firstIndex.ToString() + "\n";
            int lastIndex = txtInput.Text.LastIndexOf(@"\");
            txtResult.Text += "last '\\' is at index " + lastIndex.ToString() + "\n";
            txtResult.Text += "file name is: " + txtInput.Text.Substring(lastIndex + 1) + "\n";

            //txtResult.Text += txtInput.Text.Insert(Convert.ToInt32(txtAt.Text), txtInsert.Text) + "\n";
            txtInput.Text = txtInput.Text.Insert(Convert.ToInt32(txtAt.Text), txtInsert.Text) + "\n";
            txtResult.Text += txtInput.Text + "after insert\n";
            txtResult.Text += txtInput.Text.Remove(Convert.ToInt32(txtAt.Text), 2) + "\n";
            txtInput.Text = "5194871115";
            txtResult.Text = txtInput.Text.Insert(6, "-").Insert(3, "-") + "\n";
            */
            //txtResult.Text = txtInput.Text.Trim(',', '.', '?');
            string[] words = txtInput.Text.ToLower().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            string result = "";
            /*
            foreach (string word in words)
            {
                result += " " + word.Substring(0, 1).ToUpper(); // the first letter of word
                result += word.Substring(1);
            }
            txtResult.Text = result;
            */
            txtResult.Text = string.Join(", ", words);
        }
        public static bool IsNumeric(string value)
        {
            try
            {
                Convert.ToDouble(value);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtResultRegex.Text = "";
            Regex pattern = new Regex(txtInputRegex.Text);
            if (pattern.IsMatch(txtInput.Text))
            {
                txtResultRegex.Text = "match";
            }
            else
            {
                txtResultRegex.Text = "no match";
            }

        }
    }
}
