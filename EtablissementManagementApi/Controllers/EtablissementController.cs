using EtablissementManagementApi.Contexts;
using EtablissementModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EtablissementManagementApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EtablissementController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public EtablissementController(ApplicationDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        [HttpGet]
        public async Task<ActionResult<List<Etablissement>>> GetEtablissements()
        {

            try
            {
                return Ok(await _context.Etablissements.ToListAsync());
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Etablissement>> Get(Guid id)
        {

            try
            {
                var user = _context.Etablissements.Find(id);
                if (user == null)
                    return NotFound("No user was found.");
                return Ok(await _context.Etablissements.SingleAsync());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPost]
        public async Task<ActionResult<List<Etablissement>>> PostUser(Etablissement etablissement)
        {

            _context.Etablissements.Add(etablissement);
            _context.SaveChangesAsync();

            return Ok(await _context.Etablissements.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<Etablissement>> UpdateUser(Etablissement etablissement)
        {
            try
            {
                var etablissementToUpdate = _context.Etablissements.FindAsync(etablissement.ID);
                if (etablissementToUpdate == null)
                    return NotFound("No user was found.");

                _context.Etablissements.Remove(etablissementToUpdate.Result);
                _context.Etablissements.Add(etablissement);
                return Ok(await _context.Etablissements.SingleAsync(x => x.ID == etablissement.ID));
            }
            catch (Exception)
            {

                throw;
            }


        }

        [HttpDelete]
        public async Task<ActionResult<Etablissement>> DeleteUser(Etablissement etablissement)
        {
            try
            {
                var etablissementToDelete = _context.Etablissements.Find(etablissement.ID);
                if (etablissementToDelete == null)
                    return NotFound("No user was found.");

                _context.Etablissements.Remove(etablissementToDelete);


                return Ok(await _context.Etablissements.ToListAsync());
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
