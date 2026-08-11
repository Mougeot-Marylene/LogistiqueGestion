
using System.Net.Http.Json;
using System.Windows.Forms;
using System.Linq; // OBLIGATOIRE pour utiliser Enumerable.Empty et ToList

namespace LogistiqueGestion
{
    public partial class UC_TableauDeBord : UserControl
    {
        API _api;
        public UC_TableauDeBord()
        {
            InitializeComponent();

            // CETTE LIGNE EST OBLIGATOIRE POUR QUE L'ÉVÉNEMENT SE DÉCLENCHE !
            this.Load += UC_TableauDeBord_Load;

            // Remplace 'dataGridView1' par le nom de ton tableau si besoin
            // Centert le titre de la colonne du tableau, Le chiffre 2 correspond à ta 3ème colonne (N° commande = 0, Date = 1, Nombre de produits = 2)
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Remplace 'dataGridView1' par le nom de ton tableau si besoin
            // Le chiffre 2 correspond à ta 3ème colonne (N° commande = 0, Date = 1, Nombre de produits = 2)
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Abonner l'événement au clic sur une cellule du tableau
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }

        // L'événement Load permet d'utiliser 'async void' en toute sécurité dans WinForms
        private async void UC_TableauDeBord_Load(object sender, EventArgs e)
        {
            _api = new();
            // appel methode pour afficher les commandes en attentes
            await ChargerCommandes();
        }


        //ouverture de UC_PrepaCommande (lien preparer)
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vérifie que c'est la colonne "préparer" qui est cliquée et pas l'en-tête
            if (dataGridView1.Columns[e.ColumnIndex].Name == "preparer" && e.RowIndex >= 0)
            {
                // Créer une instance du UserControl UC_PrepasCommande
                UC_PrepasCommande uc = new UC_PrepasCommande();

                // Le faire occuper tout l'espace disponible
                uc.Dock = DockStyle.Fill;

                // Vider le contenu actuel
                this.Controls.Clear();

                // Afficher le UserControl UC_PrepasCommande
                this.Controls.Add(uc);
            }
        }
        private async Task ChargerCommandes()
        {

            try
            {
                /* ------------------------------------
                     Récupération Commande en attente
                   ------------------------------------
                */ 
                var resultCommAttente = await _api.GetRESTAsync<GetCommandeResponse>("http://localhost:5287/api/Commandes/EnAttente");
               
                //// → resultCommAttente?.Items : si "resultCommAttente" n'est pas null, on récupère sa propriété "Items"
                //// → ?? : sinon, si "resultCommAttente?.Items" vaut null...
                //// → Enumerable.Empty<LigneCommande>() : on utilise une liste vide de LigneCommand
                var commandesAttente = (resultCommAttente?.Items ?? Enumerable.Empty<Commande>()).ToList();

                int nb_comm_attente = commandesAttente.Count;

                lbl_nb_comm.Text = nb_comm_attente.ToString();


                /* ------------------------------------
                    Récupération Commande en envoie
                  ------------------------------------
               */
                var resultCommEnv = await _api.GetRESTAsync<GetCommandeResponse>("http://localhost:5287/api/LigneCommandes/EnEnvoie");

                //// → resultCommEnv?.Items : si "resultCommEnv" n'est pas null, on récupère sa propriété "Items"
                //// → ?? : sinon, si "resultCommEnv?.Items" vaut null...
                //// → Enumerable.Empty<LigneCommande>() : on utilise une liste vide de LigneCommand
                var commandesEnv = (resultCommEnv?.Items ?? Enumerable.Empty<Commande>()).ToList();

                int nb_comm_env = commandesEnv.Count;

                lbl_nb_comm_env.Text = nb_comm_env.ToString();


                /* ------------------------------------
                    Récupération Commande en finalisée
                  ------------------------------------
               */
                var resultCommFinalise = await _api.GetRESTAsync<GetCommandeResponse>("http://localhost:5287/api/Commandes/Finalise");

                //// → resultCommFinalise?.Items : si "resultCommFinalise" n'est pas null, on récupère sa propriété "Items"
                //// → ?? : sinon, si "resultCommFinalise?.Items" vaut null...
                //// → Enumerable.Empty<LigneCommande>() : on utilise une liste vide de LigneCommand
                var commandesFinalise = (resultCommFinalise?.Items ?? Enumerable.Empty<Commande>()).ToList();

                int nb_comm_finalise = commandesFinalise.Count;

                lbl_nb_comm_fina.Text = nb_comm_finalise.ToString();


                /* ------------------------------------
                    Récupération Commande prépa
                  ------------------------------------
               */
                var resultCommPrepa = await _api.GetRESTAsync<GetCommandeResponse>("http://localhost:5287/api/Commandes/Preparation");

                //// → resultCommPrepa?.Items : si "resultCommPrepa" n'est pas null, on récupère sa propriété "Items"
                //// → ?? : sinon, si "resultCommPrepa?.Items" vaut null...
                //// → Enumerable.Empty<LigneCommande>() : on utilise une liste vide de LigneCommand
                var commandesPrepa = (resultCommPrepa?.Items ?? Enumerable.Empty<Commande>()).ToList();

                int nb_comm_prepa = commandesPrepa.Count;

                /* ------------------------------------
                   Calcul total de toutes les commandes
                  ------------------------------------
                */

                int test = nb_comm_attente + nb_comm_env + nb_comm_finalise + nb_comm_prepa;
                lbl_nb_tot_prd.Text = test.ToString();
                                


                // DONNÉES TEMPORAIRES (placées ici au lieu du Paint)
                var resultLigneCommAttente = await _api.GetRESTAsync<GetLigneCommandeResponse>("http://localhost:5287/api/LigneCommandes/EnAttente");
                //dataGridView1.Rows.Add(item.Id.ToString(), "20/05/2026", "3", "3500€", "Préparer"); 
                var lignecommandesAttente = (resultLigneCommAttente?.Items ?? Enumerable.Empty<LigneCommande>()).ToList();

                // Regroupement par CommandeId
                var commandesGroupees = lignecommandesAttente
                    .GroupBy(l => l.CommandeId)
                    .Select(g => new
                    {
                        CommandeId = g.Key,
                        // Récupère la date de la première ligne
                        Date = g.First().Date,
                        // Somme des quantités de produits
                        QuantiteTotale = g.Sum(x => x.Quantite),
                        // Somme du (PrixUnitaire * Quantite) ou PrixTotal de chaque ligne
                        PrixTotalCommande = g.Sum(x => x.PrixTotal) // Somme directe du PrixTotal déjà calculé dans la requette
                    });


                // Vider le tableau
                dataGridView1.Rows.Clear();

                foreach (var item in commandesGroupees)
                {
                    dataGridView1.Rows.Add(
                        item.CommandeId.ToString(),
                        item.Date,
                        item.QuantiteTotale,
                        item.PrixTotalCommande.ToString() + " €",
                        "Préparer"
                    );
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible de contacter l'API : " + ex.Message);
            }
        }

    }
}
