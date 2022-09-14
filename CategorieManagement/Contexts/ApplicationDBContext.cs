using Microsoft.EntityFrameworkCore;

namespace CategorieManagement.Contexts
{
    public class ApplicationDBContext : DbContext
    {

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }



    }
}
