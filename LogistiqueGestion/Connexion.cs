namespace LogistiqueGestion
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 1. On crée ton bleu une bonne fois pour toutes
            Color bleuFoncer = Color.FromArgb(6, 27, 57);
            Color bleuClair = Color.FromArgb(27, 94, 164);

            // 2. On l'applique les couleur à mes composants 
            lbl_titre.ForeColor = bleuFoncer;
            lbl_description.ForeColor = bleuClair;
            lbl_email.ForeColor = bleuClair;
            lbl_mdp.ForeColor = bleuClair;
            btn_connexion.ForeColor = bleuClair;
        }

       

        private void btn_connexion_Click(object sender, EventArgs e)
        {

            try
            {
                var connection = "http://localhost:5287/api/login";

                MessageBox.Show("La condition est vraie !");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible de contacter l'API : " + ex.Message);
            }
        }
    }
}
