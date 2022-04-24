using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inclass_2_KwangjinBaek
{
    // written by Kwangjin Baek
    /* this application is a alarm clock 
     * users can set an alarm 
     * if clock reach the alarm goes off */
    public partial class AlarmClock : Form
    {
        SoundPlayer alarm = new SoundPlayer(
            @"c:\windows\media\Windows Logoff Sound.wav");
        bool isAlarmOn = false;

        public AlarmClock()
        {
            InitializeComponent();
        }

        private void TimerClock_Load(object sender, EventArgs e)
        {
            timerClock.Start();
            timerAlarm.Start();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblTimeDisplay.Text = FormatTime(DateTime.Now);
        }

        // stop the alarm
        private void btnStopAlarm_Click(object sender, EventArgs e)
        {
            timerAlarm.Enabled = false;
            isAlarmOn = false;
        }

        private void timerAlarm_Tick(object sender, EventArgs e)
        {
            if (chkAlarmActive.Checked)
            {
                if (txtAlarmTimeSetting.Text == lblTimeDisplay.Text)
                {
                    timerAlarm.Enabled = true;
                    isAlarmOn = true;
                }
            }
            if (isAlarmOn)
            {
                alarm.Play();
            }
        }

        // check time format
        // display error if it is wrong format
        private void chkAlarmActive_CheckedChanged(object sender, EventArgs e)
        {
            DateTime timeConverted = DateTime.Now;
            if (DateTime.TryParse(txtAlarmTimeSetting.Text, out timeConverted))
            {
                if (chk24TimeFormat.Checked)
                {
                    txtAlarmTimeSetting.Text = timeConverted.ToString("hh:mm:ss");
                }
                else
                {
                    txtAlarmTimeSetting.Text = timeConverted.ToString("hh:mm:ss:tt");
                }
            }
            else
            {
                lblMessage.Text = "Wrong time format. Please Enter 00:00:00";
            }
        }

        // show contact information
        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Author:\tKwangjin Baek\n" +
                "Email:\nlilijk@hanmail.com\n",
                "Contact Us", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // format time
        private string FormatTime(DateTime time)
        {
            if (chk24TimeFormat.Checked)
            {
                return time.ToString("HH:mm:ss");
            }
            else
            {
                return time.ToString("hh:mm:ss:tt");
            }
        }

        // clear previous error message
        private void txtAlarmTimeSetting_TextChanged(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }
    }
}
