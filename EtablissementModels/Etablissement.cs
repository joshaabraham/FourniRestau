using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtablissementModels
{
    public class Etablissement
    {
        public Guid EtablissementID { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public Adresse Adresse { get; set; }
        public AlbumPhotos AlbumPhotos { get; set; }
        public Articles Articles { get; set; }
        public string WebsiteAdresse { get; set; }
        public PresentationProduction PresentationProduction { get; set; }
        public PresentationEquipe PresentationEquipe { get; set; }
        public PresentationEtablissement PresentationEtablissement { get; set; }
        public CapaciteDeProduction CapaciteDeProduction { get; set; }
        public ProfilCommercial ProfilCommercial { get; set; }
    }
}
