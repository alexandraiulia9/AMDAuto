#pragma checksum "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Gallery\ViewGallery.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da52cb1edc7c6fb25c405e7fb758d97976fbe5c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gallery_ViewGallery), @"mvc.1.0.view", @"/Views/Gallery/ViewGallery.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Gallery/ViewGallery.cshtml", typeof(AspNetCore.Views_Gallery_ViewGallery))]
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
#line 1 "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\_ViewImports.cshtml"
using AMDAuto;

#line default
#line hidden
#line 2 "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\_ViewImports.cshtml"
using AMDAuto.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da52cb1edc7c6fb25c405e7fb758d97976fbe5c1", @"/Views/Gallery/ViewGallery.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"055a7cf4c463b34b504c7f7b2be136bdf0b5dc5a", @"/Views/_ViewImports.cshtml")]
    public class Views_Gallery_ViewGallery : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GalleryVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Gallery.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/lightbox.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(18, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("style", async() => {
                BeginContext(35, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(41, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e204873ea21e48e291a09f9a5893ae42", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(91, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(157, 175, true);
            WriteLiteral("\r\n<h3>Faceți un tur virtual al altelierului nostru!</h3>\r\n\r\n<div id=\"carouselExampleControls\" class=\"carousel slide \" data-ride=\"carousel\">\r\n    <div class=\"carousel-inner\">\r\n");
            EndContext();
#line 12 "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Gallery\ViewGallery.cshtml"
         for (var i = 0; i < Model.Photos.Count; i++)
        {
            if (i == 0)
            {

#line default
#line hidden
            BeginContext(438, 89, true);
            WriteLiteral("                <div class=\"carousel-item active imgsCarousel\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 527, "\"", 577, 2);
            WriteAttributeValue("", 533, "/Gallery/GetPhotoById?id=", 533, 25, true);
#line 17 "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Gallery\ViewGallery.cshtml"
WriteAttributeValue("", 558, Model.Photos[i].Id, 558, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(578, 49, true);
            WriteLiteral(" class=\"d-block\" albumPhoto Photo data-photo-id=\"");
            EndContext();
            BeginContext(628, 18, false);
#line 17 "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Gallery\ViewGallery.cshtml"
                                                                                                                       Write(Model.Photos[i].Id);

#line default
#line hidden
            EndContext();
            BeginContext(646, 30, true);
            WriteLiteral("\" />\r\n                </div>\r\n");
            EndContext();
#line 19 "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Gallery\ViewGallery.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(724, 69, true);
            WriteLiteral("                <div class=\"carousel-item\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 793, "\"", 843, 2);
            WriteAttributeValue("", 799, "/Gallery/GetPhotoById?id=", 799, 25, true);
#line 23 "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Gallery\ViewGallery.cshtml"
WriteAttributeValue("", 824, Model.Photos[i].Id, 824, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(844, 49, true);
            WriteLiteral(" class=\"d-block\" albumPhoto Photo data-photo-id=\"");
            EndContext();
            BeginContext(894, 18, false);
#line 23 "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Gallery\ViewGallery.cshtml"
                                                                                                                       Write(Model.Photos[i].Id);

#line default
#line hidden
            EndContext();
            BeginContext(912, 30, true);
            WriteLiteral("\" />\r\n                </div>\r\n");
            EndContext();
#line 25 "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Gallery\ViewGallery.cshtml"
            }

        }

#line default
#line hidden
            BeginContext(970, 494, true);
            WriteLiteral(@"    </div>
    <a class=""carousel-control-prev"" href=""#carouselExampleControls"" role=""button"" data-slide=""prev"">
        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Previous</span>
    </a>
    <a class=""carousel-control-next"" href=""#carouselExampleControls"" role=""button"" data-slide=""next"">
        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Next</span>
    </a>
</div>


");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1481, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(1489, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2a6ca44e6a941ae8118231b64cfe840", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1529, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GalleryVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
