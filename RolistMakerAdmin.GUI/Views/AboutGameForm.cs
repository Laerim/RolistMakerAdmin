using RolistMakerAdmin.GUI.Controllers;
using RolistMakerAdmin.GUI.Views.IntermediateForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RolistMakerAdmin.GUI.Views
{
    public partial class AboutGameForm : Form
    {

        
        private void LoadForm()
        {
            if(((AdminGame)Owner).IDGame != 0)
            {
                Game game = EncyclopedieController.GetInstance.GetGame(((AdminGame)Owner).IDGame);
                txtTitle.Text = game.Titre.Trim();
                txtDescription.Text = game.Description.Trim();
            }
        }
        public AboutGameForm()
        {
            InitializeComponent();
        }

        private void lblDescription_Click(object sender, EventArgs e)
        {
            txtDescription.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            string sTitle = string.Empty;
            if (txtTitle.Text.Trim() != "Titre du jeu")
                sTitle = txtTitle.Text.Trim();
            try
            {
                int idGame = EncyclopedieController.GetInstance.SaveGame(0, sTitle, txtDescription.Text);
                ((AdminGame)Owner).IDGame = idGame;
                Alert("La description du jeu a bien enregistrée", NotificationForm.TypeNotification.Success);
            }
            catch(Exception ex)
            {
                Alert(ex.Message, NotificationForm.TypeNotification.Error);
            }
            finally
            {
                Enabled = true;
            }
    }
        public void Alert(string sMessage, NotificationForm.TypeNotification type)
        {
            NotificationForm form = new NotificationForm();
            form.ShowAlert(sMessage.Trim(), type);
        }

        private void txtTitle_Enter(object sender, EventArgs e)
        {
            if (txtTitle.Text.Trim() == "Titre du jeu")
                txtTitle.Text = string.Empty;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutGameForm_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
    }
}
