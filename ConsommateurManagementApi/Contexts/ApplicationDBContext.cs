using ConsommateurManagement;
using Microsoft.EntityFrameworkCore;

namespace ConsommateurManagementApi.Contexts
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Consommateur> Consommateurs { get; set; }
        public DbSet<ProduitsRecherches> ProduitsRecherches { get; set; }

        public DbSet<StatisticConsommation> StatisticConsommation { get; set; }
    }
}
