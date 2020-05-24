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


namespace RolistMakerAdmin.GUI.Views
{
    public partial class LoadGameForm : Form
    {
        EncyclopedieController instance = new EncyclopedieController();
        private int IDGame = 0;
        
        private void LoadForm()
        {
            dtgGames.DataSource = instance.GetAllGames();
        }

        public LoadGameForm()
        {
            InitializeComponent();
        }

        private void LoadGameForm_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void dtgGames_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminGame form = new AdminGame();

            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void btnOuvrir_Click(object sender, EventArgs e)
        {
            AdminGame form = new AdminGame();

            form.Show();
            LoadForm();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgGames_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            DataGridViewRow myRow = dtgGames.CurrentRow;
            if (myRow != null)
            {
                IDGame = int.Parse(myRow.Cells["GameId"].Value.ToString());
               
            }
        }
    }
}
