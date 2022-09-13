using EtablissementModels;
using Microsoft.EntityFrameworkCore;

namespace EtablissementManagementApi.Contexts
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Adresse> Adresses { get; set; }
        public DbSet<AlbumPhotos> AlbumPhotos { get; set; }
        public DbSet<Articles> Articles { get; set; }
        public DbSet<CapaciteDeProduction> CapaciteDeProductions { get; set; }
        public DbSet<CategoriesProduitsPrincipaux> CategoriesProduitsPrincipaux { get; set; }
        public DbSet<CompetenceCommerciale> CompetenceCommerciales { get; set; }
        public DbSet<Etablissement> Etablissements { get; set; }
        public DbSet<PresentationEquipe> PresentationEquipes { get; set; }
        public DbSet<PresentationProduction> PresentationProduction { get; set; }
        public DbSet<ProfilCommercial> ProfilCommercial { get; set; }

        public DbSet<TermsAffaires> TermsAffaires { get; set; }

    }
}
