namespace EtablissementModels
{
    public class ProfilCommercial
    {
        public Guid ProfilCommercialID { get; set; }

        public CompetenceCommerciale CompetenceCommerciale { get; set; }

        public TermsAffaires TermsAffaires { get; set; }

    }
}