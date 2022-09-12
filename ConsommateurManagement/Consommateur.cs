using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsommateurManagement
{
    public class Consommateur
    {
        public Guid ConsommateurID { get; set; }
        public string ConsommateurName { get; set; }
        public StatisticConsommation StatisticConsommation { get;set;}
        public ProduitsRecherches ProduitsRecherches { get; set; }
        public ModeDeLivraison ModeDeLivraison { get; set; }

    }


    public enum ModeDeLivraison
    {
        a_domicile,
        point_livraison,
        au_producteur,

    }
}
