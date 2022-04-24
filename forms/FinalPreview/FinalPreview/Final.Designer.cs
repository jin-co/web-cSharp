
namespace FinalPreview
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
            this.txtTruckId = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtWeightInKG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datDateMeasure = new System.Windows.Forms.DateTimePicker();
            this.lblMessage = new System.Windows.Forms.Label();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Truck ID";
            // 
            // txtTruckId
            // 
            this.txtTruckId.Location = new System.Drawing.Point(148, 79);
            this.txtTruckId.Margin = new System.Windows.Forms.Padding(4);
            this.txtTruckId.Name = "txtTruckId";
            this.txtTruckId.Size = new System.Drawing.Size(132, 23);
            this.txtTruckId.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(323, 76);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(323, 108);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(100, 28);
            this.btnDisplay.TabIndex = 5;
            this.btnDisplay.Text = "Display All";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date Measure";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(323, 140);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtWeightInKG
            // 
            this.txtWeightInKG.Location = new System.Drawing.Point(148, 143);
            this.txtWeightInKG.Margin = new System.Windows.Forms.Padding(4);
            this.txtWeightInKG.Name = "txtWeightInKG";
            this.txtWeightInKG.Size = new System.Drawing.Size(132, 23);
            this.txtWeightInKG.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Weight in KG";
            // 
            // datDateMeasure
            // 
            this.datDateMeasure.CustomFormat = "yyyy-MM-dd";
            this.datDateMeasure.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datDateMeasure.Location = new System.Drawing.Point(148, 111);
            this.datDateMeasure.Margin = new System.Windows.Forms.Padding(4);
            this.datDateMeasure.Name = "datDateMeasure";
            this.datDateMeasure.Size = new System.Drawing.Size(132, 23);
            this.datDateMeasure.TabIndex = 9;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(44, 210);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(20, 17);
            this.lblMessage.TabIndex = 10;
            this.lblMessage.Text = "...";
            // 
            // rtbResult
            // 
            this.rtbResult.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbResult.Location = new System.Drawing.Point(48, 257);
            this.rtbResult.Margin = new System.Windows.Forms.Padding(4);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.Size = new System.Drawing.Size(939, 259);
            this.rtbResult.TabIndex = 11;
            this.rtbResult.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Truck Weights";
            // 
            // Final
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 554);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.datDateMeasure);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtWeightInKG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTruckId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Final";
            this.Text = "Final - Kwangjin Baek";
            this.Load += new System.EventHandler(this.Final_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTruckId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtWeightInKG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datDateMeasure;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.Label label4;
    }
}

