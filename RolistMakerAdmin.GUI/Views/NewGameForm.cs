using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RolistMakerAdmin.GUI.Controllers;


namespace RolistMakerAdmin.GUI
{
    public partial class NewGameForm : MaterialForm //Form
    {
        #region ATTRIBUTS
        EncyclopedieController instance = EncyclopedieController.GetInstance;

        private DataTable dtRaces;
        private DataTable dtClasses;
       // private DataTable dtCompetences;
        //private DataTable dtStatistiques;
        private DataTable dtSexes;

        private string sIdRace = string.Empty;
        private string sIdClasse = string.Empty;
        private string sIdCompetence = string.Empty;
        private string sIdStatistique = string.Empty;
        private string sIdSexe = string.Empty;

        #endregion

        #region FONCTIONS

        private void loadForm()
        {
            try
            {
                dtRaces = new DataTable();
                dtRaces.Columns.Add("ID", typeof(string));
                dtRaces.Columns.Add("Nom", typeof(string));
                dtRaces.Columns.Add("Description", typeof(string));
                dtgRaces.DataSource = dtRaces;
                dtgRaces.Columns["Description"].Visible = false;
                dtgRaces.Columns["ID"].Visible = false;

                dtClasses = new DataTable();
                dtClasses.Columns.Add("ID", typeof(string));
                dtClasses.Columns.Add("Nom", typeof(string));
                dtClasses.Columns.Add("Description", typeof(string));
                dtgClasses.DataSource = dtRaces;
                dtgClasses.Columns["Description"].Visible = false;
                dtgClasses.Columns["ID"].Visible = false;

                dtSexes = new DataTable();
                dtSexes.Columns.Add("ID", typeof(string));
                dtSexes.Columns.Add("Nom", typeof(string));
                dtSexes.Rows.Add(Guid.NewGuid().ToString(), "Homme");
                dtSexes.Rows.Add(Guid.NewGuid().ToString(), "Femme");
                dtSexes.Rows.Add(Guid.NewGuid().ToString(), "Non binaire");
                dtSexes.Rows.Add(Guid.NewGuid().ToString(), "Autre");

                dtgSexes.DataSource = dtSexes;
                dtgSexes.Columns["ID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite sur la fonction <loadForm>:\n" + ex.Message, ".:: Rolist Maker Admin ::.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }
        private void ChangeTabPersonnageNext()
        {
            try
            {
                switch (materialTabControl2.SelectedTab.Name)
                {
                    case "tabPagePersonnages": 
                        if (chkRace.Checked == true)
                        {
                            materialTabControl2.SelectedTab = tabPageRace;
                            break;
                        }
                        if (chkClasse.Checked == true)
                        {
                            materialTabControl2.SelectedTab = tabPageClasse;

                            break;
                        }
                        if (chkStatistiques.Checked == true)
                        {
                            materialTabControl2.SelectedTab = tabPageStatistiques;

                            break;
                        }
                        if (chkCompetences.Checked == true)
                        {
                            materialTabControl2.SelectedTab = tabPageCompetences;

                            break;
                        }
                        materialTabControl2.SelectedTab = tabPageAutres;
                        break;

                    case "tabPageRace":
                        if (chkClasse.Checked == true)
                        {
                            materialTabControl2.SelectedTab = tabPageClasse;

                            break;
                        }
                        if (chkStatistiques.Checked == true)
                        {
                            materialTabControl2.SelectedTab = tabPageStatistiques;

                            break;
                        }
                        if (chkCompetences.Checked == true)
                        {
                            materialTabControl2.SelectedTab = tabPageCompetences;

                            break;
                        }
                        materialTabControl2.SelectedTab = tabPageAutres;
                        break;

                    case "tabPageClasse":
                        if (chkStatistiques.Checked == true)
                        {
                            materialTabControl2.SelectedTab = tabPageStatistiques;

                            break;
                        }
                        if (chkCompetences.Checked == true)
                        {
                            materialTabControl2.SelectedTab = tabPageCompetences;

                            break;
                        }
                        materialTabControl2.SelectedTab = tabPageAutres;
                        break;

                    case "tabPageStatistiques":
                        if (chkCompetences.Checked == true)
                        {
                            materialTabControl2.SelectedTab = tabPageCompetences;

                            break;
                        }
                        materialTabControl2.SelectedTab = tabPageAutres;

                        break;
                    case "tabPageAutres":
                        materialTabControl1.SelectedTab = tabPage3;

                        break;
                      



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ".:: RolistMakerADMIN ::.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
        }
        private void ChangeTabPersonnagePrevious()
        {
            try
            {
                switch (materialTabControl2.SelectedTab.Name)
                {
                    case "tabPagePersonnages":
                        materialTabControl1.SelectedTab = tabPage1;
                        break;

                    case "tabPageRace":
                        materialTabControl2.SelectedTab = tabPagePersonnages;
                        break;

                    case "tabPageClasse":
                        if (chkRace.Checked == true)
                        {
                            materialTabControl2.SelectedTab = tabPageRace;

                            break;
                        }
                        materialTabControl2.SelectedTab = tabPagePersonnages;
                        break;

                    case "tabPageStatistiques":
                        if (chkClasse.Checked == true)
                        {
                            materialTabControl2.SelectedTab = tabPageClasse;

                            break;
                        }
                        if (chkRace.Checked == true)
                        {
                            materialTabControl2.SelectedTab = tabPageRace;

                            break;
                        }
                        materialTabControl2.SelectedTab = tabPagePersonnages;
                        break;

                    case "tabPageCompetences":
                       
                        if (chkStatistiques.Checked == true)
                        {
                            materialTabControl2.SelectedTab = tabPageStatistiques;

                            break;
                        }
                        if (chkClasse.Checked == true)
                        {
                            materialTabControl2.SelectedTab = tabPageClasse;

                            break;
                        }
                        if (chkRace.Checked == true)
                        {
                            materialTabControl2.SelectedTab = tabPageRace;
                            break;
                        }
                        materialTabControl2.SelectedTab = tabPagePersonnages;
                        break;
                    case "tabPageAutres":

                        if (chkCompetences.Checked == true)
                        {
                            materialTabControl2.SelectedTab = tabPageCompetences;

                            break;
                        }

                        if (chkStatistiques.Checked == true)
                        {
                            materialTabControl2.SelectedTab = tabPageStatistiques;

                            break;
                        }

                        if (chkStatistiques.Checked == true)
                        {
                            materialTabControl2.SelectedTab = tabPageStatistiques;

                            break;
                        }
                        if (chkClasse.Checked == true)
                        {
                            materialTabControl2.SelectedTab = tabPageClasse;

                            break;
                        }
                        if (chkRace.Checked == true)
                        {
                            materialTabControl2.SelectedTab = tabPageRace;
                            break;
                        }
                        materialTabControl2.SelectedTab = tabPagePersonnages;

                        break;
                    default:

                        materialTabControl1.SelectedTab = tabPage1;
                        break;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ".:: RolistMakerADMIN ::.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }


        #endregion

        public NewGameForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void NewGameForm_Load(object sender, EventArgs e)
        {
            loadForm();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
            switch (materialTabControl1.SelectedTab.Name)
            {
                case "tabPage1":
                    materialTabControl1.SelectedTab = tabPage2;
                    btnPrevious.Enabled = true;
                    // instance.SaveNewGame(0, txtTitle.Text.Trim(), txtDescription.Text.Trim());

                    
                    using (var context = new RolistMakerContext())
                    {
                        var games = context.Games;
                        int i = games.Count();
                        context.Add(new Game { Titre = txtTitle.Text.Trim(), Description = txtDescription.Text.Trim() });
                        context.SaveChanges();
                    }

                    break;
                case "tabPage2":
                    ChangeTabPersonnageNext();
                    break;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            switch (materialTabControl1.SelectedTab.Name)
            {
                case "tabPage2":
                    ChangeTabPersonnagePrevious();
                    break;
                case "tabPage3":
                    materialTabControl1.SelectedTab = tabPage2;
                    break;
            }
        }

        #region RACE
        private void btnNewRace_Click(object sender, EventArgs e)
        {
            newRace();
        }

        private void btnSaveRace_Click(object sender, EventArgs e)
        {
            if(txtRaceName.Text.Trim() != string.Empty)
            {
                if (sIdRace == string.Empty)
                {
                    string sId = Guid.NewGuid().ToString();
                    if (txtRaceDescription.Text.Trim() == "Description")
                        txtRaceDescription.Text = string.Empty;
                    dtRaces.Rows.Add(sId, txtRaceName.Text.Trim(), txtRaceDescription.Text.Trim());
                }
                else
                {
                    DataRow row = dtRaces.Select("ID = '" + sIdRace+"'").First();
                    row["Nom"] = txtRaceName.Text.Trim();
                    row["Description"] = txtRaceDescription.Text.Trim();
                }
                newRace();
            }
        }

        private void btnDeleteRace_Click(object sender, EventArgs e)
        {
            try
            {
                if (sIdRace.Trim() != string.Empty)
                {
                    DataRow row = dtRaces.Select("ID = '" + sIdRace+"'").First();
                    row.Delete();
                    newRace();
                }
                else
                    MessageBox.Show("Sélectionnez une race à supprimer", ".:: Rolist Maker Admin ::.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite sur la fonction <btnDeleteRace_Click>:\n" + ex.Message, ".:: Rolist Maker Admin ::.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void txtRaceDescription_Enter(object sender, EventArgs e)
        {
            if (txtRaceDescription.Text.Trim() == "Description")
                txtRaceDescription.Text = string.Empty;
        }

        private void dtgRaces_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            DataGridViewRow myRow = dtgRaces.CurrentRow;
            if (myRow != null)
            {
                sIdRace = myRow.Cells["ID"].Value.ToString();
                txtRaceName.Text = myRow.Cells["Nom"].Value.ToString();
                txtRaceDescription.Text = myRow.Cells["Description"].Value.ToString();
                btnDeleteRace.Enabled = true;
            }
        }
        private void newRace()
        {
            txtRaceName.Text = string.Empty;
            txtRaceDescription.Text = "Description";
            sIdRace = string.Empty;
            btnDeleteRace.Enabled = false;
        }


        #endregion

        #region CLASSE
        

        private void btnNewClasse_Click(object sender, EventArgs e)
        {
            NewClasse();
        }

        private void btnSaveClasse_Click(object sender, EventArgs e)
        {
            if (txtClasseName.Text.Trim() != string.Empty)
            {
                if (sIdClasse == string.Empty)
                {
                    string sId = Guid.NewGuid().ToString();
                    if (txtClasseDescription.Text.Trim() == "Description")
                        txtClasseDescription.Text = string.Empty;
                    dtClasses.Rows.Add(sId, txtClasseName.Text.Trim(), txtClasseDescription.Text.Trim());
                }
                else
                {
                    DataRow row = dtClasses.Select("ID = '" + sIdClasse + "'").First();
                    row["Nom"] = txtClasseName.Text.Trim();
                    row["Description"] = txtClasseDescription.Text.Trim();
                }
                NewClasse();
            }
        }

        private void btnDeleteClasse_Click(object sender, EventArgs e)
        {
            try
            {
                if (sIdClasse.Trim() != string.Empty)
                {
                    DataRow row = dtClasses.Select("ID = '" + sIdClasse + "'").First();
                    row.Delete();
                    NewClasse();
                }
                else
                    MessageBox.Show("Sélectionnez une Classe à supprimer", ".:: Rolist Maker Admin ::.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite sur la fonction <btnDeleteClasse_Click>:\n" + ex.Message, ".:: Rolist Maker Admin ::.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void txtClasseDescription_Enter(object sender, EventArgs e)
        {
            if (txtClasseDescription.Text.Trim() == "Description")
                txtClasseDescription.Text = string.Empty;
        }

        private void dtgClasses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            DataGridViewRow myRow = dtgClasses.CurrentRow;
            if (myRow != null)
            {
                sIdClasse = myRow.Cells["ID"].Value.ToString();
                txtClasseName.Text = myRow.Cells["Nom"].Value.ToString();
                txtClasseDescription.Text = myRow.Cells["Description"].Value.ToString();
                btnDeleteClasse.Enabled = true;
            }
        }
        private void NewClasse()
        {
            txtClasseName.Text = string.Empty;
            txtClasseDescription.Text = "Description";
            sIdClasse = string.Empty;
            btnDeleteClasse.Enabled = false;
        }

        #endregion

        #region AUTRES

        #region SEXE

        private void btnNewSexe_Click(object sender, EventArgs e)
        {
            NewSexe();
        }

        private void btnSaveSexe_Click(object sender, EventArgs e)
        {
            if (txtSexeName.Text.Trim() != string.Empty)
            {
                if (sIdSexe == string.Empty)
                {
                    string sId = Guid.NewGuid().ToString();
                   
                    dtSexes.Rows.Add(sId, txtSexeName.Text.Trim());
                }
                else
                {
                    DataRow row = dtSexes.Select("ID = '" + sIdSexe + "'").First();
                    row["Nom"] = txtSexeName.Text.Trim();
                }
                NewSexe();
            }
        }

        private void btnDeleteSexe_Click(object sender, EventArgs e)
        {
            try
            {
                if (sIdSexe.Trim() != string.Empty)
                {
                    DataRow row = dtSexes.Select("ID = '" + sIdSexe + "'").First();
                    row.Delete();
                    NewSexe();
                }
                else
                    MessageBox.Show("Sélectionnez un sexe à supprimer", ".:: Rolist Maker Admin ::.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite sur la fonction <btnDeleteSexe_Click>:\n" + ex.Message, ".:: Rolist Maker Admin ::.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        

        private void dtgSexes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            DataGridViewRow myRow = dtgSexes.CurrentRow;
            if (myRow != null)
            {
                sIdSexe = myRow.Cells["ID"].Value.ToString();
                txtSexeName.Text = myRow.Cells["Nom"].Value.ToString();
                btnDeleteSexe.Enabled = true;
            }
        }
        private void NewSexe()
        {
            txtSexeName.Text = string.Empty;
            sIdSexe = string.Empty;
            btnDeleteSexe.Enabled = false;
        }


        #endregion

        #endregion
    }
}
