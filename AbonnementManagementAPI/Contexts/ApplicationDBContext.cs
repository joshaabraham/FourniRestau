using AbonnementModels;
using Microsoft.EntityFrameworkCore;

namespace AbonnementManagementAPI.Contexts
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Abonnement> Abonnements { get; set; }
    }
}
