#pragma checksum "C:\Users\zaino\Documents\Visual Studio 2019\Projects\No Logo Studios\SmartReservations.Web\SmartReservation\Views\Recipe\Currentrecipes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38621b2f9e78e52040732038cf0cf03ad2e78945"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipe_Currentrecipes), @"mvc.1.0.view", @"/Views/Recipe/Currentrecipes.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\zaino\Documents\Visual Studio 2019\Projects\No Logo Studios\SmartReservations.Web\SmartReservation\Views\_ViewImports.cshtml"
using SmartReservation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zaino\Documents\Visual Studio 2019\Projects\No Logo Studios\SmartReservations.Web\SmartReservation\Views\_ViewImports.cshtml"
using SmartReservation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38621b2f9e78e52040732038cf0cf03ad2e78945", @"/Views/Recipe/Currentrecipes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f004aab76d2bdcda1a240deaf080d712866ff5de", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Recipe_Currentrecipes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SmartReservation.Model.Recipe>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image Description"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:300px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\zaino\Documents\Visual Studio 2019\Projects\No Logo Studios\SmartReservations.Web\SmartReservation\Views\Recipe\Currentrecipes.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<main id=""content"" role=""main"" class=""main"">
    <div class=""content container-fluid"">
        <div class=""page-header"">
            <div class=""row align-items-center"">
                <div class=""col-sm mb-2 mb-sm-0"">
                    <nav aria-label=""breadcrumb"">
                        <ol class=""breadcrumb breadcrumb-no-gutter"">
                            <li class=""breadcrumb-item""><span class=""breadcrumb-link"">Recipes</span></li>
                            <li class=""breadcrumb-item active"" aria-current=""page"">Current</li>
                        </ol>
                    </nav>

                    <h1 class=""page-header-title"">Current Recipes</h1>
                </div>
            </div>
        </div>
        <div class=""content container-fluid my-n9"">
            <div class=""container content-space-2 content-space-lg-3"">

                <div class=""row mb-5 mt-5"" id=""columnV"">
");
#nullable restore
#line 29 "C:\Users\zaino\Documents\Visual Studio 2019\Projects\No Logo Studios\SmartReservations.Web\SmartReservation\Views\Recipe\Currentrecipes.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-sm-6 col-md-4 mb-3 mb-md-0\">\r\n                            <a class=\"card card-bordered card-transition h-100\"");
            BeginWriteAttribute("href", " href=\"", 1288, "\"", 1361, 1);
#nullable restore
#line 32 "C:\Users\zaino\Documents\Visual Studio 2019\Projects\No Logo Studios\SmartReservations.Web\SmartReservation\Views\Recipe\Currentrecipes.cshtml"
WriteAttributeValue("", 1295, Url.Action("Details", "Recipe", new { recipeID = item.RecipeID }), 1295, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "38621b2f9e78e52040732038cf0cf03ad2e789456758", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1428, "~/Files/", 1428, 8, true);
#nullable restore
#line 33 "C:\Users\zaino\Documents\Visual Studio 2019\Projects\No Logo Studios\SmartReservations.Web\SmartReservation\Views\Recipe\Currentrecipes.cshtml"
AddHtmlAttributeValue("", 1436, item.ImageName, 1436, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                <div class=\"card-body\">\r\n                                    <div class=\"d-flex align-items-center mb-2\">\r\n                                        <h4 class=\"card-title mb-0\">");
#nullable restore
#line 37 "C:\Users\zaino\Documents\Visual Studio 2019\Projects\No Logo Studios\SmartReservations.Web\SmartReservation\Views\Recipe\Currentrecipes.cshtml"
                                                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                    </div>\r\n                                </div>\r\n                            </a>\r\n                        </div>\r\n");
#nullable restore
#line 42 "C:\Users\zaino\Documents\Visual Studio 2019\Projects\No Logo Studios\SmartReservations.Web\SmartReservation\Views\Recipe\Currentrecipes.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <!-- End Row -->\r\n\r\n                <div class=\"text-center\">\r\n                    <a class=\"btn btn-outline-primary btn-transition\" id=\"btnLoadMore\"");
            BeginWriteAttribute("href", " href=\"", 2089, "\"", 2162, 1);
#nullable restore
#line 47 "C:\Users\zaino\Documents\Visual Studio 2019\Projects\No Logo Studios\SmartReservations.Web\SmartReservation\Views\Recipe\Currentrecipes.cshtml"
WriteAttributeValue("", 2096, Url.Action("Currentrecipes","Recipe", new { clicked = "clicked"}), 2096, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Load More</a>\r\n                </div>\r\n            </div>\r\n            <!-- End Card Grid -->\r\n        </div>\r\n    </div>\r\n</main>\r\n\r\n\r\n<!-- Card Grid -->");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SmartReservation.Model.Recipe>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
