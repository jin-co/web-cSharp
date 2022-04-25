using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtInput.Text))
            {
                txtRichMessage.Text = "exists";
            }
            else
            {
                txtRichMessage.Text = "not exitst";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtInput.Text))
                txtRichMessage.Text = "exists";
            else
            {
                Directory.CreateDirectory(txtInput.Text);
                txtRichMessage.Text = "created";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.Delete(txtInput.Text, true); /*if i put second parameter 
                                                        * (recursive:)true it will 
                                                        * delete every sub folder 
                                                        * with out it if I try to 
                                                        * delete a folder that has
                                                        * a sub folder in it, I won't
                                                        * be able to unless delete 
                                                        * the sub folder first*/
                txtRichMessage.Text = "deleted";
            }
            catch (Exception ex)
            {
                txtRichMessage.Text = "error" + ex.Message; 
            }
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            txtRichMessage.Text = Path.GetDirectoryName(txtInput.Text) + "\n";
            txtRichMessage.Text += Path.GetFileName(txtInput.Text) + "\n";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Directory.EnumerateDirectories(txtInput.Text); // this one doesn't have index
            //string[] file = Directory.EnumerateDirectories(txtInput.Text).ToArray(); // so make it array and join
            //txtRichMessage.Text = string.Join("\n", file);
            string[] file1 = Directory.EnumerateDirectories(txtInput.Text, "*", SearchOption.AllDirectories).ToArray(); // to get all sub folder
            txtRichMessage.Text = string.Join("\n", file1);
        }
    }
}
