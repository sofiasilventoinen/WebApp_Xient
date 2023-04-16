using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp_Xient.DTO;
using WebApp_Xient.Models.Entities;
using WebApp_Xient.Repositories;

namespace WebApp_Xient.Services;

public class ArticleService
{
    private readonly ArticleRepository _articleRepository;

    public ArticleService(ArticleRepository articleRepository)
    {
        _articleRepository = articleRepository;
    }

    public async Task <IActionResult> CreateAsync(ArticleEntity entity)
    {
        entity.Skapad = DateTime.Now;
        return await _articleRepository.CreateAsync(entity);
    }

    public async Task <IActionResult> RemoveArticle(int id)
    {
        return await _articleRepository.RemoveArticle(id);
    }

    public async Task <ArticleEntity> Get(int id)
    {
        return await _articleRepository.Get(id);
    }

    public async Task <IEnumerable<ArticleEntity>> GetAll()
    {
        return await _articleRepository.GetAll();
    }
}
