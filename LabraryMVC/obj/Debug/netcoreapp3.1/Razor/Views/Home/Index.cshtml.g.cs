#pragma checksum "D:\Etude\2-annee\Session3\Asp.net\LabraryMVC\LabraryMVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d369046c2dea179e290b88ae7aeae58659d77e26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Etude\2-annee\Session3\Asp.net\LabraryMVC\LabraryMVC\Views\_ViewImports.cshtml"
using LabraryMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Etude\2-annee\Session3\Asp.net\LabraryMVC\LabraryMVC\Views\_ViewImports.cshtml"
using LabraryMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d369046c2dea179e290b88ae7aeae58659d77e26", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c3e68960adf52051486e3fb33e9b6f64e263eba", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Click to View Product detail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("cursor:pointer;height:160px;width:100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/81_12_24_2017_10_26_28.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "D:\Etude\2-annee\Session3\Asp.net\LabraryMVC\LabraryMVC\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container"">
    <div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"">
        <!-- Indicators -->
        <ol class=""carousel-indicators"">
            <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
            <li data-target=""#myCarousel"" data-slide-to=""1""></li>
            <li data-target=""#myCarousel"" data-slide-to=""2""></li>
        </ol>

        <!-- Wrapper for slides -->
        <div class=""carousel-inner"">
            <div class=""item active"">
                <img src=""https://foodtank.com/wp-content/uploads/2021/07/alfons-morales-YLSwjSy7stw-unsplash-768x461.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 685, "\"", 691, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%;height:520px\">\r\n            </div>\r\n\r\n            <div class=\"item\">\r\n                <img src=\"https://www.incimages.com/uploaded_files/image/1920x1080/getty_655998316_2000149920009280219_363765.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 911, "\"", 917, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%;height:520px\">\r\n            </div>\r\n\r\n            <div class=\"item\">\r\n                <img src=\"https://www.metsoc.org/wp-content/uploads/2014/09/Books.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1093, "\"", 1099, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""width:100%;height:520px"">
            </div>
        </div>

        <!-- Left and right controls -->
        <a class=""left carousel-control"" href=""#myCarousel"" data-slide=""prev"">
            <span class=""glyphicon glyphicon-chevron-left""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""right carousel-control"" href=""#myCarousel"" data-slide=""next"">
            <span class=""glyphicon glyphicon-chevron-right""></span>
            <span class=""sr-only"">Next</span>
        </a>
    </div>
</div>

<br />

<div class=""form-outline"">
    <h4");
            BeginWriteAttribute("class", " class=\"", 1706, "\"", 1714, 0);
            EndWriteAttribute();
            WriteLiteral(@"><b>Search book</b></h4>
    <input type=""search"" id=""form1"" class=""form-control"" placeholder=""Enter Keyword""
           aria-label=""Search"" />
</div>

<div class=""row"">
    <div class=""col-md-12"">
        <div class=""page-header"">
            <h2>Our Books <small>trends Books</small></h2>
        </div>
    </div>
</div>

<div class=""row product-container"">

    <div class=""col-md-3 col-sm-3 col-xs-6"" style=""margin-bottom:8px"">
        <div class=""thumbnail product-item"" style=""height:300px"">

            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d369046c2dea179e290b88ae7aeae58659d77e267597", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
            WriteLiteral("\r\n\r\n            <div class=\"caption\">\r\n                <h5>Product Name</h5>\r\n                <div class=\"product-item-badge\">New</div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
