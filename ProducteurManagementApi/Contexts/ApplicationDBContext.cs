using Microsoft.EntityFrameworkCore;
using ProducteurManagement;

namespace ProducteurManagementApi.Contexts
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Articles> Articles { get; set; }
        public DbSet<PhotoProfile> PhotoProfiles { get; set; }
        public DbSet<Producteur> Producteurs { get; set; }
        public DbSet<Production> Productions { get; set; }
    }
}
