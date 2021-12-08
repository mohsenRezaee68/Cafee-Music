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
                    "Avent", new List<PermissionDto>
                    {
                        new PermissionDto(BlogPermissions.ListAvent, "ListAvent"),
                        new PermissionDto(BlogPermissions.SearchAvents, "SearchAvents"),
                         new PermissionDto(BlogPermissions.EditAvent, "EditAvent"),
                         new PermissionDto(BlogPermissions.CreateAvent, "CreateAvent"),
                         new PermissionDto(BlogPermissions.DeleteAvent, "DeleteAvent"),
                        new PermissionDto(BlogPermissions.NoDeleteAvent, "NoDeleteAvent"),
                    }
                },
                  {
                    "Article", new List<PermissionDto>
                    {
                        new PermissionDto(BlogPermissions.ListArticles, "ListArticles"),
                        new PermissionDto(BlogPermissions.SearchArticles, "SearchArticles"),
                        new PermissionDto(BlogPermissions.EditArticle, "EditArticle"),
                         new PermissionDto(BlogPermissions.CreateArticle, "CreateArticle"),
                         new PermissionDto(BlogPermissions.DeleteArticle, "DeleteArticle"),
                        new PermissionDto(BlogPermissions.NoDeleteArticle, "NoDeleteArticle"),
                    }
                },{
                    "Blog", new List<PermissionDto>
                    {
                        new PermissionDto(BlogPermissions.ListBlogCategories, "ListAvent"),
                        new PermissionDto(BlogPermissions.SearchBlogCategories, "SearchAvents"),
                         new PermissionDto(BlogPermissions.EditBlogCategory, "EditAvent"),
                         new PermissionDto(BlogPermissions.CreateBlogCategory, "CreateAvent"),
                        
                    }
                },
            };
        }
    }
}