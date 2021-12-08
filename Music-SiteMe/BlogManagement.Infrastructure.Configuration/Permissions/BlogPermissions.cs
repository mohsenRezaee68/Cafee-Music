using System.ComponentModel;

namespace BlogManagement.Configuration.Permissions
{
    public static class BlogPermissions
    {
        //Avent
        public const int ListAvent = 36;
        public const int SearchAvents = 37;
        public const int CreateAvent = 38;
        public const int EditAvent = 39;
        public const int DeleteAvent = 40;
        public const int NoDeleteAvent = 40;

        //Article
        public const int ListArticles = 41;
        public const int SearchArticles = 42;
        public const int CreateArticle = 43;
        public const int EditArticle = 44;
        public const int DeleteArticle = 45;
        public const int NoDeleteArticle = 46;
        //BlogCategory
        public const int ListBlogCategories = 59;
        public const int SearchBlogCategories = 60;
        public const int CreateBlogCategory = 61;
        public const int EditBlogCategory = 62;
    }
}