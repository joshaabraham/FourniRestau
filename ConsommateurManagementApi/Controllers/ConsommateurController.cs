using ConsommateurManagement;
using ConsommateurManagementApi.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ConsommateurManagementApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ConsommateurController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public ConsommateurController(ApplicationDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        [HttpGet]
        public async Task<ActionResult<List<Consommateur>>> GetConsommateurs()
        {

            try
            {
                return Ok(await _context.Consommateurs.ToListAsync());
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Consommateur>> Get(Guid id)
        {

            try
            {
                var consommateur = _context.Consommateurs.Find(id);
                if (consommateur == null)
                    return NotFound("No user was found.");
                return Ok(await _context.Consommateurs.SingleAsync());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPost]
        public async Task<ActionResult<List<Consommateur>>> PostUser(Consommateur consommateur)
        {

            _context.Consommateurs.Add(consommateur);
            _context.SaveChangesAsync();

            return Ok(await _context.Consommateurs.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<Consommateur>> UpdateUser(Consommateur consommateur)
        {
            try
            {
                var consommateurToUpdate = _context.Consommateurs.FindAsync(consommateur.ID);
                if (consommateurToUpdate == null)
                    return NotFound("No user was found.");

                _context.Consommateurs.Remove(consommateurToUpdate.Result);
                _context.Consommateurs.Add(consommateur);
                return Ok(await _context.Consommateurs.SingleAsync(x => x.ID == consommateur.ID));
            }
            catch (Exception)
            {

                throw;
            }


        }

        [HttpDelete]
        public async Task<ActionResult<Consommateur>> DeleteUser(Consommateur consommateur)
        {
            try
            {
                var consommateurToDelete = _context.Consommateurs.Find(consommateur.ID);
                if (consommateurToDelete == null)
                    return NotFound("No user was found.");

                _context.Consommateurs.Remove(consommateurToDelete);


                return Ok(await _context.Consommateurs.ToListAsync());
            }
            catch (Exception)
            {

                throw;
            }


        }


    }
}
