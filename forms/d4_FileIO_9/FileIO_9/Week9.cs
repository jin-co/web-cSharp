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

namespace FileIO_9
{
    public partial class Week9 : Form
    {
        string path = "", fileName = "", record = "", name = "", archive = "archive.txt";
        int partId;
        double cost;
        DateTime date;
        StreamWriter writer;
        StreamReader reader;
        bool isAdd = false, foundIt = false;

        public Week9()
        {
            InitializeComponent();
        }

        // on load
        private void Week9_Load(object sender, EventArgs e)
        {
            datDate.MaxDate = DateTime.Now;
        }

        // display
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            txtDisplayRecord.Text = "ID\t\tName\t\tDate\t\tCost\n";
            using(reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    record = reader.ReadLine();
                    Parse(record);
                    txtDisplayRecord.Text += $"{partId.ToString("d5")}\t" +
                        $"{name}\t" +
                        $"{date.ToString("dd MM yyyy")}\t" +
                        $"{cost.ToString("c")}\n";
                }
            }
        }

        // parse a record
        private void Parse(string input)
        {
            string[] fields = input.Split('\t');
            partId = Convert.ToInt32(fields[0]);
            name = fields[1];
            date = Convert.ToDateTime(fields[2]);
            cost = double.Parse(fields[3]);
        }

        // find
        private void btnFind_Click(object sender, EventArgs e)
        {
            foundIt = false;
            using (reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    record = reader.ReadLine();
                    if (record.StartsWith(txtPartId.Text + "\t"))
                    {
                        foundIt = true;
                        Parse(record);
                        txtPartId.Text = partId.ToString();
                        txtName.Text = name;
                        datDate.Value = date;
                        txtCost.Text = cost.ToString();
                        break;
                    }
                }
                if (!foundIt)
                {
                    lblMessage.Text = "partId not found";
                }
            }
        }

        // delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<string> records = new List<string>();
            foundIt = false;
            
            using(reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    record = reader.ReadLine();
                    records.Add(record);
                }
            }
            try
            {
                using (writer = new StreamWriter(fileName, append: false))
                {
                    foreach (var record in records)
                    {
                        if (record.StartsWith(txtPartId.Text + "\t"))
                        {
                            foundIt = true;
                        }
                        writer.WriteLine(record);
                    }
                }
                lblMessage.Text = "record deleted";
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        // update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            isAdd = false;
            lblMessage.Text = Edit();
            if (lblMessage.Text != "") return;

            btnDelete_Click(sender, e);
            if (lblMessage.Text == "record deleted")
            {
                btnAdd_Click(sender, e);
                if (lblMessage.Text.StartsWith("record added:"))
                {
                    lblMessage.Text = "record updated";
                }
            }
        }

        private void btnGetCurrentDirectory_Click(object sender, EventArgs e)
        {
            lblMessage.Text = Directory.GetCurrentDirectory(); 
        }

        private void btnCreatedtime_Click(object sender, EventArgs e)
        {
            lblMessage.Text = Directory.GetCreationTime(txtFile.Text).ToString();
        }

        private void btnLastWrittenTime_Click(object sender, EventArgs e)
        {
            lblMessage.Text = Directory.GetLastWriteTime(txtFile.Text).ToString();
        }

        private void btnLastAccessTime_Click(object sender, EventArgs e)
        {
            lblMessage.Text = Directory.GetLastAccessTime(txtFile.Text).ToString();
        }

        private void btnEnumerateFile_Click(object sender, EventArgs e)
        {
            string[] what = Directory.EnumerateFiles(txtFile.Text, "*", SearchOption.AllDirectories).ToArray();
            lblMessage.Text = String.Join("\n", what);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] what = Directory.EnumerateDirectories(txtFile.Text, "*", SearchOption.AllDirectories).ToArray();
            lblMessage.Text = String.Join("\n", what);
        }

        // archive delete
        private void btnArchive_Click(object sender, EventArgs e)
        {
            File.Move(fileName, archive);
            foundIt = false;
            try
            {
                using(reader = new StreamReader(archive))
                {
                    using(writer = new StreamWriter(fileName, append: true))
                    {
                        while (!reader.EndOfStream)
                        {
                            record = reader.ReadLine();
                            if (record.StartsWith(txtPartId.Text + "\n"))
                            {
                                foundIt = true;
                            }
                            else
                            {
                                writer.WriteLine(record);
                            }
                        }
                    }
                }
                if (foundIt)
                {
                    lblMessage.Text = "record not found";
                }
                else
                {
                    lblMessage.Text = "record deleted";
                }
            }
            catch (Exception ex)
            {
                if (File.Exists(fileName)) File.Delete(fileName);
                File.Copy(archive, fileName);
                
                lblMessage.Text = ex.Message;
                lblMessage.Text += "\nfile recovered from archive";
            }
            if (File.Exists(archive))
            {
                File.Delete(archive);
            }

        }

        private void txtClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        // add record
        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblMessage.Text = Edit();
            if (lblMessage.Text != "") return;

            record = $"{txtPartId.Text}\t{txtName.Text}\t{datDate.Value}" +
                $"\t{txtCost.Text}";
            try
            {
                using (writer = new StreamWriter(fileName, append: true))
                {
                    writer.WriteLine(record);
                }
                lblMessage.Text = "Record added";
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
            
            
        }

        // edit the inputs before add/update
        private string Edit()
        {
            string error = "";
            if (string.IsNullOrWhiteSpace(txtPartId.Text))
            {
                if (error == "") txtPartId.Focus();
                {
                    error += "partId error";
                }
                

            }
            else if (!int.TryParse(txtPartId.Text, out partId))
            {
                if (error == "") txtPartId.Focus();
                {
                    error += "more than zero";
                }
            }
            else if (partId <= 0)
            {
                if (error == "") txtPartId.Focus();
                {
                    error += "greater than zero\n";
                }
            }
            else
            {
                using(reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        record = reader.ReadLine();
                        if (record.StartsWith(txtPartId.Text)) foundIt = true;
                    }
                }
                if (foundIt && isAdd)
                {
                    if (error == "") txtPartId.Focus();
                    {
                        error += "already on file\n";
                    }
                }
                else if (!foundIt && isAdd)
                {
                    if (error == "") txtPartId.Focus();
                    {
                        error += "not on file\n";
                    }
                }
            }

            // name check
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                if (error == "") txtName.Focus();
                {
                    error += "name can not be empty or just blanks\n";
                }
            }

            // date check
            if (datDate.Value > DateTime.Now)
            {
                if (error == "") datDate.Focus();
                {
                    error += "date can not be in the future\n";
                }
            }

            if (string.IsNullOrWhiteSpace(txtCost.Text))
            {
                if (error == "") txtPartId.Focus();
                {
                    error += "already on file\n";
                }
            }
            else if (!double.TryParse(txtCost.Text, out cost))
            {
                if (error == "") txtCost.Focus();
                {
                    error += "cost must be a number\n";
                }
            }
            else if (cost < 0)
            {
                if (error == "") txtPartId.Focus();
                {
                    error += "cost must be more than 0\n";
                }
            }

            return error;
        }

        private void btnVerifyFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFile.Text))
            {
                lblMessage.Text = "Write something";
                return;
            }

            if (!File.Exists(txtFile.Text))
            {
                try
                {
                    path = Path.GetDirectoryName(txtFile.Text);
                    if (path != "")
                    {
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                            lblMessage.Text = "Directory created";
                        }
                    }
                    
                    var fileCreate = File.Create(txtFile.Text);
                    fileCreate.Dispose();
                    //File.Create(txtFile.Text).Dispose();
                }
                catch (Exception ex)
                {
                    lblMessage.Text = ex.Message;
                }
            }
            fileName = txtFile.Text;
        }
    }
}
