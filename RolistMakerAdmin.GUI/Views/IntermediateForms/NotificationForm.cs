using RolistMakerAdmin.GUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RolistMakerAdmin.GUI.Views.IntermediateForms
{
    public partial class NotificationForm : Form
    {
        private Action action;
        private int x, y;
        public NotificationForm()
        {
            InitializeComponent();
        }
        public enum Action
        {
            wait,
            start,
            close
        }
        public enum TypeNotification
        {
            Success,
            Warning,
            Error,
            Info
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            timer.Interval = 1;
            action = Action.close;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case Action.wait:
                    timer.Interval = 5000;
                    action = Action.close;
                    break;
                case Action.start:
                    this.timer.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action =Action.wait;
                        }
                    }
                    break;
                case Action.close:
                    timer.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        public void ShowAlert(string sMsg, TypeNotification type)
        {
            Opacity = 0.0;
            StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                NotificationForm frm = (NotificationForm)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;

                }

            }
            x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch (type)
            {
                case TypeNotification.Success:
                    this.pictureBox1.Image = Resources.success;
                    this.BackColor = Color.SeaGreen;
                    break;
                case TypeNotification.Error:
                    this.pictureBox1.Image = Resources.error;
                    this.BackColor = Color.DarkRed;
                    break;
                case TypeNotification.Info:
                    this.pictureBox1.Image = Resources.info;
                    this.BackColor = Color.RoyalBlue;
                    break;
                case TypeNotification.Warning:
                    this.pictureBox1.Image = Resources.warning;
                    this.BackColor = Color.DarkOrange;
                    break;
            }

            this.lblMessage.Text = sMsg.Trim();
            this.Show();
            action = Action.start;
            timer.Interval = 1;
            timer.Start();
            
        }
        
    }
}
