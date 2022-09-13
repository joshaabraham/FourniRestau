using Microsoft.EntityFrameworkCore;

namespace EtablissementManagementApi.Contexts
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
    }
}
