namespace LogistiqueGestion
{
    partial class UC_TableauDeBord
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_TableauDeBord));
            tableLayoutPanel3 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            numCommande = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            nbProduits = new DataGridViewTextBoxColumn();
            Prix = new DataGridViewTextBoxColumn();
            voir = new DataGridViewLinkColumn();
            panle_card2 = new Panel();
            pictureBox4 = new PictureBox();
            lbl_comm_env = new Label();
            lbl_nb_comm_env = new Label();
            panle_card1 = new Panel();
            pictureBox3 = new PictureBox();
            lbl_comm_atte = new Label();
            lbl_nb_comm = new Label();
            panle_card3 = new Panel();
            pictureBox5 = new PictureBox();
            lbl_comm_fina = new Label();
            lbl_nb_comm_fina = new Label();
            panle_card4 = new Panel();
            pictureBox6 = new PictureBox();
            lbl_tot_prd = new Label();
            lbl_nb_tot_prd = new Label();
            tlp_card = new TableLayoutPanel();
            tlp_ConteneurPrincipal = new TableLayoutPanel();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panle_card2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panle_card1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panle_card3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panle_card4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            tlp_card.SuspendLayout();
            tlp_ConteneurPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(dataGridView1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 123);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(899, 394);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { numCommande, Date, nbProduits, Prix, voir });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(893, 388);
            dataGridView1.TabIndex = 0;
            dataGridView1.TabStop = false;
            // 
            // numCommande
            // 
            numCommande.HeaderText = "N° commande";
            numCommande.Name = "numCommande";
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.Name = "Date";
            // 
            // nbProduits
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            nbProduits.DefaultCellStyle = dataGridViewCellStyle2;
            nbProduits.HeaderText = "Nombre de produits";
            nbProduits.Name = "nbProduits";
            // 
            // Prix
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Prix.DefaultCellStyle = dataGridViewCellStyle3;
            Prix.HeaderText = "Prix";
            Prix.Name = "Prix";
            // 
            // voir
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            voir.DefaultCellStyle = dataGridViewCellStyle4;
            voir.HeaderText = "";
            voir.Name = "voir";
            voir.Resizable = DataGridViewTriState.True;
            voir.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // panle_card2
            // 
            panle_card2.Anchor = AnchorStyles.Top;
            panle_card2.BackColor = Color.WhiteSmoke;
            panle_card2.Controls.Add(pictureBox4);
            panle_card2.Controls.Add(lbl_comm_env);
            panle_card2.Controls.Add(lbl_nb_comm_env);
            panle_card2.Location = new Point(260, 3);
            panle_card2.MaximumSize = new Size(151, 108);
            panle_card2.MinimumSize = new Size(151, 108);
            panle_card2.Name = "panle_card2";
            panle_card2.Size = new Size(151, 108);
            panle_card2.TabIndex = 3;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(36, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // lbl_comm_env
            // 
            lbl_comm_env.Location = new Point(37, 12);
            lbl_comm_env.Name = "lbl_comm_env";
            lbl_comm_env.Size = new Size(108, 30);
            lbl_comm_env.TabIndex = 1;
            lbl_comm_env.Text = "Commandes en envoie";
            lbl_comm_env.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_nb_comm_env
            // 
            lbl_nb_comm_env.AutoSize = true;
            lbl_nb_comm_env.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nb_comm_env.ForeColor = Color.FromArgb(80, 173, 242);
            lbl_nb_comm_env.Location = new Point(68, 61);
            lbl_nb_comm_env.Name = "lbl_nb_comm_env";
            lbl_nb_comm_env.Size = new Size(45, 20);
            lbl_nb_comm_env.TabIndex = 2;
            lbl_nb_comm_env.Text = "1000";
            // 
            // panle_card1
            // 
            panle_card1.BackColor = Color.WhiteSmoke;
            panle_card1.Controls.Add(pictureBox3);
            panle_card1.Controls.Add(lbl_comm_atte);
            panle_card1.Controls.Add(lbl_nb_comm);
            panle_card1.Dock = DockStyle.Fill;
            panle_card1.Location = new Point(3, 3);
            panle_card1.MaximumSize = new Size(151, 108);
            panle_card1.MinimumSize = new Size(151, 108);
            panle_card1.Name = "panle_card1";
            panle_card1.Size = new Size(151, 108);
            panle_card1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Margin = new Padding(5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // lbl_comm_atte
            // 
            lbl_comm_atte.Location = new Point(37, 12);
            lbl_comm_atte.Name = "lbl_comm_atte";
            lbl_comm_atte.Size = new Size(108, 30);
            lbl_comm_atte.TabIndex = 1;
            lbl_comm_atte.Text = "Commandes en attente";
            lbl_comm_atte.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_nb_comm
            // 
            lbl_nb_comm.AutoSize = true;
            lbl_nb_comm.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nb_comm.ForeColor = Color.FromArgb(80, 173, 242);
            lbl_nb_comm.Location = new Point(68, 61);
            lbl_nb_comm.Name = "lbl_nb_comm";
            lbl_nb_comm.Size = new Size(36, 20);
            lbl_nb_comm.TabIndex = 2;
            lbl_nb_comm.Text = "128";
            // 
            // panle_card3
            // 
            panle_card3.Anchor = AnchorStyles.Top;
            panle_card3.BackColor = Color.WhiteSmoke;
            panle_card3.Controls.Add(pictureBox5);
            panle_card3.Controls.Add(lbl_comm_fina);
            panle_card3.Controls.Add(lbl_nb_comm_fina);
            panle_card3.Location = new Point(484, 3);
            panle_card3.MaximumSize = new Size(151, 108);
            panle_card3.MinimumSize = new Size(151, 108);
            panle_card3.Name = "panle_card3";
            panle_card3.Size = new Size(151, 108);
            panle_card3.TabIndex = 4;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(3, 3);
            pictureBox5.Margin = new Padding(5);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(36, 40);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // lbl_comm_fina
            // 
            lbl_comm_fina.Location = new Point(37, 12);
            lbl_comm_fina.Name = "lbl_comm_fina";
            lbl_comm_fina.Size = new Size(108, 30);
            lbl_comm_fina.TabIndex = 1;
            lbl_comm_fina.Text = "Commandes finalisées";
            lbl_comm_fina.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_nb_comm_fina
            // 
            lbl_nb_comm_fina.AutoSize = true;
            lbl_nb_comm_fina.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nb_comm_fina.ForeColor = Color.FromArgb(80, 173, 242);
            lbl_nb_comm_fina.Location = new Point(68, 61);
            lbl_nb_comm_fina.Name = "lbl_nb_comm_fina";
            lbl_nb_comm_fina.Size = new Size(45, 20);
            lbl_nb_comm_fina.TabIndex = 2;
            lbl_nb_comm_fina.Text = "3500";
            // 
            // panle_card4
            // 
            panle_card4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panle_card4.BackColor = Color.WhiteSmoke;
            panle_card4.Controls.Add(pictureBox6);
            panle_card4.Controls.Add(lbl_tot_prd);
            panle_card4.Controls.Add(lbl_nb_tot_prd);
            panle_card4.Location = new Point(745, 3);
            panle_card4.MaximumSize = new Size(151, 108);
            panle_card4.MinimumSize = new Size(151, 108);
            panle_card4.Name = "panle_card4";
            panle_card4.Size = new Size(151, 108);
            panle_card4.TabIndex = 5;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(3, 3);
            pictureBox6.Margin = new Padding(5);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(36, 40);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            // 
            // lbl_tot_prd
            // 
            lbl_tot_prd.Location = new Point(37, 12);
            lbl_tot_prd.Name = "lbl_tot_prd";
            lbl_tot_prd.Size = new Size(108, 30);
            lbl_tot_prd.TabIndex = 1;
            lbl_tot_prd.Text = "Total produits";
            lbl_tot_prd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_nb_tot_prd
            // 
            lbl_nb_tot_prd.AutoSize = true;
            lbl_nb_tot_prd.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nb_tot_prd.ForeColor = Color.FromArgb(80, 173, 242);
            lbl_nb_tot_prd.Location = new Point(68, 61);
            lbl_nb_tot_prd.Name = "lbl_nb_tot_prd";
            lbl_nb_tot_prd.Size = new Size(45, 20);
            lbl_nb_tot_prd.TabIndex = 2;
            lbl_nb_tot_prd.Text = "4628";
            // 
            // tlp_card
            // 
            tlp_card.ColumnCount = 4;
            tlp_card.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlp_card.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlp_card.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlp_card.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlp_card.Controls.Add(panle_card4, 3, 0);
            tlp_card.Controls.Add(panle_card3, 2, 0);
            tlp_card.Controls.Add(panle_card1, 0, 0);
            tlp_card.Controls.Add(panle_card2, 1, 0);
            tlp_card.Dock = DockStyle.Fill;
            tlp_card.Location = new Point(3, 3);
            tlp_card.Name = "tlp_card";
            tlp_card.RowCount = 2;
            tlp_card.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_card.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlp_card.Size = new Size(899, 114);
            tlp_card.TabIndex = 5;
            // 
            // tlp_ConteneurPrincipal
            // 
            tlp_ConteneurPrincipal.ColumnCount = 1;
            tlp_ConteneurPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp_ConteneurPrincipal.Controls.Add(tlp_card, 0, 0);
            tlp_ConteneurPrincipal.Controls.Add(tableLayoutPanel3, 0, 1);
            tlp_ConteneurPrincipal.Dock = DockStyle.Fill;
            tlp_ConteneurPrincipal.Location = new Point(0, 0);
            tlp_ConteneurPrincipal.Name = "tlp_ConteneurPrincipal";
            tlp_ConteneurPrincipal.RowCount = 2;
            tlp_ConteneurPrincipal.RowStyles.Add(new RowStyle());
            tlp_ConteneurPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_ConteneurPrincipal.Size = new Size(905, 520);
            tlp_ConteneurPrincipal.TabIndex = 7;
            tlp_ConteneurPrincipal.Paint += tlp_ConteneurPrincipal_Paint;
            // 
            // UC_TableauDeBord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlp_ConteneurPrincipal);
            Name = "UC_TableauDeBord";
            Size = new Size(905, 520);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panle_card2.ResumeLayout(false);
            panle_card2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panle_card1.ResumeLayout(false);
            panle_card1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panle_card3.ResumeLayout(false);
            panle_card3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panle_card4.ResumeLayout(false);
            panle_card4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            tlp_card.ResumeLayout(false);
            tlp_ConteneurPrincipal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView dataGridView1;
        private Panel panle_card2;
        private PictureBox pictureBox4;
        private Label lbl_comm_env;
        private Label lbl_nb_comm_env;
        private Panel panle_card1;
        private PictureBox pictureBox3;
        private Label lbl_comm_atte;
        private Label lbl_nb_comm;
        private Panel panle_card3;
        private PictureBox pictureBox5;
        private Label lbl_comm_fina;
        private Label lbl_nb_comm_fina;
        private Panel panle_card4;
        private PictureBox pictureBox6;
        private Label lbl_tot_prd;
        private Label lbl_nb_tot_prd;
        private TableLayoutPanel tlp_card;
        private TableLayoutPanel tlp_ConteneurPrincipal;
        private DataGridViewTextBoxColumn numCommande;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn nbProduits;
        private DataGridViewTextBoxColumn Prix;
        private DataGridViewLinkColumn voir;
    }
}
