#pragma checksum "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Artists.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e191f979aa9995539ed19f83690da6b4125419a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Pages_Artists), @"mvc.1.0.razor-page", @"/Pages/Artists.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e191f979aa9995539ed19f83690da6b4125419a4", @"/Pages/Artists.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49bdd27e8b016acb3c031a38b8da4d14315ca499", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Artists : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Artists", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("main__filter-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Singer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("artist"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Artist", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Artists.cshtml"
  
    ViewData["Title"] = "????????????????";

   	  

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
		<div class=""row row--grid"">
				<!-- breadcrumb -->
				<div class=""col-12"">
					<ul class=""breadcrumb"">
						<li class=""breadcrumb__item""><a href=""index.html"">???????? ????????</a></li>
						<li class=""breadcrumb__item breadcrumb__item--active"">????????????????</li>
					</ul>
				</div>
				<!-- end breadcrumb -->

				<!-- title -->
				<div class=""col-12"">
					<div class=""main__title main__title--page"">
						<h1>?????????? ?????? ????</h1>
					</div>
				</div>
				<!-- end title -->
		</div>

			<!-- releases -->
		<div class=""row row--grid"">
				<div class=""col-12"">
					<div class=""main__filter"">
						");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e191f979aa9995539ed19f83690da6b4125419a46126", async() => {
                WriteLiteral(@"
							<input type=""search""  name=""value"" id=""value""  placeholder=""?????? ?? ???? ..."">
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
#line 42 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Artists.cshtml"
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
						          <li class=""breadcrumb__item breadcrumb__item--active"">?????????? ?????????? : ");
#nullable restore
#line 52 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Artists.cshtml"
                                                                                                 Write(Model.values);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\t\t\t\t\t           </ul>\r\n\t\t\t\t            </div>\r\n\t\t\t\t\r\n\t\t             </div>\r\n\r\n\t\t\t\t<div class=\"row row--grid \">\r\n\r\n");
#nullable restore
#line 60 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Artists.cshtml"
                     foreach (var afg in Model.artistSerch)

					{	

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<div class=\"col-6 col-sm-4 col-md-3 col-xl-2\">\r\n\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e191f979aa9995539ed19f83690da6b4125419a49590", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t<div class=\"artist__cover\">\r\n\t\t\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e191f979aa9995539ed19f83690da6b4125419a49912", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1920, "~/Cafee-Music/", 1920, 14, true);
#nullable restore
#line 66 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Artists.cshtml"
AddHtmlAttributeValue("", 1934, afg.Picture, 1934, 12, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 66 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Artists.cshtml"
AddHtmlAttributeValue("", 1953, afg.PictureAlt, 1953, 15, false);

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
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<h3 class=\"artist__title\">");
#nullable restore
#line 68 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Artists.cshtml"
                                                     Write(afg.Laghab);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Laghab", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Artists.cshtml"
                                                       WriteLiteral(afg.Laghab);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Laghab"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Laghab", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Laghab"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 71 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Artists.cshtml"

						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\r\n\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n");
#nullable restore
#line 79 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Artists.cshtml"
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
						          <li class=""breadcrumb__item breadcrumb__item--active"">?????????? ?????? </li>
					           </ul>
				            </div>
				
		             </div>
			 <div class=""row row--grid"">
				

");
#nullable restore
#line 95 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Artists.cshtml"
                         foreach (var afg in Model.artist.Artists)
				            {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<div class=\"col-6 col-sm-4 col-md-3 col-xl-2\">\r\n\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e191f979aa9995539ed19f83690da6b4125419a415559", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t<div class=\"artist__cover\">\r\n\t\t\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e191f979aa9995539ed19f83690da6b4125419a415882", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2808, "~/Cafee-Music/", 2808, 14, true);
#nullable restore
#line 100 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Artists.cshtml"
AddHtmlAttributeValue("", 2822, afg.Picture, 2822, 12, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 100 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Artists.cshtml"
AddHtmlAttributeValue("", 2841, afg.PictureAlt, 2841, 15, false);

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
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<h3 class=\"artist__title\">");
#nullable restore
#line 102 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Artists.cshtml"
                                                     Write(afg.Laghab);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Laghab", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 98 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Artists.cshtml"
                                                       WriteLiteral(afg.Laghab);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Laghab"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Laghab", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Laghab"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 105 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Artists.cshtml"
					
				             }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"				

						
					</div>

					<button class=""main__load"" type=""button"">?????????? ????????</button>
				</div>
		</div>
			<!---------------------------------->
			
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
                     float: right; /* ?????????? ???????? ???? ?????? ???????? */
                     padding: 8px 16px;
                     text-decoration: none; /* ?????? ???? ?????? ???????? */
					 border-radius:50px;
					  border: 1px solid #ddd;
					  margin:0 3px;
					  box-shadow: 0 2px 2px 0 rgba(0,0,0,0.14)");
            WriteLiteral(@",0 3px 1px -2px rgba(0,0,0,0.2),0 1px 5px 0 rgba(0,0,0,0.12);
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
#line 157 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Artists.cshtml"
                            if (Model.artist.CurrentPage > 1)
									{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<th class=\"paginate_button\" aria-controls=\"dataTables-example\" tabindex=\"0\">\r\n\t\t\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 4713, "\"", 4767, 2);
            WriteAttributeValue("", 4720, "/Artists?pageId=", 4720, 16, true);
#nullable restore
#line 160 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Artists.cshtml"
WriteAttributeValue("", 4736, Model.artist.CurrentPage - 1, 4736, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">????????</a> </th> \r\n\t\t\t\t\t\t\t\t\t\t<th class=\"paginate_button\" aria-controls=\"dataTables-example\" tabindex=\"0\">\r\n\t\t\t\t\t\t\t\t\t\t\t<a href=\"/Artists?pageId=1\">?????????? ????????</a></th>\r\n");
#nullable restore
#line 163 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Artists.cshtml"
									}

#line default
#line hidden
#nullable disable
#nullable restore
#line 164 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Artists.cshtml"
                            for (int i = 1; i <= Model.artist.PageCount; i++)
									{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t<th");
            BeginWriteAttribute("class", " class=\"", 5031, "\"", 5102, 2);
            WriteAttributeValue("", 5039, "paginate_button", 5039, 15, true);
#nullable restore
#line 166 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Artists.cshtml"
WriteAttributeValue(" ", 5054, (i==Model.artist.CurrentPage)? "active" : "", 5055, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-controls=\"dataTables-example\" tabindex=\"0\">\r\n\t\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", "  href=\"", 5166, "\"", 5192, 2);
            WriteAttributeValue("", 5174, "/Artists?pageId=", 5174, 16, true);
#nullable restore
#line 167 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Artists.cshtml"
WriteAttributeValue("", 5190, i, 5190, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 167 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Artists.cshtml"
                                                                 Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></th>\t\r\n");
#nullable restore
#line 168 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Artists.cshtml"
									}

#line default
#line hidden
#nullable disable
#nullable restore
#line 169 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Artists.cshtml"
                                     if (Model.artist.CurrentPage < Model.artist.PageCount)
									{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t<th class=\"paginate_button\" aria-controls=\"dataTables-example\" tabindex=\"0\">\r\n\t\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 5397, "\"", 5451, 2);
            WriteAttributeValue("", 5404, "/Artists?pageId=", 5404, 16, true);
#nullable restore
#line 172 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Artists.cshtml"
WriteAttributeValue("", 5420, Model.artist.CurrentPage + 1, 5420, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">????????</a> </th>\t\r\n\t\t\t\t\t\t\t\t\t<th class=\"paginate_button\" aria-controls=\"dataTables-example\" tabindex=\"0\">\r\n\t\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 5569, "\"", 5617, 2);
            WriteAttributeValue("", 5576, "/Artists?pageId=", 5576, 16, true);
#nullable restore
#line 174 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Artists.cshtml"
WriteAttributeValue("", 5592, Model.artist.PageCount, 5592, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">?????????? ????????</a></th>\t\r\n");
#nullable restore
#line 175 "F:\PROJECT\Music-cafee\music\Music-SiteMe\ServerHost\Pages\Artists.cshtml"
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
			<!------------------------------------->
        </div>
      </div>
		
	

</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceHost.Pages.ArtistsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.ArtistsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.ArtistsModel>)PageContext?.ViewData;
        public ServiceHost.Pages.ArtistsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
