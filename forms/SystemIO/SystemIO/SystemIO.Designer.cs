
namespace SystemIO
{
    partial class SystemIO
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtFile = new System.Windows.Forms.RichTextBox();
            this.btnFormat = new System.Windows.Forms.Button();
            this.txtExist = new System.Windows.Forms.Button();
            this.txtCreate = new System.Windows.Forms.Button();
            this.txtDelete = new System.Windows.Forms.Button();
            this.txtListDirectory = new System.Windows.Forms.Button();
            this.txtListForm = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtClose = new System.Windows.Forms.Button();
            this.btnRecursiveDelete = new System.Windows.Forms.Button();
            this.btnSplit = new System.Windows.Forms.Button();
            this.btnListAllDirectory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(38, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 24);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(38, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 24);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(38, 104);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 24);
            this.textBox3.TabIndex = 2;
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(38, 356);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(460, 24);
            this.txtInput.TabIndex = 3;
            // 
            // txtFile
            // 
            this.txtFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFile.Location = new System.Drawing.Point(38, 156);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(460, 184);
            this.txtFile.TabIndex = 4;
            this.txtFile.Text = "";
            // 
            // btnFormat
            // 
            this.btnFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormat.Location = new System.Drawing.Point(514, 356);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(75, 23);
            this.btnFormat.TabIndex = 5;
            this.btnFormat.Text = "Format";
            this.btnFormat.UseVisualStyleBackColor = true;
            this.btnFormat.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // txtExist
            // 
            this.txtExist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExist.Location = new System.Drawing.Point(38, 396);
            this.txtExist.Name = "txtExist";
            this.txtExist.Size = new System.Drawing.Size(75, 23);
            this.txtExist.TabIndex = 6;
            this.txtExist.Text = "Exist";
            this.txtExist.UseVisualStyleBackColor = true;
            this.txtExist.Click += new System.EventHandler(this.txtExist_Click);
            // 
            // txtCreate
            // 
            this.txtCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreate.Location = new System.Drawing.Point(119, 396);
            this.txtCreate.Name = "txtCreate";
            this.txtCreate.Size = new System.Drawing.Size(75, 23);
            this.txtCreate.TabIndex = 7;
            this.txtCreate.Text = "Create";
            this.txtCreate.UseVisualStyleBackColor = true;
            this.txtCreate.Click += new System.EventHandler(this.txtCreate_Click);
            // 
            // txtDelete
            // 
            this.txtDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelete.Location = new System.Drawing.Point(200, 396);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(75, 23);
            this.txtDelete.TabIndex = 8;
            this.txtDelete.Text = "Delete";
            this.txtDelete.UseVisualStyleBackColor = true;
            this.txtDelete.Click += new System.EventHandler(this.txtDelete_Click);
            // 
            // txtListDirectory
            // 
            this.txtListDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListDirectory.Location = new System.Drawing.Point(281, 396);
            this.txtListDirectory.Name = "txtListDirectory";
            this.txtListDirectory.Size = new System.Drawing.Size(118, 23);
            this.txtListDirectory.TabIndex = 9;
            this.txtListDirectory.Text = "List Directory";
            this.txtListDirectory.UseVisualStyleBackColor = true;
            this.txtListDirectory.Click += new System.EventHandler(this.txtListDirectory_Click);
            // 
            // txtListForm
            // 
            this.txtListForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListForm.Location = new System.Drawing.Point(405, 396);
            this.txtListForm.Name = "txtListForm";
            this.txtListForm.Size = new System.Drawing.Size(93, 23);
            this.txtListForm.TabIndex = 10;
            this.txtListForm.Text = "List Forms";
            this.txtListForm.UseVisualStyleBackColor = true;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(511, 156);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(46, 18);
            this.lblMessage.TabIndex = 11;
            this.lblMessage.Text = "label1";
            // 
            // txtClose
            // 
            this.txtClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClose.Location = new System.Drawing.Point(595, 357);
            this.txtClose.Name = "txtClose";
            this.txtClose.Size = new System.Drawing.Size(193, 62);
            this.txtClose.TabIndex = 12;
            this.txtClose.Text = "Close";
            this.txtClose.UseVisualStyleBackColor = true;
            this.txtClose.Click += new System.EventHandler(this.txtClose_Click);
            // 
            // btnRecursiveDelete
            // 
            this.btnRecursiveDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecursiveDelete.Location = new System.Drawing.Point(38, 425);
            this.btnRecursiveDelete.Name = "btnRecursiveDelete";
            this.btnRecursiveDelete.Size = new System.Drawing.Size(181, 23);
            this.btnRecursiveDelete.TabIndex = 13;
            this.btnRecursiveDelete.Text = "Recursive Delete";
            this.btnRecursiveDelete.UseVisualStyleBackColor = true;
            this.btnRecursiveDelete.Click += new System.EventHandler(this.btnRecursiveDelete_Click);
            // 
            // btnSplit
            // 
            this.btnSplit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSplit.Location = new System.Drawing.Point(405, 425);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(93, 23);
            this.btnSplit.TabIndex = 14;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // btnListAllDirectory
            // 
            this.btnListAllDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListAllDirectory.Location = new System.Drawing.Point(218, 425);
            this.btnListAllDirectory.Name = "btnListAllDirectory";
            this.btnListAllDirectory.Size = new System.Drawing.Size(181, 23);
            this.btnListAllDirectory.TabIndex = 15;
            this.btnListAllDirectory.Text = "List All Directory";
            this.btnListAllDirectory.UseVisualStyleBackColor = true;
            this.btnListAllDirectory.Click += new System.EventHandler(this.btnListAllDirectory_Click);
            // 
            // SystemIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListAllDirectory);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.btnRecursiveDelete);
            this.Controls.Add(this.txtClose);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtListForm);
            this.Controls.Add(this.txtListDirectory);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.txtCreate);
            this.Controls.Add(this.txtExist);
            this.Controls.Add(this.btnFormat);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "SystemIO";
            this.Text = "System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.RichTextBox txtFile;
        private System.Windows.Forms.Button btnFormat;
        private System.Windows.Forms.Button txtExist;
        private System.Windows.Forms.Button txtCreate;
        private System.Windows.Forms.Button txtDelete;
        private System.Windows.Forms.Button txtListDirectory;
        private System.Windows.Forms.Button txtListForm;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button txtClose;
        private System.Windows.Forms.Button btnRecursiveDelete;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Button btnListAllDirectory;
    }
}

