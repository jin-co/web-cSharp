
namespace MDI_sec1
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
            this.btnRun = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.RichTextBox();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.btnRegex = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.txtReplacement = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(80, 48);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(370, 44);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "123 main street south";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(474, 44);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(155, 34);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtResults
            // 
            this.txtResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResults.Location = new System.Drawing.Point(87, 275);
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(591, 302);
            this.txtResults.TabIndex = 2;
            this.txtResults.Text = "";
            // 
            // txtPattern
            // 
            this.txtPattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPattern.Location = new System.Drawing.Point(80, 118);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(370, 44);
            this.txtPattern.TabIndex = 3;
            // 
            // btnRegex
            // 
            this.btnRegex.Location = new System.Drawing.Point(474, 127);
            this.btnRegex.Name = "btnRegex";
            this.btnRegex.Size = new System.Drawing.Size(155, 34);
            this.btnRegex.TabIndex = 4;
            this.btnRegex.Text = "Regex";
            this.btnRegex.UseVisualStyleBackColor = true;
            this.btnRegex.Click += new System.EventHandler(this.btnRegex_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplace.Location = new System.Drawing.Point(474, 177);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(155, 34);
            this.btnReplace.TabIndex = 5;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // txtReplacement
            // 
            this.txtReplacement.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReplacement.Location = new System.Drawing.Point(80, 168);
            this.txtReplacement.Name = "txtReplacement";
            this.txtReplacement.Size = new System.Drawing.Size(370, 44);
            this.txtReplacement.TabIndex = 6;
            // 
            // StringManipulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 587);
            this.Controls.Add(this.txtReplacement);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnRegex);
            this.Controls.Add(this.txtPattern);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtInput);
            this.Name = "StringManipulation";
            this.Text = "StringManipulation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.RichTextBox txtResults;
        private System.Windows.Forms.TextBox txtPattern;
        private System.Windows.Forms.Button btnRegex;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.TextBox txtReplacement;
    }
}