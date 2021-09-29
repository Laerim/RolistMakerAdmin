namespace RolistMakerAdmin.GUI.Views.IntermediateForms
{
    partial class ParamMusiqueForm
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
            this.splitContainerForm = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnParcourir = new System.Windows.Forms.Button();
            this.txtLien = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelButtonMusique = new System.Windows.Forms.TableLayoutPanel();
            this.btnNewMusique = new System.Windows.Forms.Button();
            this.btnDeleteMusique = new System.Windows.Forms.Button();
            this.btnSaveMusique = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lstMusique = new System.Windows.Forms.ListBox();
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnFermer = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerForm)).BeginInit();
            this.splitContainerForm.Panel1.SuspendLayout();
            this.splitContainerForm.Panel2.SuspendLayout();
            this.splitContainerForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelButtonMusique.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panelPlayer.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerForm
            // 
            this.splitContainerForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerForm.Location = new System.Drawing.Point(0, 0);
            this.splitContainerForm.Name = "splitContainerForm";
            this.splitContainerForm.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerForm.Panel1
            // 
            this.splitContainerForm.Panel1.Controls.Add(this.splitContainer1);
            this.splitContainerForm.Panel1.Controls.Add(this.btnPlaylist);
            // 
            // splitContainerForm.Panel2
            // 
            this.splitContainerForm.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainerForm.Size = new System.Drawing.Size(590, 398);
            this.splitContainerForm.SplitterDistance = 315;
            this.splitContainerForm.TabIndex = 0;
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
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(503, 315);
            this.splitContainer1.SplitterDistance = 165;
            this.splitContainer1.TabIndex = 3;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.tableLayoutPanelButtonMusique);
            this.splitContainer3.Size = new System.Drawing.Size(503, 165);
            this.splitContainer3.SplitterDistance = 115;
            this.splitContainer3.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.Controls.Add(this.txtTitre, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnParcourir, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtLien, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(503, 115);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txtTitre
            // 
            this.txtTitre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.txtTitre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitre.ForeColor = System.Drawing.Color.White;
            this.txtTitre.Location = new System.Drawing.Point(121, 19);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(332, 19);
            this.txtTitre.TabIndex = 4;
            this.txtTitre.Text = "Ma musique";
            this.txtTitre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTitre.Enter += new System.EventHandler(this.txtTitre_Enter);
            this.txtTitre.Leave += new System.EventHandler(this.txtTitre_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titre de la musique :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fichier :";
            // 
            // btnParcourir
            // 
            this.btnParcourir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnParcourir.BackColor = System.Drawing.Color.White;
            this.btnParcourir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParcourir.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParcourir.ForeColor = System.Drawing.Color.Black;
            this.btnParcourir.Location = new System.Drawing.Point(463, 72);
            this.btnParcourir.Name = "btnParcourir";
            this.btnParcourir.Size = new System.Drawing.Size(32, 28);
            this.btnParcourir.TabIndex = 6;
            this.btnParcourir.Text = "...";
            this.btnParcourir.UseVisualStyleBackColor = false;
            this.btnParcourir.Click += new System.EventHandler(this.btnParcourir_Click);
            // 
            // txtLien
            // 
            this.txtLien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLien.BackColor = System.Drawing.SystemColors.Info;
            this.txtLien.Location = new System.Drawing.Point(121, 73);
            this.txtLien.Name = "txtLien";
            this.txtLien.ReadOnly = true;
            this.txtLien.Size = new System.Drawing.Size(332, 26);
            this.txtLien.TabIndex = 5;
            // 
            // tableLayoutPanelButtonMusique
            // 
            this.tableLayoutPanelButtonMusique.ColumnCount = 3;
            this.tableLayoutPanelButtonMusique.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelButtonMusique.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelButtonMusique.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelButtonMusique.Controls.Add(this.btnNewMusique, 0, 0);
            this.tableLayoutPanelButtonMusique.Controls.Add(this.btnDeleteMusique, 2, 0);
            this.tableLayoutPanelButtonMusique.Controls.Add(this.btnSaveMusique, 1, 0);
            this.tableLayoutPanelButtonMusique.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelButtonMusique.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelButtonMusique.Name = "tableLayoutPanelButtonMusique";
            this.tableLayoutPanelButtonMusique.RowCount = 1;
            this.tableLayoutPanelButtonMusique.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtonMusique.Size = new System.Drawing.Size(503, 46);
            this.tableLayoutPanelButtonMusique.TabIndex = 2;
            // 
            // btnNewMusique
            // 
            this.btnNewMusique.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(222)))));
            this.btnNewMusique.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNewMusique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewMusique.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnNewMusique.Location = new System.Drawing.Point(3, 3);
            this.btnNewMusique.Name = "btnNewMusique";
            this.btnNewMusique.Size = new System.Drawing.Size(161, 40);
            this.btnNewMusique.TabIndex = 4;
            this.btnNewMusique.Text = "Nouveau";
            this.btnNewMusique.UseVisualStyleBackColor = false;
            this.btnNewMusique.Click += new System.EventHandler(this.btnNewMusique_Click);
            // 
            // btnDeleteMusique
            // 
            this.btnDeleteMusique.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnDeleteMusique.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteMusique.ForeColor = System.Drawing.Color.White;
            this.btnDeleteMusique.Location = new System.Drawing.Point(337, 3);
            this.btnDeleteMusique.Name = "btnDeleteMusique";
            this.btnDeleteMusique.Size = new System.Drawing.Size(163, 40);
            this.btnDeleteMusique.TabIndex = 3;
            this.btnDeleteMusique.Text = "Supprimer";
            this.btnDeleteMusique.UseVisualStyleBackColor = false;
            this.btnDeleteMusique.Click += new System.EventHandler(this.btnDeleteMusique_Click);
            // 
            // btnSaveMusique
            // 
            this.btnSaveMusique.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(222)))));
            this.btnSaveMusique.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveMusique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveMusique.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnSaveMusique.Location = new System.Drawing.Point(170, 3);
            this.btnSaveMusique.Name = "btnSaveMusique";
            this.btnSaveMusique.Size = new System.Drawing.Size(161, 40);
            this.btnSaveMusique.TabIndex = 2;
            this.btnSaveMusique.Text = "Enregistrer";
            this.btnSaveMusique.UseVisualStyleBackColor = false;
            this.btnSaveMusique.Click += new System.EventHandler(this.btnSaveMusique_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lstMusique);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panelPlayer);
            this.splitContainer2.Size = new System.Drawing.Size(503, 146);
            this.splitContainer2.SplitterDistance = 260;
            this.splitContainer2.TabIndex = 0;
            // 
            // lstMusique
            // 
            this.lstMusique.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMusique.FormattingEnabled = true;
            this.lstMusique.ItemHeight = 19;
            this.lstMusique.Location = new System.Drawing.Point(0, 0);
            this.lstMusique.Name = "lstMusique";
            this.lstMusique.Size = new System.Drawing.Size(260, 146);
            this.lstMusique.TabIndex = 0;
            this.lstMusique.SelectedIndexChanged += new System.EventHandler(this.lstMusique_SelectedIndexChanged);
            // 
            // panelPlayer
            // 
            this.panelPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelPlayer.Controls.Add(this.btnPause);
            this.panelPlayer.Controls.Add(this.btnPlay);
            this.panelPlayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPlayer.Location = new System.Drawing.Point(0, 116);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(239, 30);
            this.panelPlayer.TabIndex = 0;
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnPlaylist.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPlaylist.FlatAppearance.BorderSize = 0;
            this.btnPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaylist.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaylist.ForeColor = System.Drawing.Color.LightGray;
            this.btnPlaylist.Location = new System.Drawing.Point(503, 0);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Size = new System.Drawing.Size(87, 315);
            this.btnPlaylist.TabIndex = 2;
            this.btnPlaylist.Text = "Accéder aux playlists\r\n►";
            this.btnPlaylist.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnFermer, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(590, 79);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // btnFermer
            // 
            this.btnFermer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFermer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnFermer.ForeColor = System.Drawing.Color.White;
            this.btnFermer.Location = new System.Drawing.Point(210, 14);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(170, 50);
            this.btnFermer.TabIndex = 2;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // btnPause
            // 
            this.btnPause.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Image = global::RolistMakerAdmin.GUI.Properties.Resources.pause;
            this.btnPause.Location = new System.Drawing.Point(40, 0);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(40, 30);
            this.btnPause.TabIndex = 1;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Image = global::RolistMakerAdmin.GUI.Properties.Resources.play;
            this.btnPlay.Location = new System.Drawing.Point(0, 0);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(40, 30);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // ParamMusiqueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(590, 398);
            this.Controls.Add(this.splitContainerForm);
            this.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ParamMusiqueForm";
            this.Text = "Param Musique";
            this.Load += new System.EventHandler(this.ParamMusiqueForm_Load);
            this.splitContainerForm.Panel1.ResumeLayout(false);
            this.splitContainerForm.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerForm)).EndInit();
            this.splitContainerForm.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanelButtonMusique.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panelPlayer.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerForm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnPlaylist;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox lstMusique;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnParcourir;
        private System.Windows.Forms.TextBox txtLien;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtonMusique;
        private System.Windows.Forms.Button btnNewMusique;
        private System.Windows.Forms.Button btnDeleteMusique;
        private System.Windows.Forms.Button btnSaveMusique;
        private System.Windows.Forms.Panel panelPlayer;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}