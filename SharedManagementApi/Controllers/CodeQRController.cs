using Microsoft.AspNetCore.Mvc;
using SharedManagementApi.Contexts;

namespace SharedManagementApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CodeQRController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public CodeQRController(ApplicationDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
    }
}
