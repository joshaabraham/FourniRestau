using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationModels
{
    public class Configuration
    {
        public Guid ConfigurationId { get; set; }
        public ConfigurationProfil ConfigurationProfil { get; set; }
        public ConfigurationCommerciale ConfigurationCommerciale { get; set; }
        public ConfigurationPagePresentoire ConfigurationPagePresentoire { get; set; }
        public ConfigurationCompte ConfigurationCompte { get; set; }
        public ConfigurationAlertes ConfigurationAlertes { get; set; } 
        public ConfigurationPublicitees ConfigurationPublicitees { get; set; }
        public ConfigurationRecherche ConfigurationRecherche { get; set; }


    }
}
