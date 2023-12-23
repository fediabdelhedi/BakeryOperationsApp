using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock
{
    public partial class BonsSortie
    {
        public override bool Equals(object obj)
        {
            return obj is BonsSortie sortie &&
                   Id == sortie.Id;
        }
        public override string ToString()
        {
            using (StockContainer bd = new StockContainer())
            {
                string name = (bd.Recettes.Find(RecetteId)).nom;
                return name + " | quantite produite: " + QuantiteProduite + " | date: " + Date + " | cout total: " + coutTotal;
            }
        }
    }
}
