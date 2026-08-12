using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogistiqueGestion
{
    public partial class UC_CommandesFinalisees : UserControl
    {
        API _api;
        public UC_CommandesFinalisees()
        {
            InitializeComponent();
            // CETTE LIGNE EST OBLIGATOIRE POUR QUE L'ÉVÉNEMENT SE DÉCLENCHE !
            this.Load += UC_CommandesFinalisees_Load;

            // Center le titre de la colonne du tableau, Le chiffre 2 correspond à ta 3ème colonne (N° commande = 0, Date = 1, Nombre de produits = 2)
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Remplace 'dataGridView1' par le nom de ton tableau si besoin
            // Le chiffre 2 correspond à ta 3ème colonne (N° commande = 0, Date = 1, Nombre de produits = 2)
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        // L'événement Load permet d'utiliser 'async void' en toute sécurité dans WinForms
        private async void UC_CommandesFinalisees_Load(object sender, EventArgs e)
        {
            _api = new();
            // appel methode pour afficher les commandes 
            await ChargerCommandes();
        }

        private async Task ChargerCommandes()
        {

            try
            {
                /* ------------------------------------
                  Tableau des commandes finalisées
                  ------------------------------------
                */

                // DONNÉES TEMPORAIRES (placées ici au lieu du Paint)
                var resultLigneCommFinalise = await _api.GetRESTAsync<GetLigneCommandeResponse>("http://localhost:5287/api/LigneCommandes/Finalise");

                var lignecommandesFinalise = (resultLigneCommFinalise?.Items ?? Enumerable.Empty<LigneCommande>()).ToList();

                // Regroupement par CommandeId
                var commandesGroupees = lignecommandesFinalise
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
