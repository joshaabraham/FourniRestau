using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanierManagement
{
    public class Panier
    {
        public Guid ID { get; set; }
        public float Total { get; set; }

        public ListDeProduitsSelectionnes ListDeProduitsSelectionnes { get; set; } 
        public ListDeProduitsTotale ListDeProduitsTotale { get; set; }


    }
}
