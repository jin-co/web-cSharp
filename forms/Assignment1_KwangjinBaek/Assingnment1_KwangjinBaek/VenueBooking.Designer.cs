
namespace Assingnment1_KwangjinBaek
{
    partial class VenueBooking
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
            this.lstRow = new System.Windows.Forms.ListBox();
            this.lstSeat = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowWaitingList = new System.Windows.Forms.Button();
            this.btnShowAllReservations = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnAddToWaiting = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnDebugFillAllSeat = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAvailableSeats = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstRow
            // 
            this.lstRow.FormattingEnabled = true;
            this.lstRow.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.lstRow.Location = new System.Drawing.Point(10, 52);
            this.lstRow.Name = "lstRow";
            this.lstRow.Size = new System.Drawing.Size(45, 95);
            this.lstRow.TabIndex = 0;
            // 
            // lstSeat
            // 
            this.lstSeat.FormattingEnabled = true;
            this.lstSeat.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.lstSeat.Location = new System.Drawing.Point(74, 52);
            this.lstSeat.Name = "lstSeat";
            this.lstSeat.Size = new System.Drawing.Size(45, 95);
            this.lstSeat.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowWaitingList);
            this.groupBox1.Controls.Add(this.btnShowAllReservations);
            this.groupBox1.Controls.Add(this.richTextBox2);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(252, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 217);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bookings and Reservations";
            // 
            // btnShowWaitingList
            // 
            this.btnShowWaitingList.Location = new System.Drawing.Point(210, 26);
            this.btnShowWaitingList.Name = "btnShowWaitingList";
            this.btnShowWaitingList.Size = new System.Drawing.Size(123, 23);
            this.btnShowWaitingList.TabIndex = 3;
            this.btnShowWaitingList.Text = "Show Waiting List";
            this.btnShowWaitingList.UseVisualStyleBackColor = true;
            this.btnShowWaitingList.Click += new System.EventHandler(this.btnShowWaitingList_Click);
            // 
            // btnShowAllReservations
            // 
            this.btnShowAllReservations.Location = new System.Drawing.Point(19, 26);
            this.btnShowAllReservations.Name = "btnShowAllReservations";
            this.btnShowAllReservations.Size = new System.Drawing.Size(123, 23);
            this.btnShowAllReservations.TabIndex = 2;
            this.btnShowAllReservations.Text = "Show All Reservations";
            this.btnShowAllReservations.UseVisualStyleBackColor = true;
            this.btnShowAllReservations.Click += new System.EventHandler(this.btnShowAllReservations_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(193, 55);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(151, 156);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 55);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(151, 156);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnAddToWaiting
            // 
            this.btnAddToWaiting.Location = new System.Drawing.Point(479, 88);
            this.btnAddToWaiting.Name = "btnAddToWaiting";
            this.btnAddToWaiting.Size = new System.Drawing.Size(105, 23);
            this.btnAddToWaiting.TabIndex = 6;
            this.btnAddToWaiting.Text = "Add To Waiting";
            this.btnAddToWaiting.UseVisualStyleBackColor = true;
            this.btnAddToWaiting.Click += new System.EventHandler(this.btnAddToWaiting_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(368, 88);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(257, 88);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(105, 23);
            this.btnBook.TabIndex = 8;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnDebugFillAllSeat
            // 
            this.btnDebugFillAllSeat.ForeColor = System.Drawing.Color.Red;
            this.btnDebugFillAllSeat.Location = new System.Drawing.Point(257, 117);
            this.btnDebugFillAllSeat.Name = "btnDebugFillAllSeat";
            this.btnDebugFillAllSeat.Size = new System.Drawing.Size(216, 23);
            this.btnDebugFillAllSeat.TabIndex = 9;
            this.btnDebugFillAllSeat.Text = "Debug - Fill All Seats";
            this.btnDebugFillAllSeat.UseVisualStyleBackColor = true;
            this.btnDebugFillAllSeat.Click += new System.EventHandler(this.btnDebugFillAllSeat_Click);
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(479, 117);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(257, 52);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(327, 20);
            this.txtCustomerName.TabIndex = 11;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(12, 403);
            this.lblMessage.MaximumSize = new System.Drawing.Size(226, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(21, 20);
            this.lblMessage.TabIndex = 12;
            this.lblMessage.Text = "...";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(155, 55);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(85, 13);
            this.lblCustomerName.TabIndex = 13;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Row";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Seat";
            // 
            // lblAvailableSeats
            // 
            this.lblAvailableSeats.AutoSize = true;
            this.lblAvailableSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableSeats.ForeColor = System.Drawing.Color.Blue;
            this.lblAvailableSeats.Location = new System.Drawing.Point(255, 384);
            this.lblAvailableSeats.MaximumSize = new System.Drawing.Size(327, 0);
            this.lblAvailableSeats.Name = "lblAvailableSeats";
            this.lblAvailableSeats.Size = new System.Drawing.Size(21, 20);
            this.lblAvailableSeats.TabIndex = 16;
            this.lblAvailableSeats.Text = "...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Assingnment1_KwangjinBaek.Properties.Resources.Untitled;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstRow);
            this.groupBox2.Controls.Add(this.lstSeat);
            this.groupBox2.Controls.Add(this.btnAddToWaiting);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnBook);
            this.groupBox2.Controls.Add(this.lblCustomerName);
            this.groupBox2.Controls.Add(this.btnDebugFillAllSeat);
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.txtCustomerName);
            this.groupBox2.Location = new System.Drawing.Point(12, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(592, 153);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bookings, Cancellations";
            // 
            // VenueBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 495);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAvailableSeats);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.groupBox1);
            this.Name = "VenueBooking";
            this.Text = "Venue Booking";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstRow;
        private System.Windows.Forms.ListBox lstSeat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShowWaitingList;
        private System.Windows.Forms.Button btnShowAllReservations;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnAddToWaiting;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnDebugFillAllSeat;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAvailableSeats;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

