
using System.Data;

namespace LogistiqueGestion
{
    public partial class UC_PrepasCommande : UserControl
    {
        API _api;
        private int _commandeId;

        public UC_PrepasCommande(int commandeId)
        {
            InitializeComponent();

            _commandeId = commandeId;

            // CETTE LIGNE EST OBLIGATOIRE POUR QUE L'ÉVÉNEMENT SE DÉCLENCHE !
            this.Load += UC_PrepasCommande_Load;

            /* Mettre titre colonne au centre */
            // Le chiffre 3 correspond à la 4ème colonne
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Le chiffre 2 correspond à la 3ème colonne
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private async void UC_PrepasCommande_Load(object sender, EventArgs e)
        {
            // Évite de lancer la requête si l'ID vaut 0
            if (_commandeId <= 0) return;

            _api = new();
            await ChargerCommandeProduits(_commandeId);


            //information commande
            //lbl_NummComm.Text = "22";
            //lbl_nomClient.Text = "client A";
            //lbl_date.Text = "12/22/2026";

        }


        private async Task ChargerCommandeProduits(int commandeId)
        {
            try
            {
                var result = await _api.GetRESTAsync<GetLigneCommandeResponse>($"http://localhost:5287/api/LigneCommandes/Commande/{commandeId}");

                var lignecommandesARecup = (result?.Items ?? Enumerable.Empty<LigneCommande>()).ToList();

                // Vider le tableau
                dataGridView1.Rows.Clear();

                // On boucle directement sur chaque ligne de commande (chaque produit)
                foreach (var item in lignecommandesARecup)
                {
                    dataGridView1.Rows.Add(
                        item.NomProduit,    // Accessible directement sur 'item' (LigneCommande)
                        item.ProduitId,     // Référence
                        item.Quantite,      // Quantité
                        item.EstRamasse // Récupéré
                    );

                    
                }

                // Retire la sélection bleue automatique sur la première ligne
                dataGridView1.ClearSelection();

                // Remplir les informations client en haut à partir du premier produit
                var premiereLigne = lignecommandesARecup.FirstOrDefault();
                if (premiereLigne != null)
                {
                    lblCommande.Text = $"Commande N° : {commandeId}";
                    lbl_nomClient.Text = $"{premiereLigne.PrenomClient} {premiereLigne.NomClient}";
                    lbl_date.Text = premiereLigne.Date;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible de contacter l'API : " + ex.Message);
            }
        }


    }
}
