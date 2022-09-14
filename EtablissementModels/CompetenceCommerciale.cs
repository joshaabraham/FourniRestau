namespace EtablissementModels
{
    public class CompetenceCommerciale
    {

        public Guid ID { get; set; }

        public string LangueParlees { get; set; }

        public string QteEmployeDuDepartementVente { get; set; }

        public int TempsMoyenReponse { get; set; }

        public float RevenueTotalAnnuel { get; set; }
    }
}