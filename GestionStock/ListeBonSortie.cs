using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStock
{
    public partial class ListeBonSortie : Form

    {
        public ListeBonSortie()

        {

            InitializeComponent();

        }

        private void ListeBonSortie_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            using (StockContainer bd = new StockContainer())

            {
                cbRecette.Items.Clear();

                lstProduits.Items.Clear();
                lstBonSortie.Items.Clear();

                txtQuantiteProduite.Text = "";

                cbRecette.Items.AddRange(bd.Recettes.ToArray());
                cbRecette.DisplayMember = "nom";
                lstBonSortie.Items.AddRange(bd.BonsSorties.ToArray());





            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        int tesst = 1;
        private void btnEnregistrer_Click(object sender, EventArgs e)

        {


            using (StockContainer bd = new StockContainer())
            {
                if (cbRecette.SelectedIndex == -1 || txtQuantiteProduite.Text == "" || lstProduits.Items.Count == 0 )
                {
                    MessageBox.Show("verifier les champs vides");
                    tesst = 1;
                }
                else

                {
                    if (tesst == 1)
                    {
                        tesst = 0;
                        MessageBox.Show("Veuillez vérifier toutes les informations. Toute modification après l'enregistrement sera impossible.");
                        return;
                    }

                    BonsSortie c = new BonsSortie();
                    c.RecetteId = ((Recette)cbRecette.SelectedItem).Id;
                    c.QuantiteProduite = Convert.ToInt32(txtQuantiteProduite.Text);
                    c.Date = DateTime.Now;

                    int lastProductId = bd.BonsSorties
                        .OrderByDescending(p => p.Num)
                        .Select(p => p.Num)
                        .FirstOrDefault();
                    if (lastProductId == 0)
                    {
                        c.Num = 1;
                    }
                    else
                    {
                        c.Num = lastProductId + 1;
                    }



                    bd.BonsSorties.Add(c);


                    bd.SaveChanges();
                    c = bd.BonsSorties.Where(a => a.Num == c.Num).FirstOrDefault();
                    decimal cost = 0;
                    foreach (DetailBonSortieSet h in lstProduits.Items)
                    {
                        ProduitSet x = bd.ProduitSets.Find(h.ProduitId);

                        x.quantiteStock = x.quantiteStock-h.Quantite;
                        bd.SaveChanges();
                        h.NumBonsSortie = c.Num;

                        cost += Convert.ToDecimal(h.Quantite * h.coutUnitaire);
                    }
                    c.coutTotal = cost;
                    bd.SaveChanges();
                    //problem ici
                    foreach (DetailBonSortieSet item in lstProduits.Items)
                    {
                        
                        bd.DetailBonSortieSets.Add(item);
                        ProduitSet.VerifierQuantiteStock(item.ProduitId);

                    }
                    bd.SaveChanges();
                    tesst = 1;
                    ListeBonSortie_Load(sender, e);
                }

            }
        }

        private void cbRecette_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (StockContainer bd = new StockContainer())
            {

                Recette c = ((Recette)cbRecette.SelectedItem);





                txtQuantiteProduite.Text = c.QuantiteProduite.ToString();

                lstProduits.Items.Clear();

                
                foreach (RecetteProduit v in bd.RecetteProduits)
                {
                    DetailBonSortieSet a = new DetailBonSortieSet();

                    if (v.RecetteId.Equals(c.Id))
                    {

                        a.Quantite = v.Quantite;
                        a.ProduitId = v.ProduitId;

                        a.coutUnitaire = (bd.ProduitSets.Find(v.ProduitId)).CoutMoyenUnitaire;
                        lstProduits.Items.Add(a);

                    }
                }

            }
        }

        private void txtQuantiteProduite_TextChanged(object sender, EventArgs e)
        {
            decimal quantite;
            if (txtQuantiteProduite.Text != "")
            {


                if (decimal.TryParse(txtQuantiteProduite.Text, out quantite))
                {
                    using (StockContainer bd = new StockContainer())
                    {

                        Recette c = ((Recette)cbRecette.SelectedItem);




                        if (c != null) { 

                        lstProduits.Items.Clear();

                       
                        foreach (RecetteProduit v in bd.RecetteProduits)
                        {
                                DetailBonSortieSet a = new DetailBonSortieSet();
                                if (v.RecetteId.Equals(c.Id))
                            {
                                decimal quantiteNecessaire = Math.Round( (decimal)((v.Quantite / c.QuantiteProduite) * Convert.ToDecimal(txtQuantiteProduite.Text)),3);

                                // Vérifiez si la quantité nécessaire est disponible pour chaque produit
                                if (quantiteNecessaire <= (bd.ProduitSets.Find(v.ProduitId)).quantiteStock)
                                {
                                    // Ajoutez les détails à la liste
                                    a.Quantite = quantiteNecessaire;
                                    a.ProduitId = v.ProduitId;

                                    a.coutUnitaire = (bd.ProduitSets.Find(v.ProduitId)).CoutMoyenUnitaire;
                                    lstProduits.Items.Add(a);
                                }
                                else
                                {
                                    
                                    txtQuantiteProduite.Text = "";
                                    MessageBox.Show($"Quantité insuffisante de {(bd.ProduitSets.Find(v.ProduitId)).nom}, quantite disponible:{bd.ProduitSets.Find(v.ProduitId).quantiteStock} | quantite requise pour la reccete {quantiteNecessaire}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    lstProduits.Items.Clear();
                                    break; // Arrêtez le processus d'ajout du bon de sortie
                                }


                                }

                            }
                        }


                    }
                }
            
        


    }
}
    }
}
