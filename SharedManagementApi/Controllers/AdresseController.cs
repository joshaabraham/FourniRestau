using Microsoft.AspNetCore.Mvc;
using SharedManagementApi.Contexts;

namespace SharedManagementApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AdresseController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public AdresseController(ApplicationDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
    }
}
