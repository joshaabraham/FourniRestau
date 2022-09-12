using Microsoft.EntityFrameworkCore;
using webApi_course.Models;

namespace webApi_course.Contexts
{
    public class ApplicationDBContext : DbContext
    {

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
  
    }
}
