using WebApp_Xient.DTO;

namespace WebApp_Xient.Models.Entities;

public class ArticleEntity
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Content { get; set; } = null!;
    public DateTime Skapad { get; set; }
    public DateTime Uppdaterad { get; set; }

    public int ArticleCategoryId { get; set; }
    public ArticleCategoryEntity? Category { get; set; } 

}

