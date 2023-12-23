using GestionDeStock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStock
{
    public partial class listeBonEntree : Form
    {
        public listeBonEntree()
        {
            InitializeComponent();
        }

        private void listeBonEntree_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            using (StockContainer bd = new StockContainer())

            {
                cbProduit.SelectedIndex = -1;
                cbProduit.Items.Clear();
                lstBonEntree.Items.Clear();
                txtPrixAchat.Text = "";
                
                txtQuantite.Text = "";
                
                txtCoutUni.Text = "";
                cbProduit.Items.AddRange(bd.ProduitSets.ToArray());
                cbProduit.DisplayMember = "nom";

                lstBonEntree.Items.AddRange(bd.BonsEntrees.ToArray());




            }
        }

       

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int tesst = 1;
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (cbProduit.SelectedIndex==-1 || txtQuantite.Text == "" ||
            txtCoutUni.Text == "") { 
                MessageBox.Show("Veuillez remplir tous les champs.");
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
                
                using (StockContainer bd = new StockContainer())
                {
                    decimal quantiteStock, quantiteMinimum, coutMoyenUnitaire;
                    BonsEntree p = new BonsEntree();
                    // Vérifier si les valeurs sont des décimaux valides
                    if (decimal.TryParse(txtQuantite.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out quantiteStock) &&
                        decimal.TryParse(txtCoutUni.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out coutMoyenUnitaire))
                    {
                        // Affecter les valeurs converties aux propriétés de votre objet (p)


                        // Autres actions si nécessaire


                        
                        p.ProduitId = ((ProduitSet)cbProduit.SelectedItem).Id;
                        p.Date = DateTime.Now;
                        p.quantite = quantiteStock;
                       
                        p.CoutUnitaireMoyen = coutMoyenUnitaire;
                        bd.SaveChanges();
                        bd.BonsEntrees.Add(p);
                        bd.SaveChanges();
                    }

                    else
                    {
                        return;
                    }
                    
                        
                       
                        
                       
                    ProduitSet pr=bd.ProduitSets.Find(p.ProduitId);


                    decimal cout = (decimal)(((pr.quantiteStock * pr.CoutMoyenUnitaire) + (p.quantite * p.CoutUnitaireMoyen)) / (p.quantite + pr.quantiteStock));

                    pr.quantiteStock += p.quantite;
                    pr.CoutMoyenUnitaire = cout;
                    tesst = 1;
                    bd.SaveChanges();
                    


                    listeBonEntree_Load(sender, e);

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
