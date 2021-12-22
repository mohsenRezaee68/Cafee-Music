using System.Collections.Generic;
using _0_Framework.Infrastructure;

namespace BlogManagement.Configuration.Permissions
{
    public class BlogPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
               
                  {
                    "Article", new List<PermissionDto>
                    {
                        
                        new PermissionDto(BlogPermissions.SearchArticles, "Search"),
                        new PermissionDto(BlogPermissions.EditArticle, "Edit"),
                         new PermissionDto(BlogPermissions.CreateArticle, "Create"),
                         new PermissionDto(BlogPermissions.DeleteArticle, "Remove"),
                        new PermissionDto(BlogPermissions.RestorArticle, "Restore"),
                    }
                },{
                    "Blog", new List<PermissionDto>
                    {
                        new PermissionDto(BlogPermissions.ListBlogCategories, "GetArticleCategories"),
                        new PermissionDto(BlogPermissions.SearchBlogCategories, "Search"),
                         new PermissionDto(BlogPermissions.EditBlogCategory, "Edit"),
                         new PermissionDto(BlogPermissions.CreateBlogCategory, "Create"),
                        
                    }
                },
            };
        }
    }
}