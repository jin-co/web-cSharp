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

namespace GridView2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string filename = "stock.txt", record;
        StreamWriter writer;
        StreamReader reader;

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();

            gridView.ColumnCount = 4;
            gridView.Columns[0].Name = "ID";
            gridView.Columns[1].Name = "Name";
            gridView.Columns[2].Name = "Price";
            gridView.Columns[3].Name = "Received";

            using(reader = new StreamReader(filename))
            {
                while(!reader.EndOfStream)
                {
                    record = reader.ReadLine();
                    string[] fields = record.Split('\t');
                    gridView.Rows.Add(fields);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime recieved = Convert.ToDateTime(txtDateReceived.Text);
            txtDateReceived.Text = recieved.ToString("dd MMM yyyy");

            record = $"{txtRecordId.Text}\t{txtName.Text}\t" +
                $"{txtPrice.Text}\t{txtDateReceived.Text}";

            try
            {
                using (writer = new StreamWriter(filename, append: true))
                {
                    writer.WriteLine(record);
                }
                lblMessage.Text = "record saved";
            }
            catch (Exception ex)
            {
                lblMessage.Text = "exception writing to file: " + ex.Message;
            }            
        }
    }
}
