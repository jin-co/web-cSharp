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

namespace ListBox
{
    public partial class ListBox : Form
    {
        public ListBox()
        {
            InitializeComponent();
        }

        private void ListBox_Load(object sender, EventArgs e)
        {
            LoadListBox();
        }

        private void LoadListBox()
        {
            List<Province> provinces = Province.GetProvinces();
            provinces = provinces.OrderBy(a => a.Name).ToList();
            lstProvinces.DisplayMember = "Name";
            lstProvinces.ValueMember = "ProvinceCode";
            lstProvinces.DataSource = provinces;
        }

        private void lstProvinces_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtProvinceCode.Enabled = false;
            Province province = Province.GetProvince(lstProvinces.SelectedValue.ToString());
            txtProvinceCode.Text = province.ProvinceCode;
            txtName.Text = province.Name;
            txtCountryCode.Text = province.CountryCode;
            txtTaxCode.Text = province.TaxCode;
            txtTaxRate.Text = province.TaxRate.ToString();
            chkIncludeFederalTax.Checked = province.IncludesFederalTax;
            txtFirstPostalLetter.Text = province.FirstLetterOfPostalCode;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            double tax = 0;
            Province province = new Province(txtProvinceCode.Text, txtName.Text);
            province.CountryCode = txtCountryCode.Text;
            province.TaxCode = txtTaxCode.Text;
            if (double.TryParse(txtTaxRate.Text, out tax))
            {
                province.TaxRate = tax;
            }
            else
            {
                lblMessage.Text = "tax rate is not numeric (0 to 1)";
            }
            province.IncludesFederalTax = chkIncludeFederalTax.Checked;
            province.FirstLetterOfPostalCode = txtFirstPostalLetter.Text;

            if (lblMessage.Text != "")
            {
                return;
            }

            try
            {
                if (txtProvinceCode.Enabled)
                {
                    province.Add();
                }
                //else
                //{
                //    //province.Update();
                //}
                LoadListBox();
                lstProvinces.SelectedValue = province.ProvinceCode;
            }
            catch (Exception ex)
            {
                lblMessage.Text = "exception trying to Save:\n" + ex.Message;
                throw;
            }
            

        }

        private void btnClearForAdd_Click(object sender, EventArgs e)
        {
            txtProvinceCode.Text = "";
            txtCountryCode.Text = "";
            txtFirstPostalLetter.Text = "";
            txtName.Text = "";
            txtTaxCode.Text = "";
            txtTaxRate.Text = "";
            chkIncludeFederalTax.Checked = false;
            txtProvinceCode.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProvinceCode.Enabled == false)
                {
                    Province.Delete(txtProvinceCode.Text);
                    string name = txtName.Text;

                    LoadListBox();
                    Province province = Province.GetProvinceNameEqualOrGreater(name);
                    lstProvinces.SelectedValue = province.ProvinceCode;
                }
                else
                {
                    lblMessage.Text = "please reselect the province";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "exception deleting province:\n" + ex.Message;
            }
            
            
        }
    }
}
