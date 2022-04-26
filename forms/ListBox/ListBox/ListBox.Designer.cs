
namespace ListBox
{
    partial class ListBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstProvinces = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProvinceCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCountryCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTaxCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTaxRate = new System.Windows.Forms.TextBox();
            this.txtFirstPostalLetter = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkIncludeFederalTax = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClearForAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstProvinces
            // 
            this.lstProvinces.FormattingEnabled = true;
            this.lstProvinces.ItemHeight = 16;
            this.lstProvinces.Location = new System.Drawing.Point(27, 99);
            this.lstProvinces.Name = "lstProvinces";
            this.lstProvinces.Size = new System.Drawing.Size(218, 356);
            this.lstProvinces.TabIndex = 0;
            this.lstProvinces.SelectedIndexChanged += new System.EventHandler(this.lstProvinces_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Delete";
            // 
            // txtProvinceCode
            // 
            this.txtProvinceCode.Location = new System.Drawing.Point(419, 99);
            this.txtProvinceCode.Name = "txtProvinceCode";
            this.txtProvinceCode.Size = new System.Drawing.Size(156, 23);
            this.txtProvinceCode.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Province Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(419, 128);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(156, 23);
            this.txtName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Country Code";
            // 
            // txtCountryCode
            // 
            this.txtCountryCode.Location = new System.Drawing.Point(419, 157);
            this.txtCountryCode.Name = "txtCountryCode";
            this.txtCountryCode.Size = new System.Drawing.Size(156, 23);
            this.txtCountryCode.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "TaxRate";
            // 
            // txtTaxCode
            // 
            this.txtTaxCode.Location = new System.Drawing.Point(419, 186);
            this.txtTaxCode.Name = "txtTaxCode";
            this.txtTaxCode.Size = new System.Drawing.Size(156, 23);
            this.txtTaxCode.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tax Code";
            // 
            // txtTaxRate
            // 
            this.txtTaxRate.Location = new System.Drawing.Point(419, 215);
            this.txtTaxRate.Name = "txtTaxRate";
            this.txtTaxRate.Size = new System.Drawing.Size(156, 23);
            this.txtTaxRate.TabIndex = 10;
            // 
            // txtFirstPostalLetter
            // 
            this.txtFirstPostalLetter.Location = new System.Drawing.Point(419, 273);
            this.txtFirstPostalLetter.Name = "txtFirstPostalLetter";
            this.txtFirstPostalLetter.Size = new System.Drawing.Size(156, 23);
            this.txtFirstPostalLetter.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(275, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "1st Postal Letter(s)";
            // 
            // chkIncludeFederalTax
            // 
            this.chkIncludeFederalTax.AutoSize = true;
            this.chkIncludeFederalTax.Location = new System.Drawing.Point(420, 247);
            this.chkIncludeFederalTax.Name = "chkIncludeFederalTax";
            this.chkIncludeFederalTax.Size = new System.Drawing.Size(151, 21);
            this.chkIncludeFederalTax.TabIndex = 16;
            this.chkIncludeFederalTax.Text = "Include Federal Tax";
            this.chkIncludeFederalTax.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(668, 99);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClearForAdd
            // 
            this.btnClearForAdd.Location = new System.Drawing.Point(668, 128);
            this.btnClearForAdd.Name = "btnClearForAdd";
            this.btnClearForAdd.Size = new System.Drawing.Size(99, 23);
            this.btnClearForAdd.TabIndex = 18;
            this.btnClearForAdd.Text = "Clear for Add";
            this.btnClearForAdd.UseVisualStyleBackColor = true;
            this.btnClearForAdd.Click += new System.EventHandler(this.btnClearForAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(668, 157);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 23);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(668, 186);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 23);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(275, 337);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(20, 17);
            this.lblMessage.TabIndex = 22;
            this.lblMessage.Text = "...";
            // 
            // ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClearForAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkIncludeFederalTax);
            this.Controls.Add(this.txtFirstPostalLetter);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTaxRate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTaxCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCountryCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProvinceCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstProvinces);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListBox";
            this.Text = "ProvinceMaintenance";
            this.Load += new System.EventHandler(this.ListBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstProvinces;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProvinceCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCountryCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTaxCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTaxRate;
        private System.Windows.Forms.TextBox txtFirstPostalLetter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkIncludeFederalTax;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClearForAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMessage;
    }
}

