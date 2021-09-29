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
    public partial class CustomMessageBox : Form
    {
        static DialogResult myResult;
        public static CustomMessageBox form;
        public CustomMessageBox()
        {
            InitializeComponent();
        }
        public enum TypeNotification
        {
            Success,
            Warning,
            Error,
            Info
        }


        public  static DialogResult Show(string sMessage, TypeNotification type)
        {
            form = new CustomMessageBox();
            form.label1.Text = sMessage.Trim();
            form.Size = new Size(389 + form.label1.Size.Width, 158+ form.label1.Size.Height);
            switch (type)
            {
                case TypeNotification.Success:
                    form.pictureBox1.Image = Resources.success;
                    form.BackColor = Color.SeaGreen;
                    break;
                case TypeNotification.Error:
                    form.pictureBox1.Image = Resources.error;
                    form.BackColor = Color.DarkRed;
                    break;
                case TypeNotification.Info:
                    form.pictureBox1.Image = Resources.info;
                    form.BackColor = Color.RoyalBlue;
                    break;
                case TypeNotification.Warning:
                    form.pictureBox1.Image = Resources.warning;
                    form.BackColor = Color.DarkOrange;
                    break;
            }
            form.ShowDialog();
            return myResult;
        }
        
     

        private void btnYes_Click(object sender, EventArgs e)
        {
            myResult = DialogResult.Yes;
            form.Close();
            
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            myResult = DialogResult.No;
            form.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            myResult = DialogResult.Cancel;
            form.Close();

        }
    }
}
