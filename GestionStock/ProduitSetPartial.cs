using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStock
{
    public partial class ProduitSet
    {
        public override string ToString()
        {
            return nom + " | quantite stock: " + quantiteStock ;
        }
        public override bool Equals(object obj)
        {
            return obj is ProduitSet set &&
                   Id == set.Id;
        }
        public static void VerifierQuantiteStock(int id)
        {
            using (StockContainer bd = new StockContainer())
            {
                
                ProduitSet v=bd.ProduitSets.Find(id);
                    // Vérifier si la quantité de stock est inférieure ou égale à la quantité minimale
                    if (v.quantiteMinimum >= v.quantiteStock  )
                    {
                        // Afficher une boîte de message
                        MessageBox.Show("Pour le produit "+v.nom+" la quantité de stock: "+v.quantiteStock+" est inférieure ou égale à la quantité minimale: "+v.quantiteMinimum,
                            "Alerte de Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                
            }
        }
    }
}
