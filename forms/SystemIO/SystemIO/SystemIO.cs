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

namespace SystemIO
{
    public partial class SystemIO : Form
    {
        public SystemIO()
        {
            InitializeComponent();
        }

        private void txtClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {

        }

        private void txtExist_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtInput.Text))
            {
                lblMessage.Text = "Exists";
            }
            else
            {
                lblMessage.Text = "Doesn't exist";
            }
        }

        private void txtCreate_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtInput.Text))
            {
                Directory.CreateDirectory(txtInput.Text);
                lblMessage.Text = "File Created";
            }
            else
                lblMessage.Text = "already exists";
        }
       
        private void txtDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(txtInput.Text))
                {
                    Directory.Delete(txtInput.Text);
                    lblMessage.Text = "Deleted";
                }
                else
                    lblMessage.Text = "File doesn't exist";
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
            
        }
        private void btnRecursiveDelete_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtInput.Text))
            {
                Directory.Delete(txtInput.Text, recursive: true);
                lblMessage.Text = "Deleted";
            }
            else
                lblMessage.Text = "File doesn't exist";
        }
        private void btnSplit_Click(object sender, EventArgs e)
        {
            txtFile.Text =
                Path.GetDirectoryName(txtInput.Text) + "\n";
            txtFile.Text +=
                Path.GetFileName(txtInput.Text) + "\n";
        }

        private void txtListDirectory_Click(object sender, EventArgs e)
        {
            string[] what = Directory.EnumerateDirectories(txtInput.Text).ToArray();
            txtFile.Text = String.Join("\n", what);
        }

        private void btnListAllDirectory_Click(object sender, EventArgs e)
        {
            string[] what = Directory.EnumerateDirectories(txtInput.Text, "*", SearchOption.AllDirectories).ToArray();
            txtFile.Text = String.Join("\n", what);
        }
    }
}
