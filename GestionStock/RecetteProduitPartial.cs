using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock
{
    public partial class RecetteProduit
    {
        public override bool Equals(object obj)
        {
            return obj is RecetteProduit produit &&
                   Id == produit.Id;
        }
        public override string ToString()
        {
            using (StockContainer bd = new StockContainer())
            {
                string name = (bd.ProduitSets.Find(ProduitId)).nom;
                return name + " | quantite utilisé: " + Quantite;
            }
        }
    }
}
