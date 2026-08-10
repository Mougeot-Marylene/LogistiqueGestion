namespace LogistiqueGestion
{
    partial class Connexion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            tableLayoutPanel1 = new TableLayoutPanel();
            tblp_logo = new TableLayoutPanel();
            logo = new PictureBox();
            pnl_tratit_logo = new Panel();
            tblp_titre = new TableLayoutPanel();
            lbl_titre = new Label();
            lbl_description = new Label();
            pnl_tratit_titre = new Panel();
            tblp_form = new TableLayoutPanel();
            tblEmail = new TableLayoutPanel();
            lbl_email = new Label();
            tb_email = new TextBox();
            tblMdp = new TableLayoutPanel();
            lbl_mdp = new Label();
            tb_mdp = new TextBox();
            tblp_btn = new TableLayoutPanel();
            btn_connexion = new Button();
            tableLayoutPanel1.SuspendLayout();
            tblp_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            tblp_titre.SuspendLayout();
            tblp_form.SuspendLayout();
            tblEmail.SuspendLayout();
            tblMdp.SuspendLayout();
            tblp_btn.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(tblp_logo, 1, 0);
            tableLayoutPanel1.Controls.Add(tblp_titre, 1, 1);
            tableLayoutPanel1.Controls.Add(tblp_form, 1, 2);
            tableLayoutPanel1.Controls.Add(tblp_btn, 1, 3);
            tableLayoutPanel1.Location = new Point(0, 2);
            tableLayoutPanel1.MinimumSize = new Size(841, 444);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(841, 444);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tblp_logo
            // 
            tblp_logo.ColumnCount = 3;
            tblp_logo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.46154F));
            tblp_logo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.0769253F));
            tblp_logo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.4615364F));
            tblp_logo.Controls.Add(logo, 1, 0);
            tblp_logo.Controls.Add(pnl_tratit_logo, 0, 1);
            tblp_logo.Location = new Point(23, 3);
            tblp_logo.Name = "tblp_logo";
            tblp_logo.RowCount = 2;
            tblp_logo.RowStyles.Add(new RowStyle(SizeType.Percent, 96.52509F));
            tblp_logo.RowStyles.Add(new RowStyle(SizeType.Percent, 3.474903F));
            tblp_logo.Size = new Size(795, 100);
            tblp_logo.TabIndex = 5;
            // 
            // logo
            // 
            logo.Anchor = AnchorStyles.None;
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(308, 3);
            logo.Name = "logo";
            logo.Size = new Size(177, 90);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // pnl_tratit_logo
            // 
            pnl_tratit_logo.BackColor = Color.Gainsboro;
            tblp_logo.SetColumnSpan(pnl_tratit_logo, 3);
            pnl_tratit_logo.Dock = DockStyle.Fill;
            pnl_tratit_logo.Location = new Point(3, 99);
            pnl_tratit_logo.Name = "pnl_tratit_logo";
            pnl_tratit_logo.Size = new Size(789, 1);
            pnl_tratit_logo.TabIndex = 1;
            // 
            // tblp_titre
            // 
            tblp_titre.ColumnCount = 1;
            tblp_titre.ColumnStyles.Add(new ColumnStyle());
            tblp_titre.Controls.Add(lbl_titre, 0, 0);
            tblp_titre.Controls.Add(lbl_description, 0, 1);
            tblp_titre.Controls.Add(pnl_tratit_titre, 0, 2);
            tblp_titre.Location = new Point(23, 109);
            tblp_titre.Name = "tblp_titre";
            tblp_titre.RowCount = 3;
            tblp_titre.RowStyles.Add(new RowStyle(SizeType.Percent, 69.15586F));
            tblp_titre.RowStyles.Add(new RowStyle(SizeType.Percent, 30.8441372F));
            tblp_titre.RowStyles.Add(new RowStyle(SizeType.Absolute, 3F));
            tblp_titre.Size = new Size(795, 118);
            tblp_titre.TabIndex = 3;
            // 
            // lbl_titre
            // 
            lbl_titre.Anchor = AnchorStyles.None;
            lbl_titre.AutoSize = true;
            lbl_titre.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_titre.ForeColor = Color.FromArgb(72, 65, 0);
            lbl_titre.Location = new Point(235, 19);
            lbl_titre.Name = "lbl_titre";
            lbl_titre.Size = new Size(458, 40);
            lbl_titre.TabIndex = 2;
            lbl_titre.Text = "Bienvenue chez Logistique Gestion";
            // 
            // lbl_description
            // 
            lbl_description.Anchor = AnchorStyles.None;
            lbl_description.AutoSize = true;
            lbl_description.ForeColor = Color.FromArgb(27, 94, 164);
            lbl_description.Location = new Point(371, 84);
            lbl_description.Margin = new Padding(3, 0, 3, 10);
            lbl_description.Name = "lbl_description";
            lbl_description.Size = new Size(186, 15);
            lbl_description.TabIndex = 1;
            lbl_description.Text = "logiciel de gestion de la logistique";
            // 
            // pnl_tratit_titre
            // 
            pnl_tratit_titre.BackColor = Color.Gainsboro;
            pnl_tratit_titre.Dock = DockStyle.Fill;
            pnl_tratit_titre.Location = new Point(3, 117);
            pnl_tratit_titre.Name = "pnl_tratit_titre";
            pnl_tratit_titre.Size = new Size(922, 1);
            pnl_tratit_titre.TabIndex = 3;
            // 
            // tblp_form
            // 
            tblp_form.ColumnCount = 1;
            tblp_form.ColumnStyles.Add(new ColumnStyle());
            tblp_form.Controls.Add(tblEmail, 0, 0);
            tblp_form.Controls.Add(tblMdp, 0, 1);
            tblp_form.Location = new Point(23, 263);
            tblp_form.Margin = new Padding(3, 33, 3, 3);
            tblp_form.Name = "tblp_form";
            tblp_form.RowCount = 2;
            tblp_form.RowStyles.Add(new RowStyle());
            tblp_form.RowStyles.Add(new RowStyle());
            tblp_form.Size = new Size(795, 112);
            tblp_form.TabIndex = 4;
            // 
            // tblEmail
            // 
            tblEmail.ColumnCount = 3;
            tblEmail.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tblEmail.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tblEmail.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tblEmail.Controls.Add(lbl_email, 1, 0);
            tblEmail.Controls.Add(tb_email, 1, 1);
            tblEmail.Location = new Point(3, 3);
            tblEmail.Name = "tblEmail";
            tblEmail.RowCount = 2;
            tblEmail.RowStyles.Add(new RowStyle());
            tblEmail.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblEmail.Size = new Size(789, 50);
            tblEmail.TabIndex = 0;
            // 
            // lbl_email
            // 
            lbl_email.Anchor = AnchorStyles.Left;
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(265, 0);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(36, 15);
            lbl_email.TabIndex = 0;
            lbl_email.Text = "Email";
            // 
            // tb_email
            // 
            tb_email.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_email.Location = new Point(265, 18);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(250, 22);
            tb_email.TabIndex = 0;
            // 
            // tblMdp
            // 
            tblMdp.ColumnCount = 3;
            tblMdp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblMdp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tblMdp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tblMdp.Controls.Add(lbl_mdp, 1, 0);
            tblMdp.Controls.Add(tb_mdp, 1, 1);
            tblMdp.Location = new Point(3, 59);
            tblMdp.Name = "tblMdp";
            tblMdp.RowCount = 2;
            tblMdp.RowStyles.Add(new RowStyle());
            tblMdp.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMdp.Size = new Size(789, 86);
            tblMdp.TabIndex = 1;
            // 
            // lbl_mdp
            // 
            lbl_mdp.Anchor = AnchorStyles.Left;
            lbl_mdp.AutoSize = true;
            lbl_mdp.Location = new Point(265, 0);
            lbl_mdp.Name = "lbl_mdp";
            lbl_mdp.Size = new Size(77, 15);
            lbl_mdp.TabIndex = 0;
            lbl_mdp.Text = "Mot de passe";
            // 
            // tb_mdp
            // 
            tb_mdp.Location = new Point(265, 18);
            tb_mdp.Name = "tb_mdp";
            tb_mdp.Size = new Size(253, 23);
            tb_mdp.TabIndex = 1;
            // 
            // tblp_btn
            // 
            tblp_btn.ColumnCount = 3;
            tblp_btn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tblp_btn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tblp_btn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tblp_btn.Controls.Add(btn_connexion, 1, 0);
            tblp_btn.Location = new Point(23, 381);
            tblp_btn.Name = "tblp_btn";
            tblp_btn.RowCount = 1;
            tblp_btn.RowStyles.Add(new RowStyle());
            tblp_btn.Size = new Size(795, 33);
            tblp_btn.TabIndex = 6;
            // 
            // btn_connexion
            // 
            btn_connexion.Anchor = AnchorStyles.Left;
            btn_connexion.Location = new Point(267, 5);
            btn_connexion.Name = "btn_connexion";
            btn_connexion.Size = new Size(92, 23);
            btn_connexion.TabIndex = 0;
            btn_connexion.Text = "Me connecter ";
            btn_connexion.UseVisualStyleBackColor = true;
            btn_connexion.Click += btn_connexion_Click;
            // 
            // Connexion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 450);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(857, 472);
            Name = "Connexion";
            Text = "Logistique gestion - Connexion";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tblp_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            tblp_titre.ResumeLayout(false);
            tblp_titre.PerformLayout();
            tblp_form.ResumeLayout(false);
            tblEmail.ResumeLayout(false);
            tblEmail.PerformLayout();
            tblMdp.ResumeLayout(false);
            tblMdp.PerformLayout();
            tblp_btn.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox logo;
        private Label lbl_description;
        private Label lbl_titre;
        private TableLayoutPanel tblp_titre;
        private TableLayoutPanel tblp_form;
        private TableLayoutPanel tblEmail;
        private TableLayoutPanel tblMdp;
        private Label lbl_email;
        private TableLayoutPanel tblp_logo;
        private Label lbl_mdp;
        private TableLayoutPanel tblp_btn;
        private TextBox tb_email;
        private TextBox tb_mdp;
        private Button btn_connexion;
        private Panel pnl_tratit_titre;
        private Panel pnl_tratit_logo;
    }
}
