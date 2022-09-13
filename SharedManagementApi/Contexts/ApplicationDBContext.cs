using Microsoft.EntityFrameworkCore;
using SharedModels;

namespace SharedManagementApi.Contexts
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Adresse> Adresses { get; set; }
        public DbSet<CodeQR> CodeQRs { get; set; }
        public DbSet<CodeBar> CodeBars { get; set; }
    }
}
