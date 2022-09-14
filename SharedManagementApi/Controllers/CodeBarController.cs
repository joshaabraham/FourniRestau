using Microsoft.AspNetCore.Mvc;
using SharedManagementApi.Contexts;

namespace SharedManagementApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CodeBarController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public CodeBarController(ApplicationDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
    }
}
