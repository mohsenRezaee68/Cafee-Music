#pragma checksum "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Articles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49a7f0684f113d6ab28381eb2a049cfdeedc8529"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Pages_Articles), @"mvc.1.0.razor-page", @"/Pages/Articles.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49a7f0684f113d6ab28381eb2a049cfdeedc8529", @"/Pages/Articles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49bdd27e8b016acb3c031a38b8da4d14315ca499", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Articles : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Articles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("main__filter-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 350px; height: 200px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", new global::Microsoft.AspNetCore.Html.HtmlString("/Avent"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Avent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Articles.cshtml"
  
   
   	 ViewData["Title"] = "مقالات";   

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<<div class=""container-fluid"">
		<div class=""row row--grid"">
				<!-- breadcrumb -->
				<div class=""col-12"">
					<ul class=""breadcrumb"">
						<li class=""breadcrumb__item""><a href=""index.html"">صفحه اصلی</a></li>
						<li class=""breadcrumb__item breadcrumb__item--active"">مقالات</li>
					</ul>
				</div>
				<!-- end breadcrumb -->

				<!-- title -->
				<div class=""col-12"">
					<div class=""main__title main__title--page"">
						<h1>منتشر شده ها</h1>
					</div>
				</div>
				<!-- end title -->
		</div>

			<!-- releases -->
		<div class=""row row--grid"">
				<div class=""col-12"">
					<div class=""main__filter"">
						");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49a7f0684f113d6ab28381eb2a049cfdeedc85296536", async() => {
                WriteLiteral(@"
							<input type=""search""  name=""value"" id=""value""  placeholder=""جست و جو ..."">
							<button type=""submit""><svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 24 24""><path d=""M21.71,20.29,18,16.61A9,9,0,1,0,16.61,18l3.68,3.68a1,1,0,0,0,1.42,0A1,1,0,0,0,21.71,20.29ZM11,18a7,7,0,1,1,7-7A7,7,0,0,1,11,18Z""/></svg></button>
						");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\t\t\t\t\t\t\r\n\t\t\t\t\t</div>\r\n\r\n");
#nullable restore
#line 41 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Articles.cshtml"
                     if(Model.values != null)

			{
									{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"          <div class=""row row--grid"">
			<div class=""col-12"">
			<div class=""row row--grid"">
				          <!-- breadcrumb -->
				            <div class=""col-12"">
					           <ul class=""breadcrumb"">
						          <li class=""breadcrumb__item breadcrumb__item--active"">نتیجه جستجو : ");
#nullable restore
#line 51 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Articles.cshtml"
                                                                                                 Write(Model.values);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\t\t\t\t\t           </ul>\r\n\t\t\t\t            </div>\r\n\t\t\t\t\r\n\t\t             </div>\r\n\r\n\t\t\t\t<div class=\"row row--grid \">\r\n\r\n");
#nullable restore
#line 59 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Articles.cshtml"
                     foreach (var avent in Model.ArticleSerch)

					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div class=\"col-6 col-sm-4 col-lg-4\">\r\n\t\t\t\t\t\t\t\t<div class=\"album\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"album__cover\">\r\n\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "49a7f0684f113d6ab28381eb2a049cfdeedc852910083", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1857, "~/Cafee-Music/", 1857, 14, true);
#nullable restore
#line 64 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Articles.cshtml"
AddHtmlAttributeValue("", 1871, avent.Picture, 1871, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "asp-route-id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 64 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Articles.cshtml"
AddHtmlAttributeValue("", 1961, avent.Slug, 1961, 11, false);

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
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "49a7f0684f113d6ab28381eb2a049cfdeedc852912299", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Articles.cshtml"
                                                               WriteLiteral(avent.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t<span class=\"album__stat\">\r\n\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t</span>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"album__title\">\r\n\t\t\t\t\t\t\t\t\t\t<h3>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49a7f0684f113d6ab28381eb2a049cfdeedc852914655", async() => {
                WriteLiteral(" ");
#nullable restore
#line 72 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Articles.cshtml"
                                                                                     Write(avent.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Articles.cshtml"
                                                                  WriteLiteral(avent.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h3>\r\n\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 77 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Articles.cshtml"
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\r\n\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n");
#nullable restore
#line 84 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Articles.cshtml"
					}
			}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"			<div class=""row row--grid"">
			<div class=""col-12"">
			<div class=""row row--grid"">
				          <!-- breadcrumb -->
				            <div class=""col-12"">
					           <ul class=""breadcrumb"">
						          <li class=""breadcrumb__item breadcrumb__item--active"">منتشر شده </li>
					           </ul>
				            </div>
				
		             </div>
			 <div class=""row row--grid"">
				

");
#nullable restore
#line 100 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Articles.cshtml"
                         foreach (var avent in Model.article.Articles)
				            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-6 col-sm-4 col-lg-4\">\r\n\t\t\t\t\t\t\t\t<div class=\"album\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"album__cover\">\r\n\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "49a7f0684f113d6ab28381eb2a049cfdeedc852918562", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2992, "~/Cafee-Music/", 2992, 14, true);
#nullable restore
#line 104 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Articles.cshtml"
AddHtmlAttributeValue("", 3006, avent.Picture, 3006, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "asp-route-id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 104 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Articles.cshtml"
AddHtmlAttributeValue("", 3096, avent.Slug, 3096, 11, false);

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
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "49a7f0684f113d6ab28381eb2a049cfdeedc852920780", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 105 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Articles.cshtml"
                                                               WriteLiteral(avent.Slug);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t<span class=\"album__stat\">\r\n\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t</span>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"album__title\">\r\n\t\t\t\t\t\t\t\t\t\t<h3>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49a7f0684f113d6ab28381eb2a049cfdeedc852923115", async() => {
                WriteLiteral(" ");
#nullable restore
#line 111 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Articles.cshtml"
                                                                                       Write(avent.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 111 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Articles.cshtml"
                                                                  WriteLiteral(avent.Slug);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h3>\r\n\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 116 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Articles.cshtml"
				             }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"				

						
					</div>

					<!------------------------------------------>

					
			<!-- end releases -->

			<div class=""row row--grid"">
				          <!-- breadcrumb -->
				            <div class=""col-12"">
					           <div class=""breadcrumb"">
						          <section class=""breadcrumb__item breadcrumb__item--active"">
									   <div class=""row"">
				
				<style>
					.my-center{
                      text-align:center;
                    }
                   .pagination {
                     display: inline-block;
                    }
                    
                    .pagination a {
                     color: #7FFF00;
                     float: right; /* شناور کردن در سمت راست */
                     padding: 8px 16px;
                     text-decoration: none; /* حذف خط زیر لینک */
					 border-radius:50px;
					  border: 1px solid #ddd;
					  margin:0 3px;
					  box-shadow: 0 2px 2px 0 rgba(0,0,0,0.14),0 3px 1px -2px rgba(0,0,0,0.2),0 1px 5px 0 rgb");
            WriteLiteral(@"a(0,0,0,0.12);
                    }
                    
                    .pagination a.active{
                     background-color:#FF0000;
                     color:#fff;
                    }
                    
                    .pagination a:hover:not(.active){
                     background-color:#FF00FF;
                    }
                </style>
				 <div class=""col-12"">
				<div class=""pagination"">
					<table >
						<thead>
							<tr>
");
#nullable restore
#line 167 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Articles.cshtml"
                            if (Model.article.CurrentPage > 1)
									{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<th class=\"paginate_button\" aria-controls=\"dataTables-example\" tabindex=\"0\">\r\n\t\t\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 5146, "\"", 5202, 2);
            WriteAttributeValue("", 5153, "/Articles?pageId=", 5153, 17, true);
#nullable restore
#line 170 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Articles.cshtml"
WriteAttributeValue("", 5170, Model.article.CurrentPage - 1, 5170, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">قبلی</a> </th> \r\n\t\t\t\t\t\t\t\t\t\t<th class=\"paginate_button\" aria-controls=\"dataTables-example\" tabindex=\"0\">\r\n\t\t\t\t\t\t\t\t\t\t\t<a href=\"/Articles?pageId=1\">اولین صفحه</a></th>\r\n");
#nullable restore
#line 173 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Articles.cshtml"
									}

#line default
#line hidden
#nullable disable
#nullable restore
#line 174 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Articles.cshtml"
                            for (int i = 1; i <= Model.article.PageCount; i++)
									{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t<th");
            BeginWriteAttribute("class", " class=\"", 5468, "\"", 5540, 2);
            WriteAttributeValue("", 5476, "paginate_button", 5476, 15, true);
#nullable restore
#line 176 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Articles.cshtml"
WriteAttributeValue(" ", 5491, (i==Model.article.CurrentPage)? "active" : "", 5492, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-controls=\"dataTables-example\" tabindex=\"0\">\r\n\t\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", "  href=\"", 5604, "\"", 5631, 2);
            WriteAttributeValue("", 5612, "/Articles?pageId=", 5612, 17, true);
#nullable restore
#line 177 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Articles.cshtml"
WriteAttributeValue("", 5629, i, 5629, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 177 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Articles.cshtml"
                                                                  Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></th>\t\r\n");
#nullable restore
#line 178 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Articles.cshtml"
									}

#line default
#line hidden
#nullable disable
#nullable restore
#line 179 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Articles.cshtml"
                                     if (Model.article.CurrentPage < Model.article.PageCount)
									{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t<th class=\"paginate_button\" aria-controls=\"dataTables-example\" tabindex=\"0\">\r\n\t\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 5838, "\"", 5894, 2);
            WriteAttributeValue("", 5845, "/Articles?pageId=", 5845, 17, true);
#nullable restore
#line 182 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Articles.cshtml"
WriteAttributeValue("", 5862, Model.article.CurrentPage + 1, 5862, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">بعدی</a> </th>\t\r\n\t\t\t\t\t\t\t\t\t<th class=\"paginate_button\" aria-controls=\"dataTables-example\" tabindex=\"0\">\r\n\t\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 6012, "\"", 6062, 2);
            WriteAttributeValue("", 6019, "/Articles?pageId=", 6019, 17, true);
#nullable restore
#line 184 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Articles.cshtml"
WriteAttributeValue("", 6036, Model.article.PageCount, 6036, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">اخرین صفحه</a></th>\t\r\n");
#nullable restore
#line 185 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Articles.cshtml"
									}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"							</tr>
						</thead>
					</table>
						 
					
                </div>
				 
			</div>
               
            </div>
									  
									  </section>
					           </div>
				            </div>
				
		  </div>
					<!------------------------------------------->
				</div>
		</div>
			<!-- end releases -->
        </div>
      </div>
		
	

</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceHost.Pages.ArticlsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.ArticlsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.ArticlsModel>)PageContext?.ViewData;
        public ServiceHost.Pages.ArticlsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
