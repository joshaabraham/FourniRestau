using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PanierManagement;
using PanierManagementApi.Contexts;

namespace PanierManagementApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PanierController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public PanierController(ApplicationDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        [HttpGet]
        public async Task<ActionResult<List<Panier>>> Paniers()
        {

            try
            {
                return Ok(await _context.Paniers.ToListAsync());
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Panier>> Get(Guid id)
        {

            try
            {
                var panier = _context.Paniers.Find(id);
                if (panier == null)
                    return NotFound("No user was found.");
                return Ok(await _context.Paniers.SingleAsync());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPost]
        public async Task<ActionResult<List<Panier>>> PostUser(Panier panier)
        {

            _context.Paniers.Add(panier);
            _context.SaveChangesAsync();

            return Ok(await _context.Paniers.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<Panier>> UpdateUser(Panier panier)
        {
            try
            {
                var panierToUpdate = _context.Paniers.FindAsync(panier.ID);
                if (panierToUpdate == null)
                    return NotFound("No user was found.");

                _context.Paniers.Remove(panierToUpdate.Result);
                _context.Paniers.Add(panier);
                return Ok(await _context.Paniers.SingleAsync(x => x.ID == panier.ID));
            }
            catch (Exception)
            {

                throw;
            }


        }

        [HttpDelete]
        public async Task<ActionResult<Panier>> DeleteUser(Panier panier)
        {
            try
            {
                var panierToDelete = _context.Paniers.Find(panier.ID);
                if (panierToDelete == null)
                    return NotFound("No user was found.");

                _context.Paniers.Remove(panierToDelete);


                return Ok(await _context.Paniers.ToListAsync());
            }
            catch (Exception)
            {

                throw;
            }


        }


    }
}
