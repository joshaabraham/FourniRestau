using ArticleManagementService.Contexts;
using ArticlesModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ArticleManagementService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly ApplicationDBContext _context;



        public ArticleController(ApplicationDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }


        [HttpGet]
        public async Task<ActionResult<List<Article>>> Articles()
        {
            try
            {
                return Ok(await _context.Articles.ToListAsync());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Article>> Get(Guid id)
        {

            try
            {
                var user = _context.Articles.Find(id);
                if (user == null)
                    return NotFound("No user was found.");
                return Ok(await _context.Articles.SingleAsync());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPost]
        public async Task<ActionResult<List<Article>>> PostUser(Article article)
        {

            _context.Articles.Add(article);
            _context.SaveChangesAsync();

            return Ok(await _context.Articles.ToListAsync());
        }


        [HttpPut]
        public async Task<ActionResult<Article>> UpdateUser(Article article)
        {
            try
            {
                var articleToUpdate = _context.Articles.FindAsync(article.ID);
                if (articleToUpdate == null)
                    return NotFound("No user was found.");

                _context.Articles.Remove(articleToUpdate.Result);
                _context.Articles.Add(article);
                return Ok(await _context.Articles.SingleAsync(x => x.ID == article.ID));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpDelete]
        public async Task<ActionResult<Article>> DeleteUser(Article article)
        {
            try
            {
                var abonnementToDelete = _context.Articles.Find(article.ID);
                if (abonnementToDelete == null)
                    return NotFound("No user was found.");

                _context.Articles.Remove(abonnementToDelete);


                return Ok(await _context.Articles.ToListAsync());
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

    }
}
