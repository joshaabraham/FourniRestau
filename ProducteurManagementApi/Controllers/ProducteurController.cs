using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProducteurManagement;
using ProducteurManagementApi.Contexts;

namespace ProducteurManagementApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProducteurController : ControllerBase
    {

        private readonly ApplicationDBContext _context;

        public ProducteurController(ApplicationDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        [HttpGet]
        public async Task<ActionResult<List<Producteur>>> Producteurs()
        {

            try
            {
                return Ok(await _context.Producteurs.ToListAsync());
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Producteur>> Get(Guid id)
        {

            try
            {
                var producteur = _context.Producteurs.Find(id);
                if (producteur == null)
                    return NotFound("No user was found.");
                return Ok(await _context.Producteurs.SingleAsync());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPost]
        public async Task<ActionResult<List<Producteur>>> PostUser(Producteur producteur)
        {

            _context.Producteurs.Add(producteur);
            _context.SaveChangesAsync();

            return Ok(await _context.Producteurs.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<Producteur>> UpdateUser(Producteur producteur)
        {
            try
            {
                var producteurToUpdate = _context.Producteurs.FindAsync(producteur.ID);
                if (producteurToUpdate == null)
                    return NotFound("No user was found.");

                _context.Producteurs.Remove(producteurToUpdate.Result);
                _context.Producteurs.Add(producteur);
                return Ok(await _context.Producteurs.SingleAsync(x => x.ID == producteur.ID));
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        [HttpDelete]
        public async Task<ActionResult<Producteur>> DeleteUser(Producteur producteur)
        {
            try
            {
                var producteurToDelete = _context.Producteurs.Find(producteur.ID);
                if (producteurToDelete == null)
                    return NotFound("No user was found.");

                _context.Producteurs.Remove(producteurToDelete);


                return Ok(await _context.Producteurs.ToListAsync());
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}
