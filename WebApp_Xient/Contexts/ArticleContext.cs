using Microsoft.EntityFrameworkCore;
using WebApp_Xient.Models.Entities;

namespace WebApp_Xient.Contexts;

public class ArticleContext : DbContext

{
    public ArticleContext(DbContextOptions <ArticleContext> options) : base(options)
    {
    }

    public DbSet<ArticleEntity> Articles { get; set; }
    public DbSet<ArticleCategoryEntity> Categories { get; set; } 
}
