using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaPlayer;
using RolistMakerAdmin.GUI.Controllers;

namespace RolistMakerAdmin.GUI.Views.IntermediateForms
{
    public partial class ParamMusiqueForm : Form
    {
        private IMediaPlayer mediaPlayer;
        private int IDMusique = 0;
        private bool bLoaded = false;
        public int IDGame = 0;
        private EncyclopedieController instance = EncyclopedieController.GetInstance;
        public void Alert(string sMessage, NotificationForm.TypeNotification type)
        {
            NotificationForm form = new NotificationForm();
            form.ShowAlert(sMessage.Trim(), type);
        }
        public void LoadForm()
        {
            bLoaded = false;
            lstMusique.DataSource = instance.GetAllMusiques();
            lstMusique.DisplayMember = "Nom";
            lstMusique.ValueMember = "MusiqueId";
            NewMusique();
            bLoaded = true;
        }

        private void NewMusique()
        {
            txtTitre.Text = "Ma musique";
            lstMusique.SelectedIndex = -1;
            txtTitre.Text = string.Empty;
            IDMusique = 0;
            txtLien.Text = string.Empty;
            btnDeleteMusique.Enabled = false;
        }
        public ParamMusiqueForm()
        {
            InitializeComponent();
        }
        

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewMusique_Click(object sender, EventArgs e)
        {
            NewMusique();
        }

        private void btnSaveMusique_Click(object sender, EventArgs e)
        {
            try
            {
                Enabled = false;
                instance.AddMusique(IDMusique, txtTitre.Text.Trim(), txtLien.Text.Trim());
                Alert("La musique a été ajoutée", NotificationForm.TypeNotification.Success);
                LoadForm();
            }
            catch (Exception ex)
            {
                Alert(ex.Message, NotificationForm.TypeNotification.Error);
            }
            finally
            {
                Enabled = true;
            }
        }

        private void btnDeleteMusique_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = CustomMessageBox.Show("Voulez-vous aussi supprimer le fichier ?", CustomMessageBox.TypeNotification.Info);
                switch(dialogResult)
                {
                    case DialogResult.Yes:
                        instance.DeleteMusique(IDMusique, true);
                        Alert("La musique a été supprimée", NotificationForm.TypeNotification.Success);

                        break;
                    case DialogResult.No:
                        instance.DeleteMusique(IDMusique, false);
                        Alert("La musique a été supprimée", NotificationForm.TypeNotification.Success);

                        break;
                }
                LoadForm();
            }
            catch (Exception ex)
            {
                Alert(ex.Message, NotificationForm.TypeNotification.Error);
            }
        }

        private void ParamMusiqueForm_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void lstMusique_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMusique.SelectedIndex != -1 && bLoaded)
            {
                txtTitre.Text = lstMusique.Text.Trim();
                IDMusique = int.Parse(lstMusique.SelectedValue.ToString());
                btnDeleteMusique.Enabled = true;
            }
        }

        private void btnParcourir_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "MP3|*.mp3";
           if( openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtLien.Text = openFileDialog.FileName;
            }
        }

        private void txtTitre_Leave(object sender, EventArgs e)
        {
            if (txtTitre.Text.Trim() == string.Empty)
                txtTitre.Text = "Ma Musique";
        }

        private void txtTitre_Enter(object sender, EventArgs e)
        {
            if (txtTitre.Text.Trim() == "Ma Musique")
                txtTitre.Text = string.Empty;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

        }

        private void btnPause_Click(object sender, EventArgs e)
        {

        }
    }
}
