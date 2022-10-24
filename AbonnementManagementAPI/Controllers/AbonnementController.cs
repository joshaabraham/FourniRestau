using AbonnementManagementAPI.Contexts;
using AbonnementModels;
using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SharedModels.RabbitMqModel;

namespace AbonnementManagementAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AbonnementController : ControllerBase
    {

        private readonly IPublishEndpoint _publishEndpoint;
        private readonly ApplicationDBContext _context;



        public AbonnementController(ApplicationDBContext context, IPublishEndpoint publishEndpoint)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _publishEndpoint = publishEndpoint ?? throw new ArgumentNullException(nameof(publishEndpoint));
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
            await _context.SaveChangesAsync();

            await _publishEndpoint.Publish<AbonnementCreated>(new AbonnementCreated
            {
                ID = abonnement.ID,
                AbonnementName = abonnement.AbonnementName
            });

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
