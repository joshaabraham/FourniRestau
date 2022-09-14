using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementModels
{
    public class Abonnement
    {
        public Guid ID { get; set; }

        public string AbonnementName { get; set; }

        public PeriodeLivraison PeriodePaiement { get; set; }

        public PeriodeLivraison PeriodeLivraison { get; set; }

        public bool RepetitionAutomatique { get; set; }


    }


    public enum PeriodePaiement
    {
        quotidien,
        hebdomadaire,
        mensuel,
        trimestriel,
        semestriel,
        annuel

    }

    public enum PeriodeLivraison
    {
        quotidien,
        hebdomadaire,
        mensuel,
        trimestriel,
        semestriel,
        annuel
    }
}
