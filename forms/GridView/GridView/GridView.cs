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

namespace GridView
{
    public partial class GridView : Form
    {
        public GridView()
        {
            InitializeComponent();
        }
        string filename = "stock.txt", record = ""; // this is the part that i am not supposed to use array or collection
        StreamWriter writer;
        StreamReader reader;

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Name";
            dataGridView1.Columns[2].Name = "Price";
            dataGridView1.Columns[3].Name = "Received";

            using (reader = new StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    record = reader.ReadLine();
                    string[] fields = record.Split('\t');
                    dataGridView1.Rows.Add(fields);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            double price = 0;
            DateTime received = Convert.ToDateTime(txtDateRecord.Text);
            txtDateRecord.Text = received.ToString("dd MMM yyyy");

            string record = $"{txtRecordId.Text}\t{txtName.Text}\t" +
                $"{txtPrice.Text}\t{txtDateRecord.Text}";

            try
            {
                using (writer = new StreamWriter(filename, append: true)) // if file exist delete and recreate a file (when I only use on parameter)
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
