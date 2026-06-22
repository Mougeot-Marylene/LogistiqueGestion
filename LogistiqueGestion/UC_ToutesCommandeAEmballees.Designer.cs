namespace LogistiqueGestion
{
    partial class UC_ToutesCommandeAEmballees
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tableLayoutPanel3 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            numCommande = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            nbProduits = new DataGridViewTextBoxColumn();
            Prix = new DataGridViewTextBoxColumn();
            emballer = new DataGridViewLinkColumn();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(dataGridView1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(922, 444);
            tableLayoutPanel3.TabIndex = 7;
            tableLayoutPanel3.Paint += tableLayoutPanel3_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { numCommande, Date, nbProduits, Prix, emballer });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(916, 438);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += this.dataGridView1_CellContentClick;
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            nbProduits.DefaultCellStyle = dataGridViewCellStyle3;
            nbProduits.HeaderText = "Nombre de produits";
            nbProduits.Name = "nbProduits";
            // 
            // Prix
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Prix.DefaultCellStyle = dataGridViewCellStyle4;
            Prix.HeaderText = "Prix";
            Prix.Name = "Prix";
            // 
            // emballer
            // 
            emballer.ActiveLinkColor = Color.FromArgb(80, 173, 242);
            emballer.HeaderText = "";
            emballer.LinkColor = Color.FromArgb(80, 173, 242);
            emballer.Name = "emballer";
            emballer.Resizable = DataGridViewTriState.True;
            emballer.SortMode = DataGridViewColumnSortMode.Automatic;
            emballer.VisitedLinkColor = Color.FromArgb(80, 173, 242);
            // 
            // UC_ToutesCommandeAEmballees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel3);
            Name = "UC_ToutesCommandeAEmballees";
            Size = new Size(922, 444);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn numCommande;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn nbProduits;
        private DataGridViewTextBoxColumn Prix;
        private DataGridViewLinkColumn emballer;
    }
}
