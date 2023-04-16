namespace WebApp_Xient.Models.Entities;

public class ArticleCategoryEntity
{
    public int Id { get; set; }
    public string CategoryName { get; set; } = null!;

    public ICollection<ArticleEntity> Articles { get; set; } = new List<ArticleEntity>();
}
