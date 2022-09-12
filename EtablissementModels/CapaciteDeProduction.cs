namespace EtablissementModels
{
    public class CapaciteDeProduction
    {
        public Guid CapaciteDeProductionId { get; set; }
        public string TailleExploitation { get; set; }

        public string PaysRegionExploitation { get; set; }

        public int NbLigneDeProduction { get; set; }

        public string ContractProduction { get; set; }

        public  string ChiffreAffaireAnnuel { get; set; }
    }
}