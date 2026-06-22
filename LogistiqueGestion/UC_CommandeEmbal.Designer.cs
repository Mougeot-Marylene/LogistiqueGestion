namespace LogistiqueGestion
{
    partial class UC_CommandeEmbal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_CommandeEmbal));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tlp_ConteneurPrincipal = new TableLayoutPanel();
            tlp_card = new TableLayoutPanel();
            tbl_conteneur = new TableLayoutPanel();
            panel_image = new Panel();
            pictureBox1 = new PictureBox();
            tbl_Commande = new TableLayoutPanel();
            lblCommande = new Label();
            lbl_NummComm = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            lbl_nomClient = new Label();
            dateTimePicker1 = new DateTimePicker();
            tableLayoutPanel3 = new TableLayoutPanel();
            tlp_info = new TableLayoutPanel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            imgProd = new DataGridViewImageColumn();
            numCommande = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Quantite = new DataGridViewTextBoxColumn();
            emballer = new DataGridViewCheckBoxColumn();
            tlp_ConteneurPrincipal.SuspendLayout();
            tlp_card.SuspendLayout();
            tbl_conteneur.SuspendLayout();
            panel_image.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tbl_Commande.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tlp_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel4.SuspendLayout();
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
            tlp_ConteneurPrincipal.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tlp_ConteneurPrincipal.Location = new Point(0, 0);
            tlp_ConteneurPrincipal.Name = "tlp_ConteneurPrincipal";
            tlp_ConteneurPrincipal.RowCount = 2;
            tlp_ConteneurPrincipal.RowStyles.Add(new RowStyle());
            tlp_ConteneurPrincipal.RowStyles.Add(new RowStyle());
            tlp_ConteneurPrincipal.Size = new Size(884, 393);
            tlp_ConteneurPrincipal.TabIndex = 10;
            tlp_ConteneurPrincipal.Paint += tlp_ConteneurPrincipal_Paint;
            // 
            // tlp_card
            // 
            tlp_card.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlp_card.ColumnCount = 1;
            tlp_card.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp_card.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlp_card.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlp_card.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlp_card.Controls.Add(tbl_conteneur, 0, 0);
            tlp_card.Location = new Point(3, 3);
            tlp_card.Name = "tlp_card";
            tlp_card.RowCount = 1;
            tlp_card.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_card.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            tlp_card.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlp_card.Size = new Size(878, 149);
            tlp_card.TabIndex = 5;
            // 
            // tbl_conteneur
            // 
            tbl_conteneur.ColumnCount = 2;
            tbl_conteneur.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.38461542F));
            tbl_conteneur.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 94.61539F));
            tbl_conteneur.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tbl_conteneur.Controls.Add(panel_image, 0, 0);
            tbl_conteneur.Controls.Add(tbl_Commande, 1, 0);
            tbl_conteneur.Controls.Add(tableLayoutPanel1, 1, 1);
            tbl_conteneur.Location = new Point(3, 3);
            tbl_conteneur.Name = "tbl_conteneur";
            tbl_conteneur.RowCount = 2;
            tbl_conteneur.RowStyles.Add(new RowStyle(SizeType.Percent, 38.46154F));
            tbl_conteneur.RowStyles.Add(new RowStyle(SizeType.Percent, 61.53846F));
            tbl_conteneur.Size = new Size(872, 106);
            tbl_conteneur.TabIndex = 4;
            // 
            // panel_image
            // 
            panel_image.Controls.Add(pictureBox1);
            panel_image.Location = new Point(3, 3);
            panel_image.Name = "panel_image";
            tbl_conteneur.SetRowSpan(panel_image, 2);
            panel_image.Size = new Size(40, 100);
            panel_image.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tbl_Commande
            // 
            tbl_Commande.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tbl_Commande.ColumnCount = 2;
            tbl_Commande.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.7654324F));
            tbl_Commande.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.2345657F));
            tbl_Commande.Controls.Add(lblCommande, 0, 0);
            tbl_Commande.Controls.Add(lbl_NummComm, 1, 0);
            tbl_Commande.Location = new Point(49, 3);
            tbl_Commande.Name = "tbl_Commande";
            tbl_Commande.RowCount = 1;
            tbl_Commande.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbl_Commande.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tbl_Commande.Size = new Size(324, 34);
            tbl_Commande.TabIndex = 1;
            // 
            // lblCommande
            // 
            lblCommande.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblCommande.AutoSize = true;
            lblCommande.Location = new Point(3, 19);
            lblCommande.Name = "lblCommande";
            lblCommande.Size = new Size(70, 15);
            lblCommande.TabIndex = 0;
            lblCommande.Text = "Commande ";
            // 
            // lbl_NummComm
            // 
            lbl_NummComm.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_NummComm.AutoSize = true;
            lbl_NummComm.Location = new Point(80, 19);
            lbl_NummComm.Name = "lbl_NummComm";
            lbl_NummComm.Size = new Size(38, 15);
            lbl_NummComm.TabIndex = 1;
            lbl_NummComm.Text = "#0001";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 182F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(dateTimePicker1, 1, 0);
            tableLayoutPanel1.Location = new Point(49, 43);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(311, 60);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.1025639F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.89744F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(label1, 1, 0);
            tableLayoutPanel2.Controls.Add(lbl_nomClient, 1, 1);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(123, 54);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            tableLayoutPanel2.SetRowSpan(panel1, 2);
            panel1.Size = new Size(23, 48);
            panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(23, 48);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(32, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "Client";
            // 
            // lbl_nomClient
            // 
            lbl_nomClient.AutoSize = true;
            lbl_nomClient.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nomClient.Location = new Point(32, 27);
            lbl_nomClient.Name = "lbl_nomClient";
            lbl_nomClient.Size = new Size(48, 15);
            lbl_nomClient.TabIndex = 2;
            lbl_nomClient.Text = "Client A";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(132, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(176, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(tlp_info, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel3.Location = new Point(3, 158);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(878, 233);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // tlp_info
            // 
            tlp_info.ColumnCount = 2;
            tlp_info.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.49450541F));
            tlp_info.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 94.50549F));
            tlp_info.Controls.Add(pictureBox2, 0, 0);
            tlp_info.Controls.Add(label2, 1, 0);
            tlp_info.Location = new Point(3, 3);
            tlp_info.Name = "tlp_info";
            tlp_info.RowCount = 1;
            tlp_info.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_info.Size = new Size(872, 48);
            tlp_info.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(1, 73, 239);
            label2.Location = new Point(50, 16);
            label2.Name = "label2";
            label2.Size = new Size(288, 15);
            label2.TabIndex = 1;
            label2.Text = "Cochez chaque produit une fois l'emballage effectué.";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(dataGridView1, 0, 0);
            tableLayoutPanel4.Location = new Point(3, 57);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(872, 173);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { imgProd, numCommande, Date, Quantite, emballer });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(866, 167);
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
            // Quantite
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Quantite.DefaultCellStyle = dataGridViewCellStyle2;
            Quantite.HeaderText = "Quantité";
            Quantite.Name = "Quantite";
            // 
            // emballer
            // 
            emballer.HeaderText = "Emballé";
            emballer.Name = "emballer";
            emballer.Resizable = DataGridViewTriState.True;
            emballer.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // UC_CommandeEmbal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlp_ConteneurPrincipal);
            Name = "UC_CommandeEmbal";
            Size = new Size(884, 393);
            tlp_ConteneurPrincipal.ResumeLayout(false);
            tlp_card.ResumeLayout(false);
            tbl_conteneur.ResumeLayout(false);
            panel_image.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tbl_Commande.ResumeLayout(false);
            tbl_Commande.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tlp_info.ResumeLayout(false);
            tlp_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlp_ConteneurPrincipal;
        private TableLayoutPanel tlp_card;
        private TableLayoutPanel tbl_conteneur;
        private Panel panel_image;
        private PictureBox pictureBox1;
        private TableLayoutPanel tbl_Commande;
        private Label lblCommande;
        private Label lbl_NummComm;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private PictureBox pictureBox3;
        private Label label1;
        private Label lbl_nomClient;
        private DateTimePicker dateTimePicker1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tlp_info;
        private PictureBox pictureBox2;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel4;
        private DataGridView dataGridView1;
        private DataGridViewImageColumn imgProd;
        private DataGridViewTextBoxColumn numCommande;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Quantite;
        private DataGridViewCheckBoxColumn emballer;
    }
}
