using Microsoft.EntityFrameworkCore;
using PanierManagement;

namespace PanierManagementApi.Contexts
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<ListDeProduitsSelectionnes> ListDeProduitsSelectionnes { get; set; }
        public DbSet<Panier> Paniers { get; set; }
        public DbSet<ListDeProduitsTotale> ListDeProduitsTotale { get; set; }
    }
}
