using ConfigurationManagement.Contexts;
using ConfigurationModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ConfigurationManagement.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ConfigurationController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public ConfigurationController(ApplicationDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        [HttpGet]
        public async Task<ActionResult<List<Configuration>>> GetUsers()
        {

            try
            {
                return Ok(await _context.Configurations.ToListAsync());
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Configuration>> Get(Guid id)
        {

            try
            {
                var configuration = _context.Configurations.Find(id);
                if (configuration == null)
                    return NotFound("No user was found.");
                return Ok(await _context.Configurations.SingleAsync());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPost]
        public async Task<ActionResult<List<Configuration>>> PostUser(Configuration configuration)
        {

            _context.Configurations.Add(configuration);
            _context.SaveChangesAsync();

            return Ok(await _context.Configurations.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<Configuration>> UpdateUser(Configuration configuration)
        {
            try
            {
                var configurationToUpdate = _context.Configurations.FindAsync(configuration.ID);
                if (configurationToUpdate == null)
                    return NotFound("No user was found.");

                _context.Configurations.Remove(configurationToUpdate.Result);
                _context.Configurations.Add(configuration);
                return Ok(await _context.Configurations.SingleAsync(x => x.ID == configuration.ID));
            }
            catch (Exception)
            {

                throw;
            }


        }

        [HttpDelete]
        public async Task<ActionResult<Configuration>> DeleteUser(Configuration configuration)
        {
            try
            {
                var configurationToDelete = _context.Configurations.Find(configuration.ID);
                if (configurationToDelete == null)
                    return NotFound("No user was found.");

                _context.Configurations.Remove(configurationToDelete);


                return Ok(await _context.Configurations.ToListAsync());
            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}
