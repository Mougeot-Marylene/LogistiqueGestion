namespace LogistiqueGestion
{
    partial class UC_Stocks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Stocks));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tlp_ConteneurPrincipal = new TableLayoutPanel();
            tlp_card = new TableLayoutPanel();
            panle_card3 = new Panel();
            pictureBox5 = new PictureBox();
            lbl_comm_fina = new Label();
            lbl_nb_comm_fina = new Label();
            panle_card1 = new Panel();
            pictureBox3 = new PictureBox();
            lbl_comm_atte = new Label();
            lbl_nb_comm = new Label();
            panle_card2 = new Panel();
            pictureBox4 = new PictureBox();
            lbl_comm_env = new Label();
            lbl_nb_comm_env = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            imgProd = new DataGridViewImageColumn();
            StockProduit = new DataGridViewTextBoxColumn();
            numCommande = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            nbProduits = new DataGridViewTextBoxColumn();
            Augmenter = new DataGridViewButtonColumn();
            voir = new DataGridViewLinkColumn();
            tlp_ConteneurPrincipal.SuspendLayout();
            tlp_card.SuspendLayout();
            panle_card3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panle_card1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panle_card2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            tlp_ConteneurPrincipal.Size = new Size(956, 418);
            tlp_ConteneurPrincipal.TabIndex = 8;
            // 
            // tlp_card
            // 
            tlp_card.ColumnCount = 4;
            tlp_card.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlp_card.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlp_card.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlp_card.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlp_card.Controls.Add(panle_card3, 2, 0);
            tlp_card.Controls.Add(panle_card1, 0, 0);
            tlp_card.Controls.Add(panle_card2, 1, 0);
            tlp_card.Dock = DockStyle.Fill;
            tlp_card.Location = new Point(3, 3);
            tlp_card.Name = "tlp_card";
            tlp_card.RowCount = 2;
            tlp_card.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_card.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlp_card.Size = new Size(950, 114);
            tlp_card.TabIndex = 5;
            tlp_card.Paint += tlp_card_Paint;
            // 
            // panle_card3
            // 
            panle_card3.Anchor = AnchorStyles.Top;
            panle_card3.BackColor = Color.WhiteSmoke;
            panle_card3.Controls.Add(pictureBox5);
            panle_card3.Controls.Add(lbl_comm_fina);
            panle_card3.Controls.Add(lbl_nb_comm_fina);
            panle_card3.Location = new Point(517, 3);
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
            lbl_comm_fina.Text = "Rupture de stock";
            lbl_comm_fina.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_nb_comm_fina
            // 
            lbl_nb_comm_fina.AutoSize = true;
            lbl_nb_comm_fina.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nb_comm_fina.ForeColor = Color.FromArgb(80, 173, 242);
            lbl_nb_comm_fina.Location = new Point(68, 61);
            lbl_nb_comm_fina.Name = "lbl_nb_comm_fina";
            lbl_nb_comm_fina.Size = new Size(18, 20);
            lbl_nb_comm_fina.TabIndex = 2;
            lbl_nb_comm_fina.Text = "8";
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
            lbl_comm_atte.Text = "Total produits";
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
            lbl_nb_comm.Text = "352";
            // 
            // panle_card2
            // 
            panle_card2.Anchor = AnchorStyles.Top;
            panle_card2.BackColor = Color.WhiteSmoke;
            panle_card2.Controls.Add(pictureBox4);
            panle_card2.Controls.Add(lbl_comm_env);
            panle_card2.Controls.Add(lbl_nb_comm_env);
            panle_card2.Location = new Point(280, 3);
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
            lbl_comm_env.Text = "Stock faible";
            lbl_comm_env.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_nb_comm_env
            // 
            lbl_nb_comm_env.AutoSize = true;
            lbl_nb_comm_env.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nb_comm_env.ForeColor = Color.FromArgb(80, 173, 242);
            lbl_nb_comm_env.Location = new Point(68, 61);
            lbl_nb_comm_env.Name = "lbl_nb_comm_env";
            lbl_nb_comm_env.Size = new Size(27, 20);
            lbl_nb_comm_env.TabIndex = 2;
            lbl_nb_comm_env.Text = "25";
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
            tableLayoutPanel3.Size = new Size(950, 292);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { imgProd, StockProduit, numCommande, Date, nbProduits, Augmenter, voir });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(944, 286);
            dataGridView1.TabIndex = 0;
            // 
            // imgProd
            // 
            imgProd.HeaderText = "";
            imgProd.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imgProd.Name = "imgProd";
            imgProd.Resizable = DataGridViewTriState.True;
            imgProd.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // StockProduit
            // 
            StockProduit.HeaderText = "Sotcks disponible";
            StockProduit.Name = "StockProduit";
            // 
            // numCommande
            // 
            numCommande.HeaderText = "Produits";
            numCommande.Name = "numCommande";
            // 
            // Date
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Date.DefaultCellStyle = dataGridViewCellStyle1;
            Date.HeaderText = "Références";
            Date.Name = "Date";
            // 
            // nbProduits
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            nbProduits.DefaultCellStyle = dataGridViewCellStyle2;
            nbProduits.HeaderText = "Prix";
            nbProduits.Name = "nbProduits";
            // 
            // Augmenter
            // 
            Augmenter.HeaderText = "";
            Augmenter.Name = "Augmenter";
            Augmenter.Resizable = DataGridViewTriState.True;
            Augmenter.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // voir
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            voir.DefaultCellStyle = dataGridViewCellStyle3;
            voir.HeaderText = "";
            voir.Name = "voir";
            voir.Resizable = DataGridViewTriState.True;
            voir.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // UC_Stocks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlp_ConteneurPrincipal);
            Name = "UC_Stocks";
            Size = new Size(956, 418);
            tlp_ConteneurPrincipal.ResumeLayout(false);
            tlp_card.ResumeLayout(false);
            panle_card3.ResumeLayout(false);
            panle_card3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panle_card1.ResumeLayout(false);
            panle_card1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panle_card2.ResumeLayout(false);
            panle_card2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlp_ConteneurPrincipal;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView dataGridView1;
        private TableLayoutPanel tlp_card;
        private Panel panle_card3;
        private PictureBox pictureBox5;
        private Label lbl_comm_fina;
        private Label lbl_nb_comm_fina;
        private Panel panle_card1;
        private PictureBox pictureBox3;
        private Label lbl_comm_atte;
        private Label lbl_nb_comm;
        private Panel panle_card2;
        private PictureBox pictureBox4;
        private Label lbl_comm_env;
        private Label lbl_nb_comm_env;
        private DataGridViewImageColumn imgProd;
        private DataGridViewTextBoxColumn StockProduit;
        private DataGridViewTextBoxColumn numCommande;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn nbProduits;
        private DataGridViewButtonColumn Augmenter;
        private DataGridViewLinkColumn voir;
    }
}
