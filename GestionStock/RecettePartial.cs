using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock
{
    public partial class Recette
    {
        public override bool Equals(object obj)
        {
            return obj is Recette recette &&
                   Id == recette.Id;
        }

        public override string ToString()
        {
            return nom + " | quantite produite" + QuantiteProduite;
        }
    }
}
