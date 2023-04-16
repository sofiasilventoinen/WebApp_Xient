using WebApp_Xient.Models.Entities;

namespace WebApp_Xient.DTO;

public class ArticleRequest
{
    
    public string Title { get; set; } = null!;
    public string Content { get; set; } = null!;
    public int ArticleCategoryId { get; set; }
    public string CategoryName { get; set; } = null!;

    public static implicit operator ArticleEntity (ArticleRequest req)
    {
        var entity = new ArticleEntity ();
        entity.Title = req.Title;
        entity.Content = req.Content;
        entity.ArticleCategoryId = req.ArticleCategoryId;
        entity.Uppdaterad = DateTime.Now;
        return entity;
    }

    public static implicit operator ArticleCategoryEntity (ArticleRequest model)
    {
        return new ArticleCategoryEntity
        {
            CategoryName = model.CategoryName

        };
    }


}
