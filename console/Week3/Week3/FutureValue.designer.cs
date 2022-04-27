
namespace HelloWorld
{
    partial class FutureValue
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radInitialInvestment = new System.Windows.Forms.RadioButton();
            this.radFutureValue = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInitialInvestment = new System.Windows.Forms.TextBox();
            this.txtAnnualInterest = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFutureValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radInitialInvestment);
            this.groupBox1.Controls.Add(this.radFutureValue);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(86, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculate";
            // 
            // radInitialInvestment
            // 
            this.radInitialInvestment.AutoSize = true;
            this.radInitialInvestment.Location = new System.Drawing.Point(353, 33);
            this.radInitialInvestment.Name = "radInitialInvestment";
            this.radInitialInvestment.Size = new System.Drawing.Size(154, 24);
            this.radInitialInvestment.TabIndex = 1;
            this.radInitialInvestment.TabStop = true;
            this.radInitialInvestment.Text = "Initial Investment";
            this.radInitialInvestment.UseVisualStyleBackColor = true;
            // 
            // radFutureValue
            // 
            this.radFutureValue.AutoSize = true;
            this.radFutureValue.Location = new System.Drawing.Point(51, 33);
            this.radFutureValue.Name = "radFutureValue";
            this.radFutureValue.Size = new System.Drawing.Size(126, 24);
            this.radFutureValue.TabIndex = 0;
            this.radFutureValue.TabStop = true;
            this.radFutureValue.Text = "Future Value";
            this.radFutureValue.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Initial Investment";
            // 
            // txtInitialInvestment
            // 
            this.txtInitialInvestment.Location = new System.Drawing.Point(336, 152);
            this.txtInitialInvestment.Name = "txtInitialInvestment";
            this.txtInitialInvestment.Size = new System.Drawing.Size(257, 26);
            this.txtInitialInvestment.TabIndex = 2;
            // 
            // txtAnnualInterest
            // 
            this.txtAnnualInterest.Location = new System.Drawing.Point(336, 184);
            this.txtAnnualInterest.Name = "txtAnnualInterest";
            this.txtAnnualInterest.Size = new System.Drawing.Size(257, 26);
            this.txtAnnualInterest.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Annual Interest";
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(336, 216);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(257, 26);
            this.txtYears.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Years";
            // 
            // txtFutureValue
            // 
            this.txtFutureValue.Location = new System.Drawing.Point(336, 248);
            this.txtFutureValue.Name = "txtFutureValue";
            this.txtFutureValue.Size = new System.Drawing.Size(257, 26);
            this.txtFutureValue.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Future Value";
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(336, 280);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(109, 35);
            this.btnCompute.TabIndex = 9;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(484, 280);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 35);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(99, 334);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(21, 20);
            this.lblMessage.TabIndex = 11;
            this.lblMessage.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(189, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(378, 37);
            this.label5.TabIndex = 12;
            this.label5.Text = "Future Value Calculator";
            // 
            // FutureValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 444);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.txtFutureValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtYears);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAnnualInterest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInitialInvestment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FutureValue";
            this.Text = "Future Value";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radInitialInvestment;
        private System.Windows.Forms.RadioButton radFutureValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInitialInvestment;
        private System.Windows.Forms.TextBox txtAnnualInterest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFutureValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label5;
    }
}