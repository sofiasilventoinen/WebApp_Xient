using Microsoft.AspNetCore.Mvc;
using WebApp_Xient.DTO;
using WebApp_Xient.Models.Entities;
using WebApp_Xient.Repositories;
using WebApp_Xient.Services;

namespace WebApp_Xient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly ArticleService _articleService;

        public ArticleController(ArticleService articleService)
        {
            _articleService = articleService;
        }
        
        // Registrera artikel
        [HttpPost]
        public async Task<IActionResult> CreateAsync(ArticleRequest req)
        {
            var response = await _articleService.CreateAsync(req);
            if (response != null)
                return response!;
            else
                return NoContent();
        }

        // Ta bort Artikel
        [HttpDelete("{id}")]
        public async Task <IActionResult> RemoveArticle(int id)
        {
            var response = await _articleService.RemoveArticle(id);
            if (response != null) 
                return response!;
            else return NoContent();
        }

        // Updatera en artikel
        [HttpPut("{id}")]
        public void Update(int id, [FromBody] string value)
        {
        }

        // Hämta alla artiklar
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok (await _articleService.GetAll());
        }

        // Hämta en artikel
        [HttpGet("{id}")]
        public async Task <IActionResult> Get(int id)
        {
            var response = await _articleService.Get(id);
            if (response == null)
            { 
                return NotFound();
            }
            return Ok(response);
        }

        

        

        
    }
}
