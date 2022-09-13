using ArticlesModels;
using Microsoft.EntityFrameworkCore;

namespace ArticleManagementService.Contexts
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<MetaData> MetaDatas { get; set; }
    }
}
