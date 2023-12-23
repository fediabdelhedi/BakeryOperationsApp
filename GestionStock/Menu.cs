using GestionDeStock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GestionStock
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ListeProduits form1 = new ListeProduits();

            form1.ShowDialog();
            Menu_Load(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ListeProduits form1 = new ListeProduits();

            form1.ShowDialog();
            Menu_Load(sender, e);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ListeRecettes form1 = new ListeRecettes();

            form1.ShowDialog();
            Menu_Load(sender, e);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ListeRecettes form1 = new ListeRecettes();

            form1.ShowDialog();
            Menu_Load(sender, e);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            listeBonEntree form1 = new listeBonEntree();

            form1.ShowDialog();
            Menu_Load(sender, e);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            listeBonEntree form1 = new listeBonEntree();

            form1.ShowDialog();
            Menu_Load(sender, e);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ListeBonSortie form1 = new ListeBonSortie();

            form1.ShowDialog();
            Menu_Load(sender, e);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ListeBonSortie form1 = new ListeBonSortie();

            form1.ShowDialog();
            Menu_Load(sender, e);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Historique form1 = new Historique();

            form1.ShowDialog();
            Menu_Load(sender, e);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Historique form1 = new Historique();

            form1.ShowDialog();
            Menu_Load(sender, e);
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            dataGridView1.Rows.Clear();
            using (StockContainer bd = new StockContainer())
            {
                lblProduit.Text = bd.ProduitSets.Count().ToString();
                lblRecette.Text = bd.Recettes.Count().ToString();
                lblProduit.SetBounds((panel4.Width - lblProduit.Width) / 2, (panel4.Height - lblProduit.Height) / 2,lblProduit.Width, lblProduit.Height);
                lblRecette.SetBounds((panel3.Width - lblRecette.Width) / 2, (panel3.Height - lblRecette.Height) / 2, lblRecette.Width, lblRecette.Height);
                foreach (ProduitSet v in bd.ProduitSets)
                {
                    // Vérifier si la quantité de stock est inférieure ou égale à la quantité minimale
                    if (v.quantiteMinimum >= v.quantiteStock)
                    {
                        int rowIndex = dataGridView1.Rows.Add();

                        // Affecter les valeurs aux colonnes
                        dataGridView1.Rows[rowIndex].Cells["Column1"].Value = v.nom;
                        dataGridView1.Rows[rowIndex].Cells["Column2"].Value = v.quantiteStock;
                        dataGridView1.Rows[rowIndex].Cells["QuantiteMinimum"].Value = v.quantiteMinimum;

                    }
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}