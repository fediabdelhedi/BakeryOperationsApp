using GestionStock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeStock
{
    public partial class ListeProduits : Form
    {
        public ListeProduits()
        {
            InitializeComponent();
        }

        private void ListeProduits_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            using (StockContainer bd = new StockContainer())

            {

                btnSupprimer.Enabled = false;
                lstProduit.Items.Clear();
                txtPrixAchat.Text = "";
                txtProduit.Text = "";
                txtQuantite.Text = "";
                txtQuantiteMin.Text = "";
                txtCoutUni.Text = "";


                lstProduit.Items.AddRange(bd.ProduitSets.ToArray());




            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstProduit_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (StockContainer bd = new StockContainer())
            {
                if (lstProduit.SelectedItem != null)
                {
                    ProduitSet c = (ProduitSet)lstProduit.SelectedItem;
                    btnSupprimer.Enabled = true;

                    txtProduit.Text = c.nom;
                    txtQuantite.Text = c.quantiteStock.ToString();
                    txtQuantiteMin.Text = c.quantiteMinimum.ToString();
                    txtCoutUni.Text = c.CoutMoyenUnitaire.ToString();
                    decimal totalCost = (decimal)(c.CoutMoyenUnitaire * c.quantiteStock);
                    txtPrixAchat.Text = totalCost.ToString();


                }
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            using (StockContainer bd = new StockContainer())
            {
                ProduitSet c = (ProduitSet)lstProduit.SelectedItem;
                if (c != null)
                {
                    DialogResult dr = MessageBox.Show("vous êtes sur ?", "Attention", MessageBoxButtons.OKCancel);
                    if (dr == DialogResult.OK)
                    {
                        int x = 0;

                        foreach (RecetteProduit v in bd.RecetteProduits)
                        {
                            if (v.ProduitId.Equals(c.Id))
                            {
                                x = 1;
                                MessageBox.Show("impossible , ce produit deja utilisé dans une recette! ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                break;

                            }
                        }
                        if (x == 0)
                        {
                            c = bd.ProduitSets.Where(y => y.Id == c.Id).FirstOrDefault();
                            bd.ProduitSets.Remove(c);
                            bd.SaveChanges();
                        }

                    }
                    ListeProduits_Load(sender, e);
                }
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {

            if (txtProduit.Text == "" || txtQuantite.Text == "" ||
            txtQuantiteMin.Text == "" ||
            txtCoutUni.Text == "" )
            {
                MessageBox.Show("Veuillez remplir tous les champs.");

            }
            else
            {

                using (StockContainer bd = new StockContainer())
                {

                    if (bd.ProduitSets
                    .Where(x => x.nom == txtProduit.Text)
                    .Count() > 0)
                    {
                        decimal quantiteStock, quantiteMinimum, coutMoyenUnitaire;
                        if (decimal.TryParse(txtQuantite.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out quantiteStock) &&
                            decimal.TryParse(txtQuantiteMin.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out quantiteMinimum) &&
                            decimal.TryParse(txtCoutUni.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out coutMoyenUnitaire))
                        {


                            ProduitSet p = bd.ProduitSets
                                .Where(x => x.nom == txtProduit.Text)
                                .FirstOrDefault();
                            p.quantiteStock = quantiteStock;
                            p.quantiteMinimum = quantiteMinimum;
                            p.CoutMoyenUnitaire = coutMoyenUnitaire;


                            bd.SaveChanges();

                        }
                        else
                        {
                            MessageBox.Show("Problème avec les entrées. Veuillez saisir à nouveau la quantité du produit, la quantité minimum et son coût unitaire.","Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            return;
                        }
                    }
                    else
                    {
                        decimal quantiteStock, quantiteMinimum, coutMoyenUnitaire;

                        // Vérifier si les valeurs sont des décimaux valides
                        if (decimal.TryParse(txtQuantite.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out quantiteStock) &&
                            decimal.TryParse(txtQuantiteMin.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out quantiteMinimum) &&
                            decimal.TryParse(txtCoutUni.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out coutMoyenUnitaire))
                        {
                            // Affecter les valeurs converties aux propriétés de votre objet (p)


                            // Autres actions si nécessaire


                            ProduitSet p = new ProduitSet();
                            p.nom = txtProduit.Text;
                            p.quantiteStock = quantiteStock;
                            p.quantiteMinimum = quantiteMinimum;
                            p.CoutMoyenUnitaire = coutMoyenUnitaire;
                            bd.ProduitSets.Add(p);
                            bd.SaveChanges();
                        }
                        else
                        {
                            return;
                        }
                    }
                    ProduitSet v = bd.ProduitSets
                                .Where(x => x.nom == txtProduit.Text)
                                .FirstOrDefault();
                    ProduitSet.VerifierQuantiteStock(v.Id);
                    ListeProduits_Load(sender, e);
                }
            }
        }




      

        private void txtCoutUni_Leave(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtCoutUni.Text) || string.IsNullOrEmpty(txtQuantite.Text)))
            {
                // Vérifier si les valeurs sont des décimaux valides
                if (decimal.TryParse(txtCoutUni.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal coutUni) &&
                    decimal.TryParse(txtQuantite.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal quantite))
                {
                    // Effectuer le calcul et afficher le résultat
                    txtPrixAchat.Text = (coutUni * quantite).ToString(CultureInfo.InvariantCulture);
                }
                
            }
            




        }


    }
}
