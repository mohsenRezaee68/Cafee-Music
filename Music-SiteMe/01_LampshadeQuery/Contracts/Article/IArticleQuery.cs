using System.Collections.Generic;

namespace _01_LampshadeQuery.Contracts.Article
{
    public interface IArticleQuery
    {
        List<ArticleQueryModel> LatestArticles();
        List<ArticleQueryModel> LatestAvents();
        ArticleQueryModel GetArticleDetails(long id);
        ArticleQueryModel GetAventDetails(long id);
        List<ArticleQueryModel> LatestAventAlls();
        List<ArticleQueryModel> SearchAvents(string value);
        List<ArticleQueryModel> LatestArticleAlls();
        List<ArticleQueryModel> SearchArticles(string value);
    }
}
