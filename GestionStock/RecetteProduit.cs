//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionStock
{
    using System;
    using System.Collections.Generic;
    
    public partial class RecetteProduit
    {
        public int Id { get; set; }
        public Nullable<decimal> Quantite { get; set; }
        public int ProduitId { get; set; }
        public int RecetteId { get; set; }
    }
}
