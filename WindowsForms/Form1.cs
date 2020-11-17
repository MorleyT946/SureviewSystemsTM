using ServiceLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class FrmEnterAlarm : Form
    {
        public FrmEnterAlarm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string message = txtMessage.Text;

            if (message.Length > 0)
            {
                lblError.Visible = false;

                AlarmParse alarmParse = AlarmParse.ParseMessage(message);

                if (alarmParse.CorrectMessage == true)
                {
                    grpResult.BackColor = Color.LightGreen;
                    grpResult.Visible = true;

                    lblRetrunMessage.Text = alarmParse.ReturnMessage;
                    lblServerNumber.Text = "Server Number: " + alarmParse.ServerNumber;
                    lblAlarmID.Text = "Alarm ID: " + alarmParse.AlarmId;
                }
                else
                {
                    grpResult.BackColor = Color.Red;
                    grpResult.Visible = true;
                    grpResult.ForeColor = Color.White;

                    lblRetrunMessage.Text = alarmParse.ReturnMessage;
                    if (alarmParse.ServerNumber == null)
                    {
                        lblServerNumber.Text = "Server Number: Not Found";
                    }
                    else
                    {
                        lblServerNumber.Text = "Server Number: " + alarmParse.ServerNumber;
                    }

                    if(alarmParse.AlarmId == null)
                    {
                        lblAlarmID.Text = "Alarm ID: Not Found" ;
                    }
                    else
                    {
                        lblAlarmID.Text = "Alarm ID: " + alarmParse.AlarmId;
                    }
                    
                }

            }
            else
            {
                lblError.Text = "Text must be entered.";
                lblError.Visible = true;
                grpResult.Visible = false;
            }
        }
    }
}
