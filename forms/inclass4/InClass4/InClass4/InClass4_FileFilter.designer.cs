
namespace InClass4
{
    partial class InClass4_FileFilter
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
            this.txtSourcePath = new System.Windows.Forms.TextBox();
            this.lab1 = new System.Windows.Forms.Label();
            this.btnConfirmPath = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtResults = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListDirectories = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnListFiles = new System.Windows.Forms.Button();
            this.txtTargetPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkClearTarget = new System.Windows.Forms.CheckBox();
            this.chkSubDirectories = new System.Windows.Forms.CheckBox();
            this.chkListSubdirectories = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtSourcePath
            // 
            this.txtSourcePath.Location = new System.Drawing.Point(201, 21);
            this.txtSourcePath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSourcePath.Name = "txtSourcePath";
            this.txtSourcePath.Size = new System.Drawing.Size(573, 23);
            this.txtSourcePath.TabIndex = 0;
            this.txtSourcePath.Text = "c:\\4Source";
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(21, 23);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(114, 17);
            this.lab1.TabIndex = 1;
            this.lab1.Text = "Source Directory";
            // 
            // btnConfirmPath
            // 
            this.btnConfirmPath.Location = new System.Drawing.Point(201, 76);
            this.btnConfirmPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmPath.Name = "btnConfirmPath";
            this.btnConfirmPath.Size = new System.Drawing.Size(281, 26);
            this.btnConfirmPath.TabIndex = 2;
            this.btnConfirmPath.Text = "Confirm Paths";
            this.btnConfirmPath.UseVisualStyleBackColor = true;
            this.btnConfirmPath.Click += new System.EventHandler(this.btnConfirmPath_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(29, 108);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(19, 13);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "...";
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(201, 218);
            this.txtResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(573, 275);
            this.txtResults.TabIndex = 4;
            this.txtResults.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Results";
            // 
            // btnListDirectories
            // 
            this.btnListDirectories.Enabled = false;
            this.btnListDirectories.Location = new System.Drawing.Point(201, 132);
            this.btnListDirectories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListDirectories.Name = "btnListDirectories";
            this.btnListDirectories.Size = new System.Drawing.Size(276, 26);
            this.btnListDirectories.TabIndex = 6;
            this.btnListDirectories.Text = "List Student Directories";
            this.btnListDirectories.UseVisualStyleBackColor = true;
            this.btnListDirectories.Click += new System.EventHandler(this.btnListDirectories_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(201, 162);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(413, 23);
            this.txtFilter.TabIndex = 7;
            this.txtFilter.Text = "*Album*Controller.cs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "File Name Filer";
            // 
            // btnListFiles
            // 
            this.btnListFiles.Enabled = false;
            this.btnListFiles.Location = new System.Drawing.Point(201, 188);
            this.btnListFiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListFiles.Name = "btnListFiles";
            this.btnListFiles.Size = new System.Drawing.Size(276, 26);
            this.btnListFiles.TabIndex = 10;
            this.btnListFiles.Text = "List Files";
            this.btnListFiles.UseVisualStyleBackColor = true;
            this.btnListFiles.Click += new System.EventHandler(this.btnListFiles_Click);
            // 
            // txtTargetPath
            // 
            this.txtTargetPath.Location = new System.Drawing.Point(201, 47);
            this.txtTargetPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTargetPath.Name = "txtTargetPath";
            this.txtTargetPath.Size = new System.Drawing.Size(573, 23);
            this.txtTargetPath.TabIndex = 11;
            this.txtTargetPath.Text = "c:\\4Target";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Target Directory";
            // 
            // chkClearTarget
            // 
            this.chkClearTarget.AutoSize = true;
            this.chkClearTarget.Checked = true;
            this.chkClearTarget.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkClearTarget.Location = new System.Drawing.Point(487, 80);
            this.chkClearTarget.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkClearTarget.Name = "chkClearTarget";
            this.chkClearTarget.Size = new System.Drawing.Size(167, 21);
            this.chkClearTarget.TabIndex = 14;
            this.chkClearTarget.Text = "Clear Target Directory";
            this.chkClearTarget.UseVisualStyleBackColor = true;
            // 
            // chkSubDirectories
            // 
            this.chkSubDirectories.AutoSize = true;
            this.chkSubDirectories.Checked = true;
            this.chkSubDirectories.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSubDirectories.Location = new System.Drawing.Point(483, 192);
            this.chkSubDirectories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkSubDirectories.Name = "chkSubDirectories";
            this.chkSubDirectories.Size = new System.Drawing.Size(167, 21);
            this.chkSubDirectories.TabIndex = 15;
            this.chkSubDirectories.Text = "Search Subdirectories";
            this.chkSubDirectories.UseVisualStyleBackColor = true;
            // 
            // chkListSubdirectories
            // 
            this.chkListSubdirectories.AutoSize = true;
            this.chkListSubdirectories.Location = new System.Drawing.Point(483, 135);
            this.chkListSubdirectories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkListSubdirectories.Name = "chkListSubdirectories";
            this.chkListSubdirectories.Size = new System.Drawing.Size(144, 21);
            this.chkListSubdirectories.TabIndex = 16;
            this.chkListSubdirectories.Text = "List Subdirectories";
            this.chkListSubdirectories.UseVisualStyleBackColor = true;
            // 
            // InClass4_FileFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 502);
            this.Controls.Add(this.chkListSubdirectories);
            this.Controls.Add(this.chkSubDirectories);
            this.Controls.Add(this.chkClearTarget);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTargetPath);
            this.Controls.Add(this.btnListFiles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.btnListDirectories);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnConfirmPath);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.txtSourcePath);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InClass4_FileFilter";
            this.Text = "InClass 4 - File Filter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSourcePath;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Button btnConfirmPath;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.RichTextBox txtResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListDirectories;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnListFiles;
        private System.Windows.Forms.TextBox txtTargetPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkClearTarget;
        private System.Windows.Forms.CheckBox chkSubDirectories;
        private System.Windows.Forms.CheckBox chkListSubdirectories;
    }
}