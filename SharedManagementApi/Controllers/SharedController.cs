using Microsoft.AspNetCore.Mvc;
using SharedManagementApi.Contexts;

namespace SharedManagementApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SharedController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public SharedController(ApplicationDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
    }
}
