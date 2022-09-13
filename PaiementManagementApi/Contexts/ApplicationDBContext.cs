using Microsoft.EntityFrameworkCore;
using PaiementManagement;

namespace PaiementManagementApi.Contexts
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<AccountReceiver> AccountReceiver { get; set; }
        public DbSet<AccountSender> AccountSender { get; set; }
        public DbSet<Paiement> Paiements { get; set; }
    }
}
