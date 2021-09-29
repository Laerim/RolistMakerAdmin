using RolistMakerAdmin.GUI.Controllers;
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
    public partial class ParamPlayersForm : Form
    {
        private int iIDSexe = 0;
        private bool bLoadedSexes = false;
        private EncyclopedieController instance = EncyclopedieController.GetInstance;
        public ParamPlayersForm()
        {
            InitializeComponent();
        }
        private void LoadForm()
        {
            LoadSexes();
        }
        private void LoadSexes()
        {
            bLoadedSexes = false;
            lstSexe.DataSource = instance.GetAllSexes();
            lstSexe.DisplayMember = "Nom";
            lstSexe.ValueMember = "SexeId";
            bLoadedSexes = true;

            //dtgSexes.Columns["Game"].Visible = false;
        }
        public void Alert(string sMessage, NotificationForm.TypeNotification type)
        {
            NotificationForm form = new NotificationForm();
            form.ShowAlert(sMessage.Trim(), type);
        }

        private void NewSexe()
        {
            lstSexe.SelectedIndex = -1;
            txtSexe.Text = string.Empty;
            iIDSexe = 0;
            btnDeleteSexe.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewSexe();
        }

        private void btnSaveSexe_Click(object sender, EventArgs e)
        {
            try
            {
                instance.AddSexe(iIDSexe, txtSexe.Text.Trim());
                Alert("Le sexe \""+txtSexe.Text.Trim()+"\" a été ajoutée", NotificationForm.TypeNotification.Success);
                LoadSexes();
                NewSexe();

            }
            catch (Exception ex)
            {
                Alert(ex.Message, NotificationForm.TypeNotification.Error);
            }


        }

        private void btnDeleteSexe_Click(object sender, EventArgs e)
        {
            try
            {
                instance.DeleteSexe(iIDSexe);
                Alert("Le sexe \"" + txtSexe.Text.Trim() + "\" a été supprimé", NotificationForm.TypeNotification.Success);
                LoadSexes();
                NewSexe();
            }
            catch (Exception ex)
            {
                Alert(ex.Message, NotificationForm.TypeNotification.Error);
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSexe_Enter(object sender, EventArgs e)
        {
            if (txtSexe.Text.Trim() == "Sexe à ajouter")
                txtSexe.Text = string.Empty;
        }

        private void txtSexe_Leave(object sender, EventArgs e)
        {
            if (txtSexe.Text.Trim() == string.Empty)
                txtSexe.Text = "Sexe à ajouter";
        }

        private void ParamPlayersForm_Load(object sender, EventArgs e)
        {
            LoadForm();
            bLoadedSexes = true;
        }

        private void lstSexe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSexe.SelectedIndex != -1 && bLoadedSexes)
            {
                txtSexe.Text = lstSexe.Text.Trim();
                iIDSexe = int.Parse(lstSexe.SelectedValue.ToString());
                btnDeleteSexe.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Enabled = false;
                instance.SetParamPersonnages(chkRace.Checked, chkClasse.Checked, chkCompetence.Checked, chkStatistiques.Checked);
                Alert("Le jeu a été mis à jour", NotificationForm.TypeNotification.Success);   
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

        private void btnFermer_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
