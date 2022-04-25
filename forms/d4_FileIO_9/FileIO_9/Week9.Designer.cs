
namespace FileIO_9
{
    partial class Week9
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
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnVerifyFile = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtPartId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.datDate = new System.Windows.Forms.DateTimePicker();
            this.txtClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.txtDisplayRecord = new System.Windows.Forms.RichTextBox();
            this.btnArchive = new System.Windows.Forms.Button();
            this.btnGetCurrentDirectory = new System.Windows.Forms.Button();
            this.btnCreatedtime = new System.Windows.Forms.Button();
            this.btnLastWrittenTime = new System.Windows.Forms.Button();
            this.btnLastAccessTime = new System.Windows.Forms.Button();
            this.btnEnumerateFile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(36, 12);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(164, 26);
            this.txtFile.TabIndex = 0;
            this.txtFile.Text = "test.txt";
            // 
            // btnVerifyFile
            // 
            this.btnVerifyFile.Location = new System.Drawing.Point(206, 12);
            this.btnVerifyFile.Name = "btnVerifyFile";
            this.btnVerifyFile.Size = new System.Drawing.Size(92, 26);
            this.btnVerifyFile.TabIndex = 1;
            this.btnVerifyFile.Text = "Verify File";
            this.btnVerifyFile.UseVisualStyleBackColor = true;
            this.btnVerifyFile.Click += new System.EventHandler(this.btnVerifyFile_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(655, 255);
            this.lblMessage.MaximumSize = new System.Drawing.Size(200, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(21, 20);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "...";
            // 
            // txtPartId
            // 
            this.txtPartId.Location = new System.Drawing.Point(134, 123);
            this.txtPartId.Name = "txtPartId";
            this.txtPartId.Size = new System.Drawing.Size(200, 26);
            this.txtPartId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(32, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Part ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(32, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(134, 155);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 26);
            this.txtName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(32, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(32, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cost";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(134, 219);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(200, 26);
            this.txtCost.TabIndex = 5;
            // 
            // datDate
            // 
            this.datDate.CustomFormat = "yyyy/MM/dd";
            this.datDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datDate.Location = new System.Drawing.Point(134, 187);
            this.datDate.Name = "datDate";
            this.datDate.Size = new System.Drawing.Size(200, 26);
            this.datDate.TabIndex = 4;
            // 
            // txtClose
            // 
            this.txtClose.ForeColor = System.Drawing.Color.Red;
            this.txtClose.Location = new System.Drawing.Point(438, 123);
            this.txtClose.Name = "txtClose";
            this.txtClose.Size = new System.Drawing.Size(92, 26);
            this.txtClose.TabIndex = 10;
            this.txtClose.Text = "Close";
            this.txtClose.UseVisualStyleBackColor = true;
            this.txtClose.Click += new System.EventHandler(this.txtClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(340, 123);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 26);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(340, 152);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 26);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(340, 184);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 26);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(340, 216);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 26);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(438, 155);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(92, 26);
            this.btnFind.TabIndex = 11;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(438, 216);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(92, 26);
            this.btnDisplay.TabIndex = 12;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // txtDisplayRecord
            // 
            this.txtDisplayRecord.Location = new System.Drawing.Point(36, 255);
            this.txtDisplayRecord.Name = "txtDisplayRecord";
            this.txtDisplayRecord.Size = new System.Drawing.Size(613, 349);
            this.txtDisplayRecord.TabIndex = 19;
            this.txtDisplayRecord.Text = "";
            // 
            // btnArchive
            // 
            this.btnArchive.Location = new System.Drawing.Point(438, 187);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(92, 26);
            this.btnArchive.TabIndex = 20;
            this.btnArchive.Text = "Archive D";
            this.btnArchive.UseVisualStyleBackColor = true;
            // 
            // btnGetCurrentDirectory
            // 
            this.btnGetCurrentDirectory.Location = new System.Drawing.Point(340, 12);
            this.btnGetCurrentDirectory.Name = "btnGetCurrentDirectory";
            this.btnGetCurrentDirectory.Size = new System.Drawing.Size(226, 26);
            this.btnGetCurrentDirectory.TabIndex = 21;
            this.btnGetCurrentDirectory.Text = "Get Current Directory";
            this.btnGetCurrentDirectory.UseVisualStyleBackColor = true;
            this.btnGetCurrentDirectory.Click += new System.EventHandler(this.btnGetCurrentDirectory_Click);
            // 
            // btnCreatedtime
            // 
            this.btnCreatedtime.Location = new System.Drawing.Point(340, 44);
            this.btnCreatedtime.Name = "btnCreatedtime";
            this.btnCreatedtime.Size = new System.Drawing.Size(226, 26);
            this.btnCreatedtime.TabIndex = 22;
            this.btnCreatedtime.Text = "Created Time";
            this.btnCreatedtime.UseVisualStyleBackColor = true;
            this.btnCreatedtime.Click += new System.EventHandler(this.btnCreatedtime_Click);
            // 
            // btnLastWrittenTime
            // 
            this.btnLastWrittenTime.Location = new System.Drawing.Point(572, 12);
            this.btnLastWrittenTime.Name = "btnLastWrittenTime";
            this.btnLastWrittenTime.Size = new System.Drawing.Size(226, 26);
            this.btnLastWrittenTime.TabIndex = 23;
            this.btnLastWrittenTime.Text = "Last Written Time";
            this.btnLastWrittenTime.UseVisualStyleBackColor = true;
            this.btnLastWrittenTime.Click += new System.EventHandler(this.btnLastWrittenTime_Click);
            // 
            // btnLastAccessTime
            // 
            this.btnLastAccessTime.Location = new System.Drawing.Point(572, 44);
            this.btnLastAccessTime.Name = "btnLastAccessTime";
            this.btnLastAccessTime.Size = new System.Drawing.Size(226, 26);
            this.btnLastAccessTime.TabIndex = 24;
            this.btnLastAccessTime.Text = "Last Access Time";
            this.btnLastAccessTime.UseVisualStyleBackColor = true;
            this.btnLastAccessTime.Click += new System.EventHandler(this.btnLastAccessTime_Click);
            // 
            // btnEnumerateFile
            // 
            this.btnEnumerateFile.Location = new System.Drawing.Point(804, 12);
            this.btnEnumerateFile.Name = "btnEnumerateFile";
            this.btnEnumerateFile.Size = new System.Drawing.Size(226, 26);
            this.btnEnumerateFile.TabIndex = 25;
            this.btnEnumerateFile.Text = "Enumerate File";
            this.btnEnumerateFile.UseVisualStyleBackColor = true;
            this.btnEnumerateFile.Click += new System.EventHandler(this.btnEnumerateFile_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(804, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 26);
            this.button1.TabIndex = 26;
            this.button1.Text = "Enumerate Directories";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Week9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 628);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEnumerateFile);
            this.Controls.Add(this.btnLastAccessTime);
            this.Controls.Add(this.btnLastWrittenTime);
            this.Controls.Add(this.btnCreatedtime);
            this.Controls.Add(this.btnGetCurrentDirectory);
            this.Controls.Add(this.btnArchive);
            this.Controls.Add(this.txtDisplayRecord);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtClose);
            this.Controls.Add(this.datDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPartId);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnVerifyFile);
            this.Controls.Add(this.txtFile);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Week9";
            this.Text = "FileIO";
            this.Load += new System.EventHandler(this.Week9_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnVerifyFile;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtPartId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.DateTimePicker datDate;
        private System.Windows.Forms.Button txtClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.RichTextBox txtDisplayRecord;
        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.Button btnGetCurrentDirectory;
        private System.Windows.Forms.Button btnCreatedtime;
        private System.Windows.Forms.Button btnLastWrittenTime;
        private System.Windows.Forms.Button btnLastAccessTime;
        private System.Windows.Forms.Button btnEnumerateFile;
        private System.Windows.Forms.Button button1;
    }
}

