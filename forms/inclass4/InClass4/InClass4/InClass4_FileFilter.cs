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

namespace InClass4
{
    public partial class InClass4_FileFilter : Form
    {
        public InClass4_FileFilter()
        {
            InitializeComponent();
        }

        List<string> subFolderNames = new List<string>();

        // confirm the source folder exists, 
        // - create target folder if it doesn't exist
        private void btnConfirmPath_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            if (string.IsNullOrWhiteSpace(txtSourcePath.Text))
                lblMessage.Text += "no source path specified\n";
            else
            {
                if (!Directory.Exists(txtSourcePath.Text))
                    lblMessage.Text += "source path does not exist\n";
            }

            if (string.IsNullOrWhiteSpace(txtTargetPath.Text))
                lblMessage.Text += "no target path specified\n";
            else
            {
                if (Directory.Exists(txtTargetPath.Text) && chkClearTarget.Checked)
                    Directory.Delete(txtTargetPath.Text, true);
                if (!Directory.Exists(txtTargetPath.Text))
                {
                    Directory.CreateDirectory(txtTargetPath.Text);
                }
            }
            if (lblMessage.Text == "")
            {
                btnListDirectories.Enabled = true;
                btnListFiles.Enabled = true;
            }
        }

        // list all subfolders in the source folder
        // - strip off the source path so the subfolder name can be used later
        private void btnListDirectories_Click(object sender, EventArgs e)
        {
            SearchOption option = SearchOption.TopDirectoryOnly;
            if (chkListSubdirectories.Checked) option = SearchOption.AllDirectories;

            txtResults.Text = "";
            var directories = Directory.EnumerateDirectories(txtSourcePath.Text, "*", option);

            foreach (var directory in directories)
            {
                //Int32 index = directory.LastIndexOf("\\") + 1;
                string lastDirectoryName = Path.GetDirectoryName(directory);
                subFolderNames.Add(lastDirectoryName);
                txtResults.Text += lastDirectoryName + "\n";
            }
        }
        
        // for each subfolder found in the source folder (listed in subFolderNames):
        // - list all the file names (with paths) that fit the filter criteria
        // - for each file name found:
        //   - strip the filename off its path & append the subfolder name (student's name) to it
        //   - copy the file to the target folder, saving it under this modified name
        private void btnListFiles_Click(object sender, EventArgs e)
        {
            lblMessage.Text = txtResults.Text = "";

            SearchOption option = SearchOption.TopDirectoryOnly;
            if (chkListSubdirectories.Checked) option = SearchOption.AllDirectories;

            string fileNameFilter = txtFilter.Text;
            var files = Directory.EnumerateFiles(txtSourcePath.Text, "*", option);



            // find the file(s) matching the pattern
            // for each file found:
            // extract the filename
            // append the student's name to the filename
            // copy the file from source to target folder using the new name
            try 
	        {	        
		        foreach (var file in files)
                {
                    string fileName = Path.GetFileName(file);
                    string directoryName = Path.GetDirectoryName(file);
                    string destinationPath = txtTargetPath.Text;
                    string fileExtension = "";
                    subFolderNames.Add(directoryName);
                if (directoryName.Contains(" "))
                {
                    subFolderNames.Add(directoryName);
                    string[] record = directoryName.Split('\\');
                    if (fileName.Contains("."))
                    {
                        fileExtension = fileName.Substring(fileName.IndexOf("."));
                    }
                    string fileNameCoverted = "";
                    foreach (var i in record)
                    {
                        if (i.Contains(" "))
                        {
                            fileNameCoverted = i + fileExtension;
                            destinationPath += "\\" + fileNameCoverted;
                            File.Copy(file, fileNameCoverted, true);
                        }
                    }
                    txtResults.Text += directoryName + "\n";
                }
            }
	        }
	        catch (Exception ex)
	        {
                lblMessage.Text = ex.Message;
	        }
        }
    }
}

