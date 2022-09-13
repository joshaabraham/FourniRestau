using Microsoft.EntityFrameworkCore;
using ProduitModels;

namespace ProduitManagementApi.Contexts
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Categories> Categories { get; set; }
        public DbSet<FAQ> FAQs { get; set; }
        public DbSet<ProductPhotos> ProductPhotos { get; set; }
        public DbSet<Produit> Produits { get; set; }
        public DbSet<ProduitAvantages> ProduitAvantages { get; set; }
        public DbSet<ProduitCertification> ProduitCertifications { get; set; }
        public DbSet<ProduitDescription> ProduitDescriptions { get; set; }

        public DbSet<ProduitExposition> ProduitExpositions { get; set; }
        public DbSet<ProduitLivraison> ProduitLivraisons { get; set; }
    }
}
