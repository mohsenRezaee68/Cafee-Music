namespace BlogManagement.Application.Contracts.Article
{
    public class ArticleViewModel
    {
        public long Id { get; set; }
        public string Mozo { get; set; }
        public string ShortDescription { get; set; }
        public string Picture { get; set; }
        public long ArticleId { get; set; }
        public string Category { get; set; }
        public long CategoryId { get; set; }
        public bool IsRemoved { get; set; }
        public string CreationDate { get; set; }
    }
}
