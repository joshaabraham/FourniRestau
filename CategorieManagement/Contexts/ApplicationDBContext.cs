using CategorieModels;
using Microsoft.EntityFrameworkCore;

namespace CategorieManagement.Contexts
{
    public class ApplicationDBContext : DbContext
    {

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Metadata> Metadatas { get; set; }

    }
}
