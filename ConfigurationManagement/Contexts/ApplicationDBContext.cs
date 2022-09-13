using ConfigurationModels;
using Microsoft.EntityFrameworkCore;

namespace ConfigurationManagement.Contexts
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Configuration> Configurations { get; set; }
        public DbSet<ConfigurationAlertes> ConfigurationAlertes { get; set; }
        public DbSet<ConfigurationCommerciale> ConfigurationCommerciales { get; set; }
        public DbSet<ConfigurationCompte> ConfigurationComptes { get; set; }
        public DbSet<ConfigurationPagePresentoire> ConfigurationPagePresentoires { get; set; }
        public DbSet<ConfigurationProfil> ConfigurationProfils { get; set; }
        public DbSet<ConfigurationPublicitees> ConfigurationPublicitees { get; set; }
        public DbSet<ConfigurationRecherche> ConfigurationRecherches { get; set; }
    }
}
