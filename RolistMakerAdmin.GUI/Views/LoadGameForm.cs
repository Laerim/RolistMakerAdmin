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
    public partial class LoadGameForm : Form
    {
        EncyclopedieController instance = new EncyclopedieController();

        public LoadGameForm()
        {
            InitializeComponent();
        }

        private void LoadGameForm_Load(object sender, EventArgs e)
        {
            dtgGames.DataSource = instance.GetAllGames();
        }
    }
}
