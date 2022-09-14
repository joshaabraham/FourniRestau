using CategorieManagement.Contexts;
using CategorieModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CategorieManagement.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategorieController : ControllerBase
    {

        private readonly ApplicationDBContext _context;

        public CategorieController(ApplicationDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }



        [HttpGet]
        public async Task<ActionResult<List<Categorie>>> Categories()
        {

            try
            {
                return Ok(await _context.Categories.ToListAsync());
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Categorie>> Get(Guid id)
        {

            try
            {
                var categorie = _context.Categories.Find(id);
                if (categorie == null)
                    return NotFound("No user was found.");
                return Ok(await _context.Categories.SingleAsync());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPost]
        public async Task<ActionResult<List<Categorie>>> PostUser(Categorie categorie)
        {

            _context.Categories.Add(categorie);
            _context.SaveChangesAsync();

            return Ok(await _context.Categories.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<Categorie>> UpdateUser(Categorie categorie)
        {
            try
            {
                var categorieToUpdate = _context.Categories.FindAsync(categorie.ID);
                if (categorieToUpdate == null)
                    return NotFound("No user was found.");

                _context.Categories.Remove(categorieToUpdate.Result);
                _context.Categories.Add(categorie);
                return Ok(await _context.Categories.SingleAsync(x => x.ID == categorie.ID));
            }
            catch (Exception)
            {

                throw;
            }


        }

        [HttpDelete]
        public async Task<ActionResult<Categorie>> DeleteUser(Categorie categorie)
        {
            try
            {
                var categorieToDelete = _context.Categories.Find(categorie.ID);
                if (categorieToDelete == null)
                    return NotFound("No user was found.");

                _context.Categories.Remove(categorieToDelete);


                return Ok(await _context.Categories.ToListAsync());
            }
            catch (Exception)
            {

                throw;
            }


        }

    }
}
