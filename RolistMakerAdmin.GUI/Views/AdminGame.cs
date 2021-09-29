using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using RolistMakerAdmin.GUI.Controllers;
using RolistMakerAdmin.GUI.Views.IntermediateForms;

namespace RolistMakerAdmin.GUI.Views
{
    public partial class AdminGame : Form
    {
        public int IDGame { get; set; }
        private Form activeForm = null;
        private EncyclopedieController instance = EncyclopedieController.GetInstance;
        private bool bMov = false;


        private void LoadForm()
        {
            try
            {
                CustomizeSubMenu();            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue sur la fonction <LoadForm>:\n" + ex.Message, "Rolist Maker Admin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void OpenChildForm(Form ChildForm)
        {
            if(activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.Owner = this;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(ChildForm);
            ChildForm.Tag = ChildForm;
            ChildForm.BringToFront();
            
            ChildForm.Show();
            
        }
        private void CustomizeSubMenu()
        {
            panelGeneralSubMenu.Visible = false;
            panelMusiqueSubMenu.Visible = false;
        }
        private void HideSubMenu()
        {
            if (panelGeneralSubMenu.Visible == true)
                panelGeneralSubMenu.Visible = false;
            if (panelMusiqueSubMenu.Visible == true)
                panelMusiqueSubMenu.Visible = false;
        }
        private void ShowSubMenu(Panel panelSubMenu)
        {
            if (panelSubMenu.Visible == false)
            {
                HideSubMenu();
                panelSubMenu.Visible = true;
            }
            else
                panelSubMenu.Visible = false;
        }
        public AdminGame()
        {
            InitializeComponent();
        }



        private void btnGeneral_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelGeneralSubMenu);
        }

        private void btnAboutGame_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AboutGameForm());
            HideSubMenu();
        }

        private void btnParamPersonnage_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ParamPlayersForm());
            HideSubMenu();
        }

        private void btnMusique_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelMusiqueSubMenu);
        }

        private void btnUseMusique_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ParamMusiqueForm());
            HideSubMenu();
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void AdminGame_Load(object sender, EventArgs e)
        {
            CustomizeSubMenu();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximise_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnReduce_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelBoxButtons_MouseDown(object sender, MouseEventArgs e)
        {
            bMov = true;
        }

        private void panelBoxButtons_MouseLeave(object sender, EventArgs e)
        {
            bMov = false;
        }

        private void panelBoxButtons_MouseMove(object sender, MouseEventArgs e)
        {
            if (bMov == true)
            {
                SetDesktopLocation(MousePosition.X - 200 ,MousePosition.Y );
            }
                
        }
    }
}
