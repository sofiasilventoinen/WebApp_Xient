namespace WebApp_Xient.DTO
{
    public class ArticleResponse
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
        public int ArticleCategoryId { get; set; }
    }
}
