using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock
{
    public partial class BonsEntree
    {
        public override bool Equals(object obj)
        {
            return obj is BonsEntree entree &&
                   Id == entree.Id;
        }
        public override string ToString()
        {
            using (StockContainer bd = new StockContainer())
            {
                string name = (bd.ProduitSets.Find(ProduitId)).nom;
                return name + " | quantite acheté: " + quantite + " | date: " + Date + " | cout unitaire moyen: " + CoutUnitaireMoyen;
            }
        }
    }
}
