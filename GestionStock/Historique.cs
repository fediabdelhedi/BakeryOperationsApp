using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStock
{
    public partial class Historique : Form
    {
        public Historique()
        {
            InitializeComponent();
        }

        private void Historique_Load(object sender, EventArgs e)
        {
            using (StockContainer bd = new StockContainer())
            {
                MaximizeBox = false;
                var listeBonsEntree = bd.BonsEntrees
    .OrderByDescending(be => be.Date) // Order by Date in descending order
    .ToList();

                dgvBonEntree.AutoGenerateColumns = false;
                dgvBonEntree.Columns.Add("ProduitId", "Nom Produit");
                
                dgvBonEntree.Columns.Add("Quantite", "Quantité");
                dgvBonEntree.Columns.Add("CoutUnitaireMoyen", "Coût Unitaire Moyen");
                dgvBonEntree.Columns.Add("Date", "Date");
                dgvBonEntree.Columns.Add("Type", "Type");

                dgvBonEntree.Columns["Date"].DataPropertyName = "Date";
                dgvBonEntree.Columns["Quantite"].DataPropertyName = "Quantite";
                dgvBonEntree.Columns["CoutUnitaireMoyen"].DataPropertyName = "CoutUnitaireMoyen";
                dgvBonEntree.Columns["ProduitId"].DataPropertyName = "ProduitId";
                dgvBonEntree.Columns["Type"].DataPropertyName = "Type";
                dgvBonEntree.Columns["Type"].DefaultCellStyle.ForeColor = Color.Green;
                dgvBonEntree.CellFormatting += dgvBonEntree_CellFormatting;
                dgvBonEntree.DataSource = listeBonsEntree;
                foreach (DataGridViewRow row in dgvBonEntree.Rows)
                {
                    row.Cells["Type"].Value = "Bon Entree";
                }
                var listeBonsSortie = bd.BonsSorties
    .OrderByDescending(bs => bs.Date) // Order by Date in descending order
    .ToList();

                dataBonSortie.AutoGenerateColumns = false;
                dataBonSortie.Columns.Add("RecetteId", "Nom Recette");
                dataBonSortie.Columns.Add("QuantiteProduite", "Quantité Produite");
                dataBonSortie.Columns.Add("CoutTotal", "Coût Total");
                dataBonSortie.Columns.Add("Date", "Date");
                
                
                
                dataBonSortie.Columns.Add("Type", "Type");

                dataBonSortie.Columns["Date"].DataPropertyName = "Date";
                dataBonSortie.Columns["CoutTotal"].DataPropertyName = "coutTotal";
                dataBonSortie.Columns["RecetteId"].DataPropertyName = "RecetteId";
                dataBonSortie.Columns["QuantiteProduite"].DataPropertyName = "QuantiteProduite";
                dataBonSortie.Columns["Type"].DataPropertyName = "Type";
                dataBonSortie.Columns["Type"].DefaultCellStyle.ForeColor = Color.Red;
                dataBonSortie.CellFormatting += dataBonSortie_CellFormatting;
                dataBonSortie.DataSource = listeBonsSortie;
                foreach (DataGridViewRow row in dataBonSortie.Rows)
                {
                    row.Cells["Type"].Value = "Bon Sortie";
                }


            }
        }

        private void dgvBonEntree_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvBonEntree.Columns["ProduitId"].Index && e.RowIndex >= 0)
            {
                if (e.Value != null && int.TryParse(e.Value.ToString(), out int produitId))
                {
                    using (StockContainer bd = new StockContainer())
                    {
                        var produit = bd.ProduitSets.FirstOrDefault(p => p.Id == produitId);

                        if (produit != null)
                        {
                            e.Value = produit.nom; // Set the display value to the product name
                            e.FormattingApplied = true; // Indicate that the formatting is applied
                        }
                    }
                }
            }
        }

        private void dataBonSortie_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataBonSortie.Columns["RecetteId"].Index && e.RowIndex >= 0)
            {
                if (e.Value != null && int.TryParse(e.Value.ToString(), out int RecetteId))
                {
                    using (StockContainer bd = new StockContainer())
                    {
                        var recette = bd.Recettes.FirstOrDefault(p => p.Id == RecetteId);

                        if (recette != null)
                        {
                            e.Value = recette.nom; // Set the display value to the product name
                            e.FormattingApplied = true; // Indicate that the formatting is applied
                        }
                    }
                }
            }
        }
    }
    }

