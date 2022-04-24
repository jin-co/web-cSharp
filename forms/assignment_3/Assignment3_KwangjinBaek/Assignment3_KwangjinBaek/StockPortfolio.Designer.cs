
namespace Assignment3_KwangjinBaek
{
    partial class StockPortfolio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGetNewId = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.radSell = new System.Windows.Forms.RadioButton();
            this.radBuy = new System.Windows.Forms.RadioButton();
            this.datDate = new System.Windows.Forms.DateTimePicker();
            this.txtCommission = new System.Windows.Forms.TextBox();
            this.txtNumberOfShares = new System.Windows.Forms.TextBox();
            this.txtSharePrice = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtTickerSymbol = new System.Windows.Forms.TextBox();
            this.txtTransactionIdGetNew = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFileNameInput = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteTransaction = new System.Windows.Forms.Button();
            this.txtTranscationIdDelete = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnEmptyFile = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCreateOpenFile = new System.Windows.Forms.Button();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.btnAbout = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "File Name and Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(678, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(585, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Note: double clicking anywhere on a row in the grid will load the details of that" +
    " transcation for wiewing and potential editing.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGetNewId);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnAddUpdate);
            this.groupBox1.Controls.Add(this.txtNotes);
            this.groupBox1.Controls.Add(this.radSell);
            this.groupBox1.Controls.Add(this.radBuy);
            this.groupBox1.Controls.Add(this.datDate);
            this.groupBox1.Controls.Add(this.txtCommission);
            this.groupBox1.Controls.Add(this.txtNumberOfShares);
            this.groupBox1.Controls.Add(this.txtSharePrice);
            this.groupBox1.Controls.Add(this.txtCompany);
            this.groupBox1.Controls.Add(this.txtTickerSymbol);
            this.groupBox1.Controls.Add(this.txtTransactionIdGetNew);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(15, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 435);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/update Transaction:";
            // 
            // btnGetNewId
            // 
            this.btnGetNewId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetNewId.Location = new System.Drawing.Point(192, 24);
            this.btnGetNewId.Name = "btnGetNewId";
            this.btnGetNewId.Size = new System.Drawing.Size(93, 26);
            this.btnGetNewId.TabIndex = 1;
            this.btnGetNewId.Text = "Get New ID";
            this.btnGetNewId.UseVisualStyleBackColor = true;
            this.btnGetNewId.Click += new System.EventHandler(this.btnGetNewId_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(151, 395);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(134, 34);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUpdate.Location = new System.Drawing.Point(6, 395);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(134, 34);
            this.btnAddUpdate.TabIndex = 11;
            this.btnAddUpdate.Text = "Add/update";
            this.btnAddUpdate.UseVisualStyleBackColor = true;
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(85, 182);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(200, 96);
            this.txtNotes.TabIndex = 7;
            this.txtNotes.Text = "";
            // 
            // radSell
            // 
            this.radSell.AutoSize = true;
            this.radSell.Location = new System.Drawing.Point(192, 120);
            this.radSell.Name = "radSell";
            this.radSell.Size = new System.Drawing.Size(42, 17);
            this.radSell.TabIndex = 5;
            this.radSell.TabStop = true;
            this.radSell.Text = "Sell";
            this.radSell.UseVisualStyleBackColor = true;
            // 
            // radBuy
            // 
            this.radBuy.AutoSize = true;
            this.radBuy.Checked = true;
            this.radBuy.Location = new System.Drawing.Point(120, 120);
            this.radBuy.Name = "radBuy";
            this.radBuy.Size = new System.Drawing.Size(43, 17);
            this.radBuy.TabIndex = 4;
            this.radBuy.TabStop = true;
            this.radBuy.Text = "Buy";
            this.radBuy.UseVisualStyleBackColor = true;
            // 
            // datDate
            // 
            this.datDate.CustomFormat = "yyyy-MM-dd";
            this.datDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datDate.Location = new System.Drawing.Point(85, 146);
            this.datDate.Name = "datDate";
            this.datDate.Size = new System.Drawing.Size(200, 20);
            this.datDate.TabIndex = 6;
            // 
            // txtCommission
            // 
            this.txtCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommission.Location = new System.Drawing.Point(111, 347);
            this.txtCommission.Name = "txtCommission";
            this.txtCommission.Size = new System.Drawing.Size(74, 23);
            this.txtCommission.TabIndex = 10;
            // 
            // txtNumberOfShares
            // 
            this.txtNumberOfShares.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfShares.Location = new System.Drawing.Point(111, 317);
            this.txtNumberOfShares.Name = "txtNumberOfShares";
            this.txtNumberOfShares.Size = new System.Drawing.Size(74, 23);
            this.txtNumberOfShares.TabIndex = 9;
            // 
            // txtSharePrice
            // 
            this.txtSharePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSharePrice.Location = new System.Drawing.Point(111, 287);
            this.txtSharePrice.Name = "txtSharePrice";
            this.txtSharePrice.Size = new System.Drawing.Size(74, 23);
            this.txtSharePrice.TabIndex = 8;
            // 
            // txtCompany
            // 
            this.txtCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompany.Location = new System.Drawing.Point(111, 86);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(74, 23);
            this.txtCompany.TabIndex = 3;
            // 
            // txtTickerSymbol
            // 
            this.txtTickerSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTickerSymbol.Location = new System.Drawing.Point(111, 56);
            this.txtTickerSymbol.Name = "txtTickerSymbol";
            this.txtTickerSymbol.Size = new System.Drawing.Size(74, 23);
            this.txtTickerSymbol.TabIndex = 2;
            // 
            // txtTransactionIdGetNew
            // 
            this.txtTransactionIdGetNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransactionIdGetNew.Location = new System.Drawing.Point(111, 26);
            this.txtTransactionIdGetNew.Name = "txtTransactionIdGetNew";
            this.txtTransactionIdGetNew.Size = new System.Drawing.Size(74, 23);
            this.txtTransactionIdGetNew.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 350);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 15);
            this.label11.TabIndex = 11;
            this.label11.Text = "Commission:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "# of Shares:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Share Price:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Notes:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Transaction Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Company:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ticker Symbol:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Transaction ID:";
            // 
            // txtFileNameInput
            // 
            this.txtFileNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileNameInput.Location = new System.Drawing.Point(12, 29);
            this.txtFileNameInput.Name = "txtFileNameInput";
            this.txtFileNameInput.Size = new System.Drawing.Size(430, 23);
            this.txtFileNameInput.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteTransaction);
            this.groupBox2.Controls.Add(this.txtTranscationIdDelete);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(12, 505);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 68);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete Transaction:";
            // 
            // btnDeleteTransaction
            // 
            this.btnDeleteTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTransaction.Location = new System.Drawing.Point(219, 22);
            this.btnDeleteTransaction.Name = "btnDeleteTransaction";
            this.btnDeleteTransaction.Size = new System.Drawing.Size(147, 34);
            this.btnDeleteTransaction.TabIndex = 1;
            this.btnDeleteTransaction.Text = "Delete Transaction";
            this.btnDeleteTransaction.UseVisualStyleBackColor = true;
            this.btnDeleteTransaction.Click += new System.EventHandler(this.btnDeleteTransaction_Click);
            // 
            // txtTranscationIdDelete
            // 
            this.txtTranscationIdDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTranscationIdDelete.Location = new System.Drawing.Point(109, 28);
            this.txtTranscationIdDelete.Name = "txtTranscationIdDelete";
            this.txtTranscationIdDelete.Size = new System.Drawing.Size(74, 23);
            this.txtTranscationIdDelete.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 15);
            this.label12.TabIndex = 24;
            this.label12.Text = "Transaction ID:";
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(449, 527);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(110, 34);
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnEmptyFile
            // 
            this.btnEmptyFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmptyFile.Location = new System.Drawing.Point(565, 527);
            this.btnEmptyFile.Name = "btnEmptyFile";
            this.btnEmptyFile.Size = new System.Drawing.Size(110, 34);
            this.btnEmptyFile.TabIndex = 5;
            this.btnEmptyFile.Text = "Empty File";
            this.btnEmptyFile.UseVisualStyleBackColor = true;
            this.btnEmptyFile.Click += new System.EventHandler(this.btnEmptyFile_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(681, 527);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 34);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(823, 486);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(440, 87);
            this.txtMessage.TabIndex = 6;
            this.txtMessage.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(741, 483);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 17);
            this.label13.TabIndex = 28;
            this.label13.Text = "Messages:";
            // 
            // btnCreateOpenFile
            // 
            this.btnCreateOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateOpenFile.Location = new System.Drawing.Point(448, 23);
            this.btnCreateOpenFile.Name = "btnCreateOpenFile";
            this.btnCreateOpenFile.Size = new System.Drawing.Size(148, 34);
            this.btnCreateOpenFile.TabIndex = 1;
            this.btnCreateOpenFile.Text = "Create/open File";
            this.btnCreateOpenFile.UseVisualStyleBackColor = true;
            this.btnCreateOpenFile.Click += new System.EventHandler(this.btnCreateOpenFile_Click);
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.AllowUserToResizeColumns = false;
            this.gridView.AllowUserToResizeRows = false;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridView.Location = new System.Drawing.Point(321, 64);
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.RowHeadersVisible = false;
            this.gridView.Size = new System.Drawing.Size(942, 416);
            this.gridView.TabIndex = 30;
            this.gridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellDoubleClick);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Silver;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(1183, 12);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(80, 29);
            this.btnAbout.TabIndex = 31;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // StockPortfolio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1275, 585);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.btnCreateOpenFile);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEmptyFile);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtFileNameInput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StockPortfolio";
            this.Text = "Stock Portfolio Tracker";
            this.Load += new System.EventHandler(this.StockPortfolio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtNotes;
        private System.Windows.Forms.RadioButton radSell;
        private System.Windows.Forms.RadioButton radBuy;
        private System.Windows.Forms.DateTimePicker datDate;
        private System.Windows.Forms.TextBox txtCommission;
        private System.Windows.Forms.TextBox txtNumberOfShares;
        private System.Windows.Forms.TextBox txtSharePrice;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtTickerSymbol;
        private System.Windows.Forms.TextBox txtTransactionIdGetNew;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFileNameInput;
        private System.Windows.Forms.Button btnGetNewId;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddUpdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteTransaction;
        private System.Windows.Forms.TextBox txtTranscationIdDelete;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnEmptyFile;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RichTextBox txtMessage;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnCreateOpenFile;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Button btnAbout;
    }
}

