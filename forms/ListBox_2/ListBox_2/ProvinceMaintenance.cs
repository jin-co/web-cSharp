using Encapsulation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox_2
{
    public partial class ProvinceMaintenance : Form
    {
        public ProvinceMaintenance()
        {
            InitializeComponent();
        }

        private void ProvinceMaintenance_Load(object sender, EventArgs e)
        {
            RebuildListBox();
        }

        // method to reload the listbox after insert, update and delete
        private void RebuildListBox()
        {
            List<Province> provinces = Province.GetProvinces();
            provinces = provinces.OrderBy(a => a.Name).ToList();

            lstProvinces.ValueMember = ;

        }
    }
}
