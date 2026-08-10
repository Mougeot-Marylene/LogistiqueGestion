namespace LogistiqueGestion
{
    partial class FormPrincipale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipale));
            tableLayoutPanel2 = new TableLayoutPanel();
            pnlContenu = new Panel();
            tblp_comm_att = new TableLayoutPanel();
            tlp_logo = new TableLayoutPanel();
            logo = new PictureBox();
            tblp_pers = new TableLayoutPanel();
            pers = new PictureBox();
            lbl_pers_conn = new Label();
            lbl_role = new Label();
            tblp_menu = new TableLayoutPanel();
            liklab_tab_bord = new LinkLabel();
            link_comm_attente = new LinkLabel();
            lbl_commandes = new Label();
            link_comm_envoie = new LinkLabel();
            link_comm_final = new LinkLabel();
            link_stock = new LinkLabel();
            link_embalage = new LinkLabel();
            tlp_header_haut = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox2 = new PictureBox();
            lbl_titre = new Label();
            tableLayoutPanel2.SuspendLayout();
            tblp_comm_att.SuspendLayout();
            tlp_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            tblp_pers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pers).BeginInit();
            tblp_menu.SuspendLayout();
            tlp_header_haut.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = SystemColors.Control;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 325F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(pnlContenu, 1, 1);
            tableLayoutPanel2.Controls.Add(tblp_comm_att, 0, 0);
            tableLayoutPanel2.Controls.Add(tlp_header_haut, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(6);
            tableLayoutPanel2.MinimumSize = new Size(1486, 960);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 171F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel2.Size = new Size(1486, 960);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // pnlContenu
            // 
            pnlContenu.Dock = DockStyle.Fill;
            pnlContenu.Location = new Point(331, 177);
            pnlContenu.Margin = new Padding(6);
            pnlContenu.Name = "pnlContenu";
            pnlContenu.Size = new Size(1149, 777);
            pnlContenu.TabIndex = 0;
            // 
            // tblp_comm_att
            // 
            tblp_comm_att.BackColor = Color.FromArgb(6, 25, 57);
            tblp_comm_att.ColumnCount = 1;
            tblp_comm_att.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblp_comm_att.Controls.Add(tlp_logo, 0, 0);
            tblp_comm_att.Controls.Add(tblp_pers, 0, 2);
            tblp_comm_att.Controls.Add(tblp_menu, 0, 1);
            tblp_comm_att.Dock = DockStyle.Fill;
            tblp_comm_att.Location = new Point(6, 6);
            tblp_comm_att.Margin = new Padding(6);
            tblp_comm_att.Name = "tblp_comm_att";
            tblp_comm_att.RowCount = 3;
            tableLayoutPanel2.SetRowSpan(tblp_comm_att, 2);
            tblp_comm_att.RowStyles.Add(new RowStyle());
            tblp_comm_att.RowStyles.Add(new RowStyle(SizeType.Percent, 63.5616455F));
            tblp_comm_att.RowStyles.Add(new RowStyle(SizeType.Percent, 36.4383545F));
            tblp_comm_att.Size = new Size(313, 948);
            tblp_comm_att.TabIndex = 2;
            // 
            // tlp_logo
            // 
            tlp_logo.ColumnCount = 1;
            tlp_logo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_logo.Controls.Add(logo, 0, 0);
            tlp_logo.Location = new Point(6, 6);
            tlp_logo.Margin = new Padding(6);
            tlp_logo.Name = "tlp_logo";
            tlp_logo.RowCount = 1;
            tlp_logo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_logo.Size = new Size(301, 156);
            tlp_logo.TabIndex = 0;
            // 
            // logo
            // 
            logo.Dock = DockStyle.Fill;
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(6, 6);
            logo.Margin = new Padding(6);
            logo.Name = "logo";
            logo.Size = new Size(289, 144);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // tblp_pers
            // 
            tblp_pers.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tblp_pers.ColumnCount = 2;
            tblp_pers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblp_pers.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 230F));
            tblp_pers.Controls.Add(pers, 0, 0);
            tblp_pers.Controls.Add(lbl_pers_conn, 1, 1);
            tblp_pers.Controls.Add(lbl_role, 1, 0);
            tblp_pers.Location = new Point(6, 852);
            tblp_pers.Margin = new Padding(6);
            tblp_pers.Name = "tblp_pers";
            tblp_pers.RowCount = 2;
            tblp_pers.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblp_pers.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tblp_pers.Size = new Size(301, 90);
            tblp_pers.TabIndex = 2;
            // 
            // pers
            // 
            pers.Image = (Image)resources.GetObject("pers.Image");
            pers.Location = new Point(6, 6);
            pers.Margin = new Padding(6);
            pers.Name = "pers";
            tblp_pers.SetRowSpan(pers, 2);
            pers.Size = new Size(59, 77);
            pers.SizeMode = PictureBoxSizeMode.Zoom;
            pers.TabIndex = 0;
            pers.TabStop = false;
            // 
            // lbl_pers_conn
            // 
            lbl_pers_conn.Anchor = AnchorStyles.Left;
            lbl_pers_conn.AutoSize = true;
            lbl_pers_conn.ForeColor = Color.White;
            lbl_pers_conn.Location = new Point(77, 52);
            lbl_pers_conn.Margin = new Padding(6, 0, 6, 0);
            lbl_pers_conn.Name = "lbl_pers_conn";
            lbl_pers_conn.Size = new Size(68, 32);
            lbl_pers_conn.TabIndex = 1;
            lbl_pers_conn.Text = "Mary";
            // 
            // lbl_role
            // 
            lbl_role.Anchor = AnchorStyles.Left;
            lbl_role.AutoSize = true;
            lbl_role.ForeColor = Color.White;
            lbl_role.Location = new Point(77, 7);
            lbl_role.Margin = new Padding(6, 0, 6, 0);
            lbl_role.Name = "lbl_role";
            lbl_role.Size = new Size(91, 32);
            lbl_role.TabIndex = 2;
            lbl_role.Text = "Pickeur";
            // 
            // tblp_menu
            // 
            tblp_menu.ColumnCount = 1;
            tblp_menu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblp_menu.Controls.Add(liklab_tab_bord, 0, 0);
            tblp_menu.Controls.Add(link_comm_attente, 0, 2);
            tblp_menu.Controls.Add(lbl_commandes, 0, 1);
            tblp_menu.Controls.Add(link_comm_envoie, 0, 3);
            tblp_menu.Controls.Add(link_comm_final, 0, 4);
            tblp_menu.Controls.Add(link_stock, 0, 5);
            tblp_menu.Controls.Add(link_embalage, 0, 6);
            tblp_menu.Location = new Point(6, 174);
            tblp_menu.Margin = new Padding(6);
            tblp_menu.Name = "tblp_menu";
            tblp_menu.RowCount = 7;
            tblp_menu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblp_menu.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tblp_menu.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tblp_menu.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tblp_menu.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tblp_menu.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tblp_menu.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tblp_menu.Size = new Size(301, 437);
            tblp_menu.TabIndex = 1;
            // 
            // liklab_tab_bord
            // 
            liklab_tab_bord.ActiveLinkColor = Color.FromArgb(27, 94, 164);
            liklab_tab_bord.Anchor = AnchorStyles.Left;
            liklab_tab_bord.AutoSize = true;
            liklab_tab_bord.LinkBehavior = LinkBehavior.NeverUnderline;
            liklab_tab_bord.LinkColor = Color.White;
            liklab_tab_bord.Location = new Point(6, 31);
            liklab_tab_bord.Margin = new Padding(6, 0, 6, 0);
            liklab_tab_bord.Name = "liklab_tab_bord";
            liklab_tab_bord.Size = new Size(186, 32);
            liklab_tab_bord.TabIndex = 0;
            liklab_tab_bord.TabStop = true;
            liklab_tab_bord.Text = "Tableau de bord";
            liklab_tab_bord.LinkClicked += liklab_tab_bord_LinkClicked;
            // 
            // link_comm_attente
            // 
            link_comm_attente.ActiveLinkColor = Color.FromArgb(27, 94, 164);
            link_comm_attente.Anchor = AnchorStyles.Left;
            link_comm_attente.AutoSize = true;
            link_comm_attente.Font = new Font("Segoe UI", 8F);
            link_comm_attente.LinkBehavior = LinkBehavior.NeverUnderline;
            link_comm_attente.LinkColor = Color.White;
            link_comm_attente.Location = new Point(24, 177);
            link_comm_attente.Margin = new Padding(24, 0, 6, 0);
            link_comm_attente.Name = "link_comm_attente";
            link_comm_attente.Size = new Size(248, 30);
            link_comm_attente.TabIndex = 4;
            link_comm_attente.TabStop = true;
            link_comm_attente.Text = "Commandes en attentes";
            link_comm_attente.LinkClicked += link_comm_attente_LinkClicked;
            // 
            // lbl_commandes
            // 
            lbl_commandes.Anchor = AnchorStyles.Left;
            lbl_commandes.AutoSize = true;
            lbl_commandes.ForeColor = Color.White;
            lbl_commandes.Location = new Point(6, 115);
            lbl_commandes.Margin = new Padding(6, 0, 6, 0);
            lbl_commandes.Name = "lbl_commandes";
            lbl_commandes.Size = new Size(148, 32);
            lbl_commandes.TabIndex = 2;
            lbl_commandes.Text = "Commandes";
            // 
            // link_comm_envoie
            // 
            link_comm_envoie.ActiveLinkColor = Color.FromArgb(27, 94, 164);
            link_comm_envoie.Anchor = AnchorStyles.Left;
            link_comm_envoie.AutoSize = true;
            link_comm_envoie.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            link_comm_envoie.LinkBehavior = LinkBehavior.NeverUnderline;
            link_comm_envoie.LinkColor = Color.White;
            link_comm_envoie.Location = new Point(24, 222);
            link_comm_envoie.Margin = new Padding(24, 0, 6, 0);
            link_comm_envoie.Name = "link_comm_envoie";
            link_comm_envoie.Size = new Size(236, 30);
            link_comm_envoie.TabIndex = 3;
            link_comm_envoie.TabStop = true;
            link_comm_envoie.Text = "Commandes en envoie";
            link_comm_envoie.LinkClicked += link_comm_envoie_LinkClicked;
            // 
            // link_comm_final
            // 
            link_comm_final.ActiveLinkColor = Color.FromArgb(27, 94, 164);
            link_comm_final.Anchor = AnchorStyles.Left;
            link_comm_final.AutoSize = true;
            link_comm_final.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            link_comm_final.LinkBehavior = LinkBehavior.NeverUnderline;
            link_comm_final.LinkColor = Color.White;
            link_comm_final.Location = new Point(24, 273);
            link_comm_final.Margin = new Padding(24, 0, 6, 0);
            link_comm_final.Name = "link_comm_final";
            link_comm_final.Size = new Size(228, 30);
            link_comm_final.TabIndex = 5;
            link_comm_final.TabStop = true;
            link_comm_final.Text = "Commandes finalisées";
            link_comm_final.LinkClicked += link_comm_final_LinkClicked;
            // 
            // link_stock
            // 
            link_stock.ActiveLinkColor = Color.FromArgb(27, 94, 164);
            link_stock.Anchor = AnchorStyles.Left;
            link_stock.AutoSize = true;
            link_stock.LinkBehavior = LinkBehavior.NeverUnderline;
            link_stock.LinkColor = Color.White;
            link_stock.Location = new Point(6, 341);
            link_stock.Margin = new Padding(6, 21, 6, 0);
            link_stock.Name = "link_stock";
            link_stock.Size = new Size(81, 32);
            link_stock.TabIndex = 6;
            link_stock.TabStop = true;
            link_stock.Text = "Stocks";
            link_stock.LinkClicked += link_stock_LinkClicked;
            // 
            // link_embalage
            // 
            link_embalage.ActiveLinkColor = Color.FromArgb(27, 94, 164);
            link_embalage.Anchor = AnchorStyles.Left;
            link_embalage.AutoSize = true;
            link_embalage.LinkBehavior = LinkBehavior.NeverUnderline;
            link_embalage.LinkColor = Color.White;
            link_embalage.Location = new Point(6, 401);
            link_embalage.Margin = new Padding(6, 21, 6, 0);
            link_embalage.Name = "link_embalage";
            link_embalage.Size = new Size(282, 32);
            link_embalage.TabIndex = 7;
            link_embalage.TabStop = true;
            link_embalage.Text = "Commandes à emballées";
            link_embalage.LinkClicked += link_embalage_LinkClicked;
            // 
            // tlp_header_haut
            // 
            tlp_header_haut.ColumnCount = 1;
            tlp_header_haut.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_header_haut.Controls.Add(flowLayoutPanel1, 0, 0);
            tlp_header_haut.Location = new Point(331, 6);
            tlp_header_haut.Margin = new Padding(6);
            tlp_header_haut.Name = "tlp_header_haut";
            tlp_header_haut.RowCount = 1;
            tlp_header_haut.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_header_haut.Size = new Size(1149, 158);
            tlp_header_haut.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(pictureBox2);
            flowLayoutPanel1.Controls.Add(lbl_titre);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(6, 6);
            flowLayoutPanel1.Margin = new Padding(6);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1137, 146);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(6, 6);
            pictureBox2.Margin = new Padding(6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 73);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // lbl_titre
            // 
            lbl_titre.Anchor = AnchorStyles.Left;
            lbl_titre.AutoSize = true;
            lbl_titre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_titre.Location = new Point(79, 26);
            lbl_titre.Margin = new Padding(6, 0, 6, 0);
            lbl_titre.Name = "lbl_titre";
            lbl_titre.Size = new Size(199, 32);
            lbl_titre.TabIndex = 1;
            lbl_titre.Text = "Tableau de bord";
            // 
            // FormPrincipale
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(tableLayoutPanel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            Name = "FormPrincipale";
            Text = "FormPrincipale";
            tableLayoutPanel2.ResumeLayout(false);
            tblp_comm_att.ResumeLayout(false);
            tlp_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            tblp_pers.ResumeLayout(false);
            tblp_pers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pers).EndInit();
            tblp_menu.ResumeLayout(false);
            tblp_menu.PerformLayout();
            tlp_header_haut.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tblp_comm_att;
        private TableLayoutPanel tlp_logo;
        private PictureBox logo;
        private TableLayoutPanel tblp_pers;
        private PictureBox pers;
        private Label lbl_pers_conn;
        private Label lbl_role;
        private TableLayoutPanel tblp_menu;
        private LinkLabel liklab_tab_bord;
        private LinkLabel link_comm_attente;
        private Label lbl_commandes;
        private LinkLabel link_comm_envoie;
        private LinkLabel link_comm_final;
        private TableLayoutPanel tlp_header_haut;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox2;
        private Label lbl_titre;
        private Panel pnlContenu;
        private LinkLabel link_embalage;
        private LinkLabel link_stock;
    }
}