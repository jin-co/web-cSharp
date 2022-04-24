
namespace KBFinalExam
{
    partial class Final
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVaccinationId = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.datAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNewAppointment = new System.Windows.Forms.Button();
            this.chkFollowUpRequired = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.datAppointmentTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vaccinaion Schedule";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vaccination Id";
            // 
            // txtVaccinationId
            // 
            this.txtVaccinationId.Location = new System.Drawing.Point(194, 87);
            this.txtVaccinationId.Margin = new System.Windows.Forms.Padding(4);
            this.txtVaccinationId.Name = "txtVaccinationId";
            this.txtVaccinationId.Size = new System.Drawing.Size(196, 23);
            this.txtVaccinationId.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(423, 126);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(206, 28);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(423, 208);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(206, 28);
            this.btnDisplay.TabIndex = 6;
            this.btnDisplay.Text = "Display Future Appointment";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(194, 117);
            this.txtPatientName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(196, 23);
            this.txtPatientName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Patient Name";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(423, 167);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(206, 28);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Appointment Date";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(29, 271);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(20, 17);
            this.lblMessage.TabIndex = 10;
            this.lblMessage.Text = "...";
            // 
            // gridView
            // 
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(7, 432);
            this.gridView.Margin = new System.Windows.Forms.Padding(4);
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.Size = new System.Drawing.Size(725, 185);
            this.gridView.TabIndex = 11;
            // 
            // datAppointmentDate
            // 
            this.datAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datAppointmentDate.Location = new System.Drawing.Point(194, 179);
            this.datAppointmentDate.Margin = new System.Windows.Forms.Padding(4);
            this.datAppointmentDate.Name = "datAppointmentDate";
            this.datAppointmentDate.Size = new System.Drawing.Size(196, 23);
            this.datAppointmentDate.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNewAppointment);
            this.groupBox1.Controls.Add(this.chkFollowUpRequired);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtContact);
            this.groupBox1.Controls.Add(this.datAppointmentTime);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.gridView);
            this.groupBox1.Controls.Add(this.datAppointmentDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtVaccinationId);
            this.groupBox1.Controls.Add(this.lblMessage);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPatientName);
            this.groupBox1.Controls.Add(this.btnDisplay);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 627);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnNewAppointment
            // 
            this.btnNewAppointment.Location = new System.Drawing.Point(423, 85);
            this.btnNewAppointment.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewAppointment.Name = "btnNewAppointment";
            this.btnNewAppointment.Size = new System.Drawing.Size(206, 28);
            this.btnNewAppointment.TabIndex = 18;
            this.btnNewAppointment.Text = "New Appointment";
            this.btnNewAppointment.UseVisualStyleBackColor = true;
            this.btnNewAppointment.Click += new System.EventHandler(this.btnNewAppointment_Click);
            // 
            // chkFollowUpRequired
            // 
            this.chkFollowUpRequired.AutoSize = true;
            this.chkFollowUpRequired.Location = new System.Drawing.Point(194, 240);
            this.chkFollowUpRequired.Name = "chkFollowUpRequired";
            this.chkFollowUpRequired.Size = new System.Drawing.Size(151, 21);
            this.chkFollowUpRequired.TabIndex = 17;
            this.chkFollowUpRequired.Text = "Follow-Up Required";
            this.chkFollowUpRequired.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 152);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Contact Email or Phone";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(194, 148);
            this.txtContact.Margin = new System.Windows.Forms.Padding(4);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(196, 23);
            this.txtContact.TabIndex = 16;
            // 
            // datAppointmentTime
            // 
            this.datAppointmentTime.CustomFormat = "h:mm tt";
            this.datAppointmentTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datAppointmentTime.Location = new System.Drawing.Point(194, 210);
            this.datAppointmentTime.Margin = new System.Windows.Forms.Padding(4);
            this.datAppointmentTime.Name = "datAppointmentTime";
            this.datAppointmentTime.Size = new System.Drawing.Size(196, 23);
            this.datAppointmentTime.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 214);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Appointment Time";
            // 
            // Final
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 642);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Final";
            this.Text = "Vaccination Schedule - Kwangjin Baek";
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVaccinationId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.DateTimePicker datAppointmentDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNewAppointment;
        private System.Windows.Forms.CheckBox chkFollowUpRequired;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.DateTimePicker datAppointmentTime;
        private System.Windows.Forms.Label label5;
    }
}

