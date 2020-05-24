namespace RolistMakerAdmin.GUI.Views
{
    partial class LoadGameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dtgGames = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOuvrir = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnFermer = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnNouveau = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGames)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dtgGames);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.TabIndex = 0;
            // 
            // dtgGames
            // 
            this.dtgGames.ColumnHeadersHeight = 28;
            this.dtgGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgGames.Location = new System.Drawing.Point(0, 0);
            this.dtgGames.Name = "dtgGames";
            this.dtgGames.RowTemplate.Height = 24;
            this.dtgGames.Size = new System.Drawing.Size(800, 350);
            this.dtgGames.TabIndex = 0;
            this.dtgGames.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgGames_CellClick);
            this.dtgGames.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgGames_CellDoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnOuvrir, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnFermer, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNouveau, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 96);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnOuvrir
            // 
            this.btnOuvrir.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnOuvrir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOuvrir.Location = new System.Drawing.Point(269, 3);
            this.btnOuvrir.Name = "btnOuvrir";
            this.btnOuvrir.Size = new System.Drawing.Size(260, 90);
            this.btnOuvrir.TabIndex = 1;
            this.btnOuvrir.Values.Text = "Ouvrir";
            this.btnOuvrir.Click += new System.EventHandler(this.btnOuvrir_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFermer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFermer.Location = new System.Drawing.Point(535, 3);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(262, 90);
            this.btnFermer.TabIndex = 2;
            this.btnFermer.Values.Text = "Fermer";
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNouveau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNouveau.Location = new System.Drawing.Point(3, 3);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(260, 90);
            this.btnNouveau.TabIndex = 0;
            this.btnNouveau.Values.Text = "Nouveau";
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // LoadGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "LoadGameForm";
            this.Text = "LoadGameForm";
            this.Load += new System.EventHandler(this.LoadGameForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgGames)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dtgGames;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnOuvrir;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnFermer;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnNouveau;
    }
}