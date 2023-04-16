using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WebApp_Xient.Contexts;
using WebApp_Xient.Factories;
using WebApp_Xient.Models.Entities;

namespace WebApp_Xient.Repositories;

public class ArticleRepository
{
    private readonly ArticleContext _context;

    public ArticleRepository(ArticleContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> CreateAsync(ArticleEntity entity)
    {
        try
        {
            _context.Articles.Add(entity);
            await _context.SaveChangesAsync();
            return ActionResultFactory.CreateOkResult();
        }
        catch 
        {
            return null!;
        }
    }

    public async Task <IActionResult> RemoveArticle(int id)
    {
        var article = _context.Articles.FirstOrDefaultAsync(x => x.Id == id);
            if (article != null)
            {
                _context.Remove(article);
                await _context.SaveChangesAsync();
                return ActionResultFactory.CreateOkResult();
            }
            else return null!;
    }

    public async Task <ArticleEntity> Get(int id)
    {
        return await _context.Articles.FirstOrDefaultAsync(x => x.Id == id);

    }

    public async Task<IEnumerable<ArticleEntity>> GetAll()
    {
        var items = await _context.Articles.Include(x => x.Category).ToListAsync();
       
        var article = new List <ArticleEntity>();
        foreach (var item in items)
             article.Add(item);

        return article;
    }
}
