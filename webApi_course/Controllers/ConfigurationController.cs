using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace webApi_course.Controllers
{

    [Route("[controller]/api")]
    [ApiController]
    public class ConfigurationController : ControllerBase
    {
        string _urlConfigurationManagement;

        public ConfigurationController()
        {
            _urlConfigurationManagement = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("ManagersURLS")["ConfigurationManagementConnectionString"];
        }


        [HttpGet]
        public async Task GetConfiguration()
        {
            
         

        }

    }
}
