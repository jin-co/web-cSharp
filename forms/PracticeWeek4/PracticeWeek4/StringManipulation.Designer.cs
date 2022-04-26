
namespace PracticeWeek4
{
    partial class StringManipulation
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtInsert = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAt = new System.Windows.Forms.TextBox();
            this.txtInputRegex = new System.Windows.Forms.TextBox();
            this.txtResultRegex = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegex = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(12, 29);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(196, 26);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "123 main streeT SOUTH";
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(12, 171);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(298, 198);
            this.txtResult.TabIndex = 1;
            this.txtResult.TabStop = false;
            this.txtResult.Text = "";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(235, 29);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtInsert
            // 
            this.txtInsert.Location = new System.Drawing.Point(57, 73);
            this.txtInsert.Name = "txtInsert";
            this.txtInsert.Size = new System.Drawing.Size(100, 20);
            this.txtInsert.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Insert";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "at";
            // 
            // txtAt
            // 
            this.txtAt.Location = new System.Drawing.Point(210, 73);
            this.txtAt.Name = "txtAt";
            this.txtAt.Size = new System.Drawing.Size(100, 20);
            this.txtAt.TabIndex = 3;
            // 
            // txtInputRegex
            // 
            this.txtInputRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputRegex.Location = new System.Drawing.Point(12, 108);
            this.txtInputRegex.Name = "txtInputRegex";
            this.txtInputRegex.Size = new System.Drawing.Size(196, 26);
            this.txtInputRegex.TabIndex = 7;
            // 
            // txtResultRegex
            // 
            this.txtResultRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultRegex.Location = new System.Drawing.Point(12, 140);
            this.txtResultRegex.Name = "txtResultRegex";
            this.txtResultRegex.Size = new System.Drawing.Size(196, 26);
            this.txtResultRegex.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "pattern";
            // 
            // btnRegex
            // 
            this.btnRegex.Location = new System.Drawing.Point(260, 111);
            this.btnRegex.Name = "btnRegex";
            this.btnRegex.Size = new System.Drawing.Size(50, 23);
            this.btnRegex.TabIndex = 10;
            this.btnRegex.Text = "Regex";
            this.btnRegex.UseVisualStyleBackColor = true;
            this.btnRegex.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Replacement";
            // 
            // StringManipulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 387);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRegex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResultRegex);
            this.Controls.Add(this.txtInputRegex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInsert);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtInput);
            this.Name = "StringManipulation";
            this.Text = "StringManipulation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAt;
        private System.Windows.Forms.TextBox txtInputRegex;
        private System.Windows.Forms.TextBox txtResultRegex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegex;
        private System.Windows.Forms.Label label4;
    }
}