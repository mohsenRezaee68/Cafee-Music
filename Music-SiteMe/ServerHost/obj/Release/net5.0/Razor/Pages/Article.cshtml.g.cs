#pragma checksum "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Article.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f1d87163897d6237c4cb2079b0b4a6d55dfdc05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Pages_Article), @"mvc.1.0.razor-page", @"/Pages/Article.cshtml")]
namespace ServiceHost.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\_ViewImports.cshtml"
using ServiceHost;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f1d87163897d6237c4cb2079b0b4a6d55dfdc05", @"/Pages/Article.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49bdd27e8b016acb3c031a38b8da4d14315ca499", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Article : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 880px; height: 400px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("comments__avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Site/img/avatar.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Article.cshtml"
  
    ViewData["Title"] = Model.Article.Mozo;
    ViewData["keywords"] = Model.Article.Keywords;
    ViewData["metaDescription"] = Model.Article.MetaDescription;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
		<div class=""container-fluid"">
			<div class=""row row--grid"">
				<!-- breadcrumb -->
				<div class=""col-12"">
					<ul class=""breadcrumb breadcrumb--hidden-desk"">
						<li class=""breadcrumb__item""><a href=""index.html"">???????? ????????</a></li>
						<li class=""breadcrumb__item""><a href=""news.html"">");
#nullable restore
#line 15 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Article.cshtml"
                                                                    Write(Model.Article.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n\t\t\t\t\t\t<li class=\"breadcrumb__item breadcrumb__item--active\">");
#nullable restore
#line 16 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Article.cshtml"
                                                                         Write(Model.Article.Mozo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\t\t\t\t\t</ul>\r\n\t\t\t\t</div>\r\n\t\t\t\t<!-- end breadcrumb -->\r\n\r\n\t\t\t\t<div class=\"col-12 col-xl-10 offset-xl-1\">\r\n\t\t\t\t\t<div class=\"article\">\r\n\t\t\t\t\t\t<!-- article content -->\r\n\t\t\t\t\t\t<div class=\"article__content\">\r\n\t\t\t\t\t\t\t<div class =\"col-8\">\r\n\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3f1d87163897d6237c4cb2079b0b4a6d55dfdc056620", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 898, "~/Cafee-Music/", 898, 14, true);
#nullable restore
#line 26 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Article.cshtml"
AddHtmlAttributeValue("", 912, Model.Article.Picture, 912, 22, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 26 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Article.cshtml"
AddHtmlAttributeValue("", 977, Model.Article.PictureAlt, 977, 25, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 26 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Article.cshtml"
AddHtmlAttributeValue("", 1011, Model.Article.PictureTitle, 1011, 27, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
								<span class=""article__date""><svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 24 24""><path d=""M12,2A10,10,0,1,0,22,12,10.01114,10.01114,0,0,0,12,2Zm0,18a8,8,0,1,1,8-8A8.00917,8.00917,0,0,1,12,20ZM14.09814,9.63379,13,10.26807V7a1,1,0,0,0-2,0v5a1.00025,1.00025,0,0,0,1.5.86621l2.59814-1.5a1.00016,1.00016,0,1,0-1-1.73242Z""/></svg> ");
#nullable restore
#line 27 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Article.cshtml"
                                                                                                                                                                                                                                                                                                                                                                       Write(Model.Article.PublishDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\t\t\t\t\t\t\t\t<div class=\"article__meta\">\r\n\t\t\t\t\t\t\t\t<a href=\"#\" class=\"article__category\">??????????</a>\r\n\r\n\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t</div>\r\n                            </div>\r\n\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\r\n\r\n\t\t\t\t\t\t\t<h1> ");
#nullable restore
#line 37 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Article.cshtml"
                            Write(Model.Article.Mozo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                            <div><p>");
#nullable restore
#line 38 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Article.cshtml"
                               Write(Html.Raw(@Model.Article.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p></div>
							

	
						</div>
						<!-- end article content -->

						<!-- share -->
						<div class=""share"">
							
                        </div>
						<!-- end share -->

						<!-- comments -->
						<div class=""comments"">
							<div class=""comments__title"">
								<h4>??????????</h4>
								<span>");
#nullable restore
#line 55 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Article.cshtml"
                                  Write(Model.Article.Comments.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\t\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t\t<ul class=\"comments__list\">\r\n");
#nullable restore
#line 59 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Article.cshtml"
                               foreach (var comment in Model.Article.Comments)
                                            {
												

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<li class=\"comments__item comments__item--quote\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"comments__autor\"");
            BeginWriteAttribute("id", " id=\"", 2341, "\"", 2365, 2);
            WriteAttributeValue("", 2346, "comment-", 2346, 8, true);
#nullable restore
#line 63 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Article.cshtml"
WriteAttributeValue("", 2354, comment.Id, 2354, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3f1d87163897d6237c4cb2079b0b4a6d55dfdc0512449", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t<span class=\"comments__name\"> ");
#nullable restore
#line 65 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Article.cshtml"
                                                                 Write(comment.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n\t\t\t\t\t\t\t\t\t\t<span class=\"comments__time\"> ");
#nullable restore
#line 66 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Article.cshtml"
                                                                 Write(comment.CreationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<p class=\"comments__text\">\r\n");
#nullable restore
#line 69 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Article.cshtml"
                                           if (comment.ParentId > 0)
                                                        {
                                                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <span> ???? ???????? ????: <a");
            BeginWriteAttribute("href", " href=\"", 2880, "\"", 2913, 2);
            WriteAttributeValue("", 2887, "#comment-", 2887, 9, true);
#nullable restore
#line 72 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Article.cshtml"
WriteAttributeValue("", 2896, comment.ParentId, 2896, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 72 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Article.cshtml"
                                                                                                                    Write(comment.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ( ");
#nullable restore
#line 72 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Article.cshtml"
                                                                                                                                    Write(comment.parentName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" )</a> </span>\r\n");
#nullable restore
#line 73 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Article.cshtml"
                                                            
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 75 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Article.cshtml"
                                   Write(comment.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
									<div class=""comments__actions"">
										<div class=""comments__rate"">
											
                                        </div>
										 <span class=""reply-btn"">
                                                        <a href=""#postComment""");
            BeginWriteAttribute("onclick", " onclick=\'", 3378, "\'", 3426, 3);
            WriteAttributeValue("", 3388, "$(\"#commentParentId\").val(", 3388, 26, true);
#nullable restore
#line 81 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Article.cshtml"
WriteAttributeValue("", 3414, comment.Id, 3414, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3425, ")", 3425, 1, true);
            EndWriteAttribute();
            WriteLiteral(">????????</a>\r\n                                                    </span>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</li>\r\n");
#nullable restore
#line 85 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Article.cshtml"
											}

#line default
#line hidden
#nullable disable
            WriteLiteral("                                \r\n\r\n\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t</ul>\r\n\r\n\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f1d87163897d6237c4cb2079b0b4a6d55dfdc0517790", async() => {
                WriteLiteral(@"
								
							        	<div class=""col-12"" id=""postComment"">
							            <div class=""sign__group"">
							        	  <input type=""text"" name=""name"" class=""sign__input"" placeholder=""??????"">
							           </div>
							        </div>
							         <div class=""col-12 "">
							           <div class=""sign__group"">
							        	  <input type=""text"" name=""email"" class=""sign__input"" placeholder=""??????????"">
							           </div>
							         </div>
                                 
								 <div class=""col-12"">
								   <div class=""sign__group"">
								    	<textarea name=""message"" class=""sign__textarea"" placeholder=""???????? ?????? ???? ?????????????? . . .""></textarea>
								   </div>
							   </div>
								<input type=""hidden"" name=""ownerRecordName""");
                BeginWriteAttribute("value", " value=\"", 4417, "\"", 4444, 1);
#nullable restore
#line 109 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Article.cshtml"
WriteAttributeValue("", 4425, Model.Article.Mozo, 4425, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\t\t\t\t\t\t\t\t<input type=\"hidden\" name=\"ownerRecordCatgory\"");
                BeginWriteAttribute("value", " value=\"", 4504, "\"", 4539, 1);
#nullable restore
#line 110 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Article.cshtml"
WriteAttributeValue("", 4512, Model.Article.CategoryName, 4512, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\t\t\t\t\t\t\t\t<input type=\"hidden\" name=\"ownerRecordSinger\"");
                BeginWriteAttribute("value", " value=\"", 4598, "\"", 4633, 1);
#nullable restore
#line 111 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Article.cshtml"
WriteAttributeValue("", 4606, Model.Article.CategoryName, 4606, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n\t\t\t\t\t\t\t\t<input type=\"hidden\" name=\"musicSlug\"");
                BeginWriteAttribute("value", " value=\"", 4686, "\"", 4713, 1);
#nullable restore
#line 113 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Article.cshtml"
WriteAttributeValue("", 4694, Model.Article.Slug, 4694, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\t\t\t\t\t\t\t\t<input type=\"hidden\" name=\"parentId\" id=\"commentParentId\"");
                BeginWriteAttribute("value", " value=\"", 4784, "\"", 4792, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t<div class=\"col-12 col-xl-3\">\r\n\t\t\t\t\t\t\t\t   <button type=\"submit\" class=\"sign__btn\"  name=\"submit\">??????????</button>\r\n\t\t\t\t\t\t\t    </div>\r\n\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<!-- end comments -->\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceHost.Pages.ArticleModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.ArticleModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.ArticleModel>)PageContext?.ViewData;
        public ServiceHost.Pages.ArticleModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
