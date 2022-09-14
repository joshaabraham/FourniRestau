using AbonnementManagementAPI.Contexts;
using AbonnementModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AbonnementManagementAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AbonnementController : ControllerBase
    {
        private readonly ApplicationDBContext _context;



        public AbonnementController(ApplicationDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }


        [HttpGet]
        public async Task<ActionResult<List<Abonnement>>> Abonnements()
        {
            try
            {
                return Ok(await _context.Abonnements.ToListAsync());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Abonnement>> Get(Guid id)
        {

            try
            {
                var user = _context.Abonnements.Find(id);
                if (user == null)
                    return NotFound("No user was found.");
                return Ok(await _context.Abonnements.SingleAsync());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPost]
        public async Task<ActionResult<List<Abonnement>>> PostUser(Abonnement abonnement)
        {

            _context.Abonnements.Add(abonnement);
            _context.SaveChangesAsync();

            return Ok(await _context.Abonnements.ToListAsync());
        }


        [HttpPut]
        public async Task<ActionResult<Abonnement>> UpdateUser(Abonnement abonnement)
        {
            try
            {
                var userToUpdate = _context.Abonnements.FindAsync(abonnement.ID);
                if (userToUpdate == null)
                    return NotFound("No user was found.");

                _context.Abonnements.Remove(userToUpdate.Result);
                _context.Abonnements.Add(abonnement);
                return Ok(await _context.Abonnements.SingleAsync(x => x.ID == abonnement.ID));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpDelete]
        public async Task<ActionResult<Abonnement>> DeleteUser(Abonnement abonnement)
        {
            try
            {
                var abonnementToDelete = _context.Abonnements.Find(abonnement.ID);
                if (abonnementToDelete == null)
                    return NotFound("No user was found.");

                _context.Abonnements.Remove(abonnementToDelete);


                return Ok(await _context.Abonnements.ToListAsync());
            }
            catch (Exception)
            {

                throw;
            }


        }

    }
}
