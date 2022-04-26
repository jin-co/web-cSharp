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

namespace Grid
{
    public partial class Grid : Form
    {
        public Grid()
        {
            InitializeComponent();
        }
        string fileName = "what.txt";
        StreamReader reader;
        StreamWriter writer;
        string record;
        private void btnSave_Click(object sender, EventArgs e)
        {
            record = $"{txtRecordId.TabIndex}\t{txtName.Text}\t" +
                $"{txtPrice.Text}\t{datDate.Value.ToString()}";
            using (writer = new StreamWriter(fileName, append: true))
            {
                writer.WriteLine(record);
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            gridView.Columns.Clear();
            gridView.ColumnCount = 4;

            gridView.Columns[0].Name = "ID";
            gridView.Columns[1].Name = "Name";
            gridView.Columns[2].Name = "Price";
            gridView.Columns[3].Name = "DateAdded";
            using(reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    record = reader.ReadLine();
                    string[] fields = record.Split('\t');
                    gridView.Rows.Add(fields);
                }
            }
        }
    }
}
