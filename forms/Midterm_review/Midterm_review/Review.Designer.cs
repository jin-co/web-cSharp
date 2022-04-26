
namespace Midterm_review
{
    partial class Review
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
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnNumeric = new System.Windows.Forms.Button();
            this.txtMessages = new System.Windows.Forms.RichTextBox();
            this.btnPrime = new System.Windows.Forms.Button();
            this.lstPrime = new System.Windows.Forms.ListBox();
            this.txtRecordId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTruckId = new System.Windows.Forms.TextBox();
            this.datRecorded = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGross = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTare = new System.Windows.Forms.TextBox();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOhip = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(39, 32);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(344, 24);
            this.txtNumber.TabIndex = 0;
            // 
            // btnNumeric
            // 
            this.btnNumeric.Location = new System.Drawing.Point(389, 32);
            this.btnNumeric.Name = "btnNumeric";
            this.btnNumeric.Size = new System.Drawing.Size(133, 23);
            this.btnNumeric.TabIndex = 1;
            this.btnNumeric.Text = "Number Validation";
            this.btnNumeric.UseVisualStyleBackColor = true;
            this.btnNumeric.Click += new System.EventHandler(this.btnNumeric_Click);
            // 
            // txtMessages
            // 
            this.txtMessages.Location = new System.Drawing.Point(39, 341);
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.Size = new System.Drawing.Size(344, 270);
            this.txtMessages.TabIndex = 2;
            this.txtMessages.Text = "";
            // 
            // btnPrime
            // 
            this.btnPrime.Location = new System.Drawing.Point(528, 33);
            this.btnPrime.Name = "btnPrime";
            this.btnPrime.Size = new System.Drawing.Size(133, 23);
            this.btnPrime.TabIndex = 4;
            this.btnPrime.Text = "Prime";
            this.btnPrime.UseVisualStyleBackColor = true;
            this.btnPrime.Click += new System.EventHandler(this.btnPrime_Click);
            // 
            // lstPrime
            // 
            this.lstPrime.FormattingEnabled = true;
            this.lstPrime.ItemHeight = 18;
            this.lstPrime.Location = new System.Drawing.Point(528, 67);
            this.lstPrime.Name = "lstPrime";
            this.lstPrime.Size = new System.Drawing.Size(130, 544);
            this.lstPrime.TabIndex = 5;
            // 
            // txtRecordId
            // 
            this.txtRecordId.Location = new System.Drawing.Point(11, 46);
            this.txtRecordId.Name = "txtRecordId";
            this.txtRecordId.Size = new System.Drawing.Size(140, 24);
            this.txtRecordId.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Q1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(582, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Q2";
            // 
            // txtTruckId
            // 
            this.txtTruckId.Location = new System.Drawing.Point(11, 76);
            this.txtTruckId.Name = "txtTruckId";
            this.txtTruckId.Size = new System.Drawing.Size(140, 24);
            this.txtTruckId.TabIndex = 10;
            // 
            // datRecorded
            // 
            this.datRecorded.Location = new System.Drawing.Point(11, 106);
            this.datRecorded.Name = "datRecorded";
            this.datRecorded.Size = new System.Drawing.Size(140, 24);
            this.datRecorded.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "RecordId";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "TruckId";
            // 
            // txtGross
            // 
            this.txtGross.Location = new System.Drawing.Point(11, 136);
            this.txtGross.Name = "txtGross";
            this.txtGross.Size = new System.Drawing.Size(140, 24);
            this.txtGross.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Gross";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(194, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "DateRecorded";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(194, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tare";
            // 
            // txtTare
            // 
            this.txtTare.Location = new System.Drawing.Point(11, 166);
            this.txtTare.Name = "txtTare";
            this.txtTare.Size = new System.Drawing.Size(140, 24);
            this.txtTare.TabIndex = 17;
            this.txtTare.Text = "Tare";
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.Location = new System.Drawing.Point(350, 47);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(133, 23);
            this.btnAddUpdate.TabIndex = 19;
            this.btnAddUpdate.Text = "Add/Update";
            this.btnAddUpdate.UseVisualStyleBackColor = true;
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(350, 77);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(133, 23);
            this.btnDisplay.TabIndex = 20;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRecordId);
            this.groupBox1.Controls.Add(this.btnDisplay);
            this.groupBox1.Controls.Add(this.btnAddUpdate);
            this.groupBox1.Controls.Add(this.txtTruckId);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.datRecorded);
            this.groupBox1.Controls.Add(this.txtTare);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtGross);
            this.groupBox1.Location = new System.Drawing.Point(23, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 215);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Q3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(720, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Q4";
            // 
            // btnOhip
            // 
            this.btnOhip.Location = new System.Drawing.Point(667, 33);
            this.btnOhip.Name = "btnOhip";
            this.btnOhip.Size = new System.Drawing.Size(133, 23);
            this.btnOhip.TabIndex = 23;
            this.btnOhip.Text = "OHIP";
            this.btnOhip.UseVisualStyleBackColor = true;
            this.btnOhip.Click += new System.EventHandler(this.btnOhip_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(700, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 18);
            this.label9.TabIndex = 24;
            this.label9.Text = "Q5 a, c, e";
            // 
            // Review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 623);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnOhip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstPrime);
            this.Controls.Add(this.btnPrime);
            this.Controls.Add(this.txtMessages);
            this.Controls.Add(this.btnNumeric);
            this.Controls.Add(this.txtNumber);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Review";
            this.Text = "Mid Term Review";
            this.Load += new System.EventHandler(this.Review_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnNumeric;
        private System.Windows.Forms.RichTextBox txtMessages;
        private System.Windows.Forms.Button btnPrime;
        private System.Windows.Forms.ListBox lstPrime;
        private System.Windows.Forms.TextBox txtRecordId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTruckId;
        private System.Windows.Forms.DateTimePicker datRecorded;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGross;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTare;
        private System.Windows.Forms.Button btnAddUpdate;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOhip;
        private System.Windows.Forms.Label label9;
    }
}

