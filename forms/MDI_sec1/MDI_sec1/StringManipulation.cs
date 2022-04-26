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

namespace MDI_sec1
{
    public partial class StringManipulation : Form
    {
        public StringManipulation()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            txtResults.Text = "";
            if (txtInput.Text.ToLower().Contains("sta"))
                txtResults.Text += "contains 'sta'\n";
            else
                txtResults.Text += "does not contain 'sta'\n";

            if (txtInput.Text.ToLower().StartsWith("sta"))
                txtResults.Text += "starts with 'sta'\n";
            else
                txtResults.Text += "does not start with 'sta'\n";

            int firstSlash = 0, lastSlash = 0;
            firstSlash = txtInput.Text.IndexOf(@"\");
            txtResults.Text += "slash is at index: " + firstSlash + "\n";
            txtResults.Text += "path is: " + txtInput.Text.Substring(firstSlash + 1) + "\n\n";

            lastSlash = txtInput.Text.LastIndexOf("\\");
            txtResults.Text += "file name is at index: " + lastSlash + "\n";
            txtResults.Text += "file name is: " + txtInput.Text.Substring(lastSlash + 1) + "\n\n";

            string postalCode = txtInput.Text.ToUpper();
            if (postalCode.Length == 6)
            {
                txtResults.Text += postalCode.Substring(0, 3) + " " + postalCode.Substring(3) + "\n";
                txtResults.Text += postalCode.Insert(3, " ") + "\n\n";
            }

            string phone = txtInput.Text.ToUpper();
            if (phone.Length == 10)
            {
                txtResults.Text += phone.Substring(0, 3) + "-" + phone.Substring(3,3) + 
                    "-" + phone.Substring(6) + "\n";
                txtResults.Text += phone.Insert(3, "-").Insert(7, "-") + "\n\n";
            }

            txtResults.Text += "trim only: " + txtInput.Text.Trim() + "\n";
            txtResults.Text += "trim chars: " + txtInput.Text.Trim(',', '.', '?') + "\n\n";

            string[] words = txtInput.Text.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in words)
            {
                txtResults.Text += word + "\n";
            }

            string[] waiting = new string[] { "fred", "mary", "gord", "eep", "guy" };
            txtResults.Text = string.Join("\n", waiting);
        }

        private void btnRegex_Click(object sender, EventArgs e)
        {
            Regex pattern = new Regex(txtPattern.Text);
            if (pattern.IsMatch(txtInput.Text))
                txtResults.Text = $"is a match to '{txtPattern.Text}'";
            else
                txtResults.Text = $"does not match '{txtPattern.Text}'";
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            Regex pattern = new Regex(txtPattern.Text);
            txtResults.Text = pattern.Replace(txtInput.Text, txtReplacement.Text);
        }
    }
}
