using GestionStock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionDeStock
{
    public partial class ListeRecettes : Form
    {
        public ListeRecettes()
        {
            InitializeComponent();
        }

        private void ListeRecettes_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            using (StockContainer bd = new StockContainer())

            {
                cbProduit.Items.Clear();
                btnSuppPro.Enabled = false;
                btnSupprimer.Enabled = false;
                lstProduits.Items.Clear();
                lstRecette.Items.Clear();
                txtRecette.Text = "";
                txtQuantiteProduite.Text = "";
                cbProduit.SelectedIndex = -1;
                txtQuantiteProduit.Text = "";
                cbProduit.Items.AddRange(bd.ProduitSets.ToArray());
                cbProduit.DisplayMember = "nom";
                lstRecette.Items.AddRange(bd.Recettes.ToArray());

                


            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstRecette_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (StockContainer bd = new StockContainer())
            {
                if (lstRecette.SelectedItem != null)
                {
                    Recette c = (Recette)lstRecette.SelectedItem;
                    btnSupprimer.Enabled = true;

                    txtRecette.Text = c.nom;
                    txtQuantiteProduite.Text = c.QuantiteProduite.ToString();
                    cbProduit.SelectedIndex = -1;
                    txtQuantiteProduit.Text = "";
                    lstProduits.Items.Clear();
                    
                    foreach (RecetteProduit v in bd.RecetteProduits)
                    {

                        if (v.RecetteId.Equals(c.Id))
                        {


                            lstProduits.Items.Add(v);

                        }
                    }

                }
            }

        }

        private void lstProduits_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (StockContainer bd = new StockContainer())
            {
                if (lstProduits.SelectedItem != null)
                {

                    RecetteProduit c = (RecetteProduit)lstProduits.SelectedItem;


                    btnSupprimer.Enabled = true;



                    

                    btnSuppPro.Enabled = true;
                    cbProduit.SelectedItem = -1;

                    txtQuantiteProduit.Text = "";
                    cbProduit.SelectedItem = bd.ProduitSets.Find(c.ProduitId);

                    txtQuantiteProduit.Text = c.Quantite.ToString();

                }
            }
        }

        private void btnAjoutProduit_Click(object sender, EventArgs e)
        {
            decimal quantite;
            if (cbProduit.SelectedIndex == -1 ||
                (!decimal.TryParse(txtQuantiteProduit.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out quantite) || quantite <= 0))
            {
                
                
                MessageBox.Show("Veuillez sélectionner un produit et saisir une quantité valide.");
            }

            else
            {
                RecetteProduit c = new RecetteProduit ();
                c.ProduitId = ((ProduitSet)cbProduit.SelectedItem).Id;
                
                c.Quantite = quantite;

                // Vérifier si le produit n'est pas déjà dans la ListBox
                if (!ProduitDejaPresentDansListBox(c.ProduitId, lstProduits))
                {
                    // Le produit n'est pas déjà dans la ListBox, vous pouvez l'ajouter

                    lstProduits.Items.Add(c);
                    cbProduit.SelectedIndex = -1;
                    txtQuantiteProduit.Text = "";
                   
                }
                else
                {
                    if (txtQuantiteProduit != null && txtQuantiteProduit.Text != "")
                    {
                        c = (RecetteProduit)lstProduits.SelectedItem;
                      
                        if (c != null)
                        {
                            

                            if (decimal.TryParse(txtQuantiteProduit.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out quantite))
                            {
                                c.Quantite = quantite;
                                lstProduits.Items[lstProduits.SelectedIndex] = c;
                                cbProduit.SelectedIndex = -1;
                                txtQuantiteProduit.Text = "";
                            }
                        }
                    }
                }
            }
        }

        // ...

        private bool ProduitDejaPresentDansListBox(int produit, ListBox listBox)
        {
            foreach (RecetteProduit item in listBox.Items)
            {
                
               
                if (item.ProduitId.Equals(produit))
                {
                    return true; // Le produit est déjà dans la ListBox
                }
            }

            return false; // Le produit n'est pas dans la ListBox
        }

        private void btnSuppPro_Click(object sender, EventArgs e)
        {
            RecetteProduit c = (RecetteProduit)lstProduits.SelectedItem;
            lstProduits.Items.Remove(c);
            cbProduit.SelectedIndex = -1;
            txtQuantiteProduit.Text = "";
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            using (StockContainer bd = new StockContainer())
            {
                if (txtRecette.Text == "" || txtQuantiteProduite.Text == "" || lstProduits.Items.Count == 0 || !(int.TryParse(txtQuantiteProduite.Text, out int quantitem) || quantitem < 0))
                {
                    MessageBox.Show("verifier les champs vides");
                }
                else
                {
                    int x = 0;
                    Recette c = new Recette();
                    c.nom = txtRecette.Text;
                    c.QuantiteProduite = Convert.ToInt32(txtQuantiteProduite.Text);
                    
                    
                    foreach (Recette v in bd.Recettes)
                    {
                        if (v.nom.Equals(c.nom))
                        {

                            v.nom = c.nom;
                            v.QuantiteProduite = c.QuantiteProduite;
                            
                            x = 1;
                            break;
                        }

                    }
                    
                    if (x == 0)
                    {
                        bd.Recettes.Add(c);
                        
                    }
                    bd.SaveChanges();
                    c = bd.Recettes.Where(a => a.nom == c.nom).FirstOrDefault();
                    foreach (RecetteProduit h in lstProduits.Items)
                    {
                        h.RecetteId = c.Id;
                    }
                    foreach (RecetteProduit v in bd.RecetteProduits)
                    {
                        if (v.RecetteId.Equals(c.Id))
                        {
                            bd.RecetteProduits.Remove(v);
                            
                        }
                    }
                    bd.SaveChanges();
                    foreach (RecetteProduit item in lstProduits.Items)
                    {
                        bd.RecetteProduits.Add(item);//au niveau de cette ligne réside le problème

                    }
                    bd.SaveChanges();
                  
                    ListeRecettes_Load(sender, e);
                }

            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("vous êtes sur ?", "attention", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                int x = 0;
                using (StockContainer bd = new StockContainer())
                {
                    if (lstRecette.SelectedItem != null)
                    {
                        Recette c = (Recette)lstRecette.SelectedItem;
                        
                           
                            foreach (BonsSortie v in bd.BonsSorties)
                            {
                                if (v.RecetteId.Equals(c.Id))
                                {
                                    x = 1;
                                    MessageBox.Show("impossible , cet recette deja utilisé dans un bon de sortie! ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    break;

                                }
                            }
                        if (x == 0)
                        {
                            foreach (RecetteProduit v in bd.RecetteProduits)
                            {
                                if (v.RecetteId.Equals(c.Id))
                                {
                                    bd.RecetteProduits.Remove(v);
                                }
                            }
                            c = bd.Recettes.Where(y => y.Id == c.Id).FirstOrDefault();
                            bd.Recettes.Remove(c);
                            bd.SaveChanges();
                            ListeRecettes_Load(sender, e);
                        }
                    }


                }
            }
        }

       
    }
}