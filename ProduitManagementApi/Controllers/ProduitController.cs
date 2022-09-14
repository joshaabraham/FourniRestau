using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProduitManagementApi.Contexts;
using ProduitModels;

namespace ProduitManagementApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProduitController : ControllerBase
    {

        private readonly ApplicationDBContext _context;

        public ProduitController(ApplicationDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }


        [HttpGet]
        public async Task<ActionResult<List<Produit>>> Produits()
        {

            try
            {
                return Ok(await _context.Produits.ToListAsync());
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Produit>> Get(Guid id)
        {

            try
            {
                var produit = _context.Produits.Find(id);
                if (produit == null)
                    return NotFound("No user was found.");
                return Ok(await _context.Produits.SingleAsync());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPost]
        public async Task<ActionResult<List<Produit>>> PostProduit(Produit produit)
        {

            _context.Produits.Add(produit);
            _context.SaveChangesAsync();

            return Ok(await _context.Produits.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<Produit>> UpdateUser(Produit produit)
        {
            try
            {
                var produitToUpdate = _context.Produits.FindAsync(produit.ID);
                if (produitToUpdate == null)
                    return NotFound("No user was found.");

                _context.Produits.Remove(produitToUpdate.Result);
                _context.Produits.Add(produit);
                return Ok(await _context.Produits.SingleAsync(x => x.ID == produit.ID));
            }
            catch (Exception)
            {

                throw;
            }


        }

        [HttpDelete]
        public async Task<ActionResult<Produit>> DeleteUser(Produit produit)
        {
            try
            {
                var produitToDelete = _context.Produits.Find(produit.ID);
                if (produitToDelete == null)
                    return NotFound("No user was found.");

                _context.Produits.Remove(produitToDelete);


                return Ok(await _context.Produits.ToListAsync());
            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}
