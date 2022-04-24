
namespace Inclass_2_KwangjinBaek
{
    partial class AlarmClock
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
            this.components = new System.ComponentModel.Container();
            this.lblTimeDisplay = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.chk24TimeFormat = new System.Windows.Forms.CheckBox();
            this.chkAlarmActive = new System.Windows.Forms.CheckBox();
            this.txtAlarmTimeSetting = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnStopAlarm = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.timerAlarm = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTimeDisplay
            // 
            this.lblTimeDisplay.AutoSize = true;
            this.lblTimeDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTimeDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTimeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeDisplay.Location = new System.Drawing.Point(32, 39);
            this.lblTimeDisplay.Name = "lblTimeDisplay";
            this.lblTimeDisplay.Size = new System.Drawing.Size(247, 65);
            this.lblTimeDisplay.TabIndex = 0;
            this.lblTimeDisplay.Text = "00:00:00";
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(29, 212);
            this.lblMessage.MinimumSize = new System.Drawing.Size(250, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(250, 22);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "...";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerClock
            // 
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // chk24TimeFormat
            // 
            this.chk24TimeFormat.AutoSize = true;
            this.chk24TimeFormat.Location = new System.Drawing.Point(32, 132);
            this.chk24TimeFormat.Name = "chk24TimeFormat";
            this.chk24TimeFormat.Size = new System.Drawing.Size(145, 17);
            this.chk24TimeFormat.TabIndex = 2;
            this.chk24TimeFormat.Text = "Switch to 24 Hours clock";
            this.chk24TimeFormat.UseVisualStyleBackColor = true;
            
            // 
            // chkAlarmActive
            // 
            this.chkAlarmActive.AutoSize = true;
            this.chkAlarmActive.Location = new System.Drawing.Point(150, 25);
            this.chkAlarmActive.Name = "chkAlarmActive";
            this.chkAlarmActive.Size = new System.Drawing.Size(94, 17);
            this.chkAlarmActive.TabIndex = 3;
            this.chkAlarmActive.Text = "Activate Alarm";
            this.chkAlarmActive.UseVisualStyleBackColor = true;
            this.chkAlarmActive.CheckedChanged += new System.EventHandler(this.chkAlarmActive_CheckedChanged);
            // 
            // txtAlarmTimeSetting
            // 
            this.txtAlarmTimeSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlarmTimeSetting.Location = new System.Drawing.Point(6, 19);
            this.txtAlarmTimeSetting.Name = "txtAlarmTimeSetting";
            this.txtAlarmTimeSetting.Size = new System.Drawing.Size(120, 23);
            this.txtAlarmTimeSetting.TabIndex = 4;
            this.txtAlarmTimeSetting.TextChanged += new System.EventHandler(this.txtAlarmTimeSetting_TextChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "";
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // btnStopAlarm
            // 
            this.btnStopAlarm.Location = new System.Drawing.Point(396, 39);
            this.btnStopAlarm.Name = "btnStopAlarm";
            this.btnStopAlarm.Size = new System.Drawing.Size(54, 50);
            this.btnStopAlarm.TabIndex = 5;
            this.btnStopAlarm.Text = "Stop Alarm";
            this.btnStopAlarm.UseVisualStyleBackColor = true;
            this.btnStopAlarm.Click += new System.EventHandler(this.btnStopAlarm_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(396, 95);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(54, 23);
            this.btnAbout.TabIndex = 6;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // timerAlarm
            // 
            this.timerAlarm.Interval = 1000;
            this.timerAlarm.Tick += new System.EventHandler(this.timerAlarm_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAlarmTimeSetting);
            this.groupBox1.Controls.Add(this.chkAlarmActive);
            this.groupBox1.Location = new System.Drawing.Point(32, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 49);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alarm";
            // 
            // AlarmClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(480, 243);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnStopAlarm);
            this.Controls.Add(this.chk24TimeFormat);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblTimeDisplay);
            this.Name = "AlarmClock";
            this.Text = "Alarm Clock";
            this.Load += new System.EventHandler(this.TimerClock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimeDisplay;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.CheckBox chk24TimeFormat;
        private System.Windows.Forms.CheckBox chkAlarmActive;
        private System.Windows.Forms.TextBox txtAlarmTimeSetting;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnStopAlarm;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Timer timerAlarm;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

