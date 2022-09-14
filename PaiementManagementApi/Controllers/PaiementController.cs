using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaiementManagement;
using PaiementManagementApi.Contexts;

namespace PaiementManagementApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PaiementController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public PaiementController(ApplicationDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        [HttpGet]
        public async Task<ActionResult<List<Paiement>>> Paiements()
        {

            try
            {
                return Ok(await _context.Paiements.ToListAsync());
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Paiement>> Get(Guid id)
        {

            try
            {
                var paiement = _context.Paiements.Find(id);
                if (paiement == null)
                    return NotFound("No user was found.");
                return Ok(await _context.Paiements.SingleAsync());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPost]
        public async Task<ActionResult<List<Paiement>>> PostUser(Paiement paiement)
        {

            _context.Paiements.Add(paiement);
            _context.SaveChangesAsync();

            return Ok(await _context.Paiements.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<Paiement>> UpdateUser(Paiement paiement)
        {
            try
            {
                var paiementToUpdate = _context.Paiements.FindAsync(paiement.ID);
                if (paiementToUpdate == null)
                    return NotFound("No user was found.");

                _context.Paiements.Remove(paiementToUpdate.Result);
                _context.Paiements.Add(paiement);
                return Ok(await _context.Paiements.SingleAsync(x => x.ID == paiement.ID));
            }
            catch (Exception)
            {

                throw;
            }


        }

        [HttpDelete]
        public async Task<ActionResult<Paiement>> DeleteUser(Paiement paiement)
        {
            try
            {
                var paiementToDelete = _context.Paiements.Find(paiement.ID);
                if (paiementToDelete == null)
                    return NotFound("No user was found.");

                _context.Paiements.Remove(paiementToDelete);


                return Ok(await _context.Paiements.ToListAsync());
            }
            catch (Exception)
            {

                throw;
            }


        }


    }
}
