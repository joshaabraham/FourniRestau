using Microsoft.AspNetCore.Mvc;
using webApi_course.Models;

namespace webApi_course.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private static  List<User> users = new List<User>();

        private readonly ApplicationDBContext _context;

        public UserController(ApplicationDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
                
                

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetUsers() {

            try
            {                
                return Ok(await _context.Users.ToListAsync());
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> Get(int id)
        {

            try
            {
                var user = _context.Users.Find(id);
                if (user == null)
                    return NotFound("No user was found.");
                return Ok(await _context.Users.SingleAsync());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPost]
        public async Task<ActionResult<List<User>>> PostUser(User user) { 
            
            _context.Users.Add(user);
            _context.SaveChangesAsync();

            return Ok(await _context.Users.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<User>> UpdateUser(User user) {
            try
            {
                var userToUpdate = _context.Users.FindAsync(user.UserID);
                if (userToUpdate == null)
                    return NotFound("No user was found.");

                _context.Users.Remove(userToUpdate.Result);
                _context.Users.Add(user);
                return Ok(await _context.Users.SingleAsync(x => x.UserID == user.UserID));
            }
            catch (Exception)
            {

                throw;
            }
        

        }

        [HttpDelete]
        public async Task<ActionResult<User>> DeleteUser(User user)
        {
            try
            {
                var userToDelete = _context.Users.Find(user.UserID);
                if (userToDelete == null)
                    return NotFound("No user was found.");

                _context.Users.Remove(userToDelete);


                return Ok(await _context.Users.ToListAsync());
            }
            catch (Exception ex )
            {
                throw ex;
            }

        }


    }
}
