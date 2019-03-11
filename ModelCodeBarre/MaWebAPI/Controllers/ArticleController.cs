using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MaWebAPI.Contexts;
using Model;

namespace MaWebAPI.Controllers
{
    [Route("api/[controller]")] //[controller] => prend le nom de la classe sans "Context" (ici "Article" car "ArticleContext")
    [ApiController]
    public class ArticleController : Controller
    {
        private readonly ArticleContext articleContext;

        public ArticleController(ArticleContext _articleContext) //constructeur => s'execute a chaque nouvelle requette HTTP
        {
            articleContext = new ArticleContext();
            articleContext.Database.EnsureCreated();
        }


        /********************************************/
        /******************* GET ********************/
        /********************************************/

        [HttpGet("{id}")] // api/article/{id}
        public Article GetID(int id)
        {
            return articleContext.ArticleItems.SingleOrDefault(art => art.Id == id);
        }


        [HttpGet("all")] // api/article/all
        public async Task<ActionResult<IEnumerable<Article>>> GetAll() // type ActionResult<T> => ASP.NET Core sérialise automatiquement l’objet en JSON et écrit le JSON dans le corps du message de réponse
        {
            return await articleContext.ArticleItems.ToListAsync();
        }

        [HttpGet("byname")] // api/article/byname
        public Article GetByName(string name)
        {
            return articleContext.ArticleItems.SingleOrDefault(art => art.Nom == name);
        }


        /********************************************/
        /****************** POST ********************/
        /********************************************/

        [HttpPost("add")] // api/article/add 
        public async Task<ActionResult<Article>> PostArticle(Article item)
        {
            articleContext.ArticleItems.Add(item);
            await articleContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetID), new { id = item.Id }, item);
        }
    }
}
