using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogistiqueGestion
{
    public partial class TableauDeBord : Form
    {
        public TableauDeBord()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            // Ombre simple
            int shadowSize = 4;
            Color shadowColor = Color.FromArgb(50, 0, 0, 0);
            using (SolidBrush brush = new SolidBrush(shadowColor))
            {
                e.Graphics.FillRectangle(brush,
                    new Rectangle(shadowSize, shadowSize,
                    Width - shadowSize, Height - shadowSize));
            }
        }

        private void TableauDeBord_Load(object sender, EventArgs e)
        {
            // 1. On crée ton bleu une bonne fois pour toutes
            Color bleuFoncer = Color.FromArgb(6, 27, 57);
            Color bleuClair = Color.FromArgb(27, 94, 164);
            Color bleuClairMini = Color.FromArgb(80, 173, 242);

            // 2. On l'applique les couleur à mes composants 
            lbl_nb_comm.ForeColor = bleuClairMini;

            /* ---------- */
            RoundPanel(panle_card1, 15);
            RoundPanel(panle_card2, 15);

            // donnée tableau en attendant d'avoir les vrais valeurs 
            dataGridView1.Rows.Add("#0001", "20/05/2026", "3", "3500€");
            dataGridView1.Rows.Add("#0002", "20/05/2026", "8", "120€");
            dataGridView1.Rows.Add("#0003", "20/05/2026", "1", "20€");
        }

        // Applique des coins arrondis à un panel
        private void RoundPanel(Panel panel, int radius)
        {
            // Crée un chemin graphique pour définir la forme arrondie
            GraphicsPath path = new GraphicsPath();

            // Coin haut gauche
            path.AddArc(0, 0, radius, radius, 180, 90);
            // Coin haut droit
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
            // Coin bas droit
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
            // Coin bas gauche
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);

            // Ferme la forme
            path.CloseAllFigures();

            // Applique la forme arrondie au panel
            panel.Region = new Region(path);
        }

    }
}
