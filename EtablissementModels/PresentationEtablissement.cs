namespace EtablissementModels
{
    public class PresentationEtablissement
    {
        public Guid PresentationEtablissementID { get; set; }

        public string TypeEtablissement { get; set; }

        public CategoriesProduitsPrincipaux CategoriesProduitsPrincipaux { get; set; }

        public float TotalRevenuAnnuel { get; set; }

        public string Certification { get; set; }

        public string PrincipauxMarches { get; set; }

        public string PaysRegion { get; set; }

        public string NombreEmployes { get; set; }

        public DateTime DateDEtablissement { get; set; }

        public string CertificationDesProduits { get; set; }
    }
}