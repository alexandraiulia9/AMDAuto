#pragma checksum "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Cars\GetCarsOfUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "318f5365af9f7b524eb95426c662dc2f23a150c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_GetCarsOfUser), @"mvc.1.0.view", @"/Views/Cars/GetCarsOfUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cars/GetCarsOfUser.cshtml", typeof(AspNetCore.Views_Cars_GetCarsOfUser))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"318f5365af9f7b524eb95426c662dc2f23a150c7", @"/Views/Cars/GetCarsOfUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"055a7cf4c463b34b504c7f7b2be136bdf0b5dc5a", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_GetCarsOfUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserCarsVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/CarListView.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cars", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddCar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning addNewCar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/DeleteCar.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("style", async() => {
                BeginContext(89, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(97, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "83c9c52ff0504872959ed51715fddd89", async() => {
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
                BeginContext(151, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(156, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(158, 143, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea4bce251edb41e09801c5030329f408", async() => {
                BeginContext(284, 13, true);
                WriteLiteral("Adaugă mașină");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 8 "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Cars\GetCarsOfUser.cshtml"
                                                   WriteLiteral(Model.UserId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(301, 274, true);
            WriteLiteral(@"
<table class=""table"">
    <thead class=""table-dark "">
        <tr class="""">
            <th class="" text-center"" scope=""col"">Nr inmatriculare</th>
            <th class=""text-center"" scope=""col"">Marca</th>
            <th class="" text-center"" scope=""col"">Model</th>
");
            EndContext();
#line 15 "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Cars\GetCarsOfUser.cshtml"
             if (CurrentUser.RoleId == Guid.Parse("DC043412-4FF5-4C80-BC4F-7F6C37F851C0"))
            {

#line default
#line hidden
            BeginContext(682, 54, true);
            WriteLiteral("                <th class=\"text-center\">Actiuni</th>\r\n");
            EndContext();
#line 18 "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Cars\GetCarsOfUser.cshtml"
            }

#line default
#line hidden
            BeginContext(751, 46, true);
            WriteLiteral("\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 24 "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Cars\GetCarsOfUser.cshtml"
         foreach (var car in Model.UserCars)
        {

#line default
#line hidden
            BeginContext(854, 75, true);
            WriteLiteral("            <tr class=\"\">\r\n                <td class=\" text-md-center\"><h4>");
            EndContext();
            BeginContext(930, 17, false);
#line 27 "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Cars\GetCarsOfUser.cshtml"
                                           Write(car.LicenseNumber);

#line default
#line hidden
            EndContext();
            BeginContext(947, 60, true);
            WriteLiteral("</h4></td>\r\n                <td class=\" text-md-center\"><h4>");
            EndContext();
            BeginContext(1008, 14, false);
#line 28 "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Cars\GetCarsOfUser.cshtml"
                                           Write(car.MakeNameId);

#line default
#line hidden
            EndContext();
            BeginContext(1022, 60, true);
            WriteLiteral("</h4></td>\r\n                <td class=\" text-md-center\"><h4>");
            EndContext();
            BeginContext(1083, 15, false);
#line 29 "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Cars\GetCarsOfUser.cshtml"
                                           Write(car.ModelNameId);

#line default
#line hidden
            EndContext();
            BeginContext(1098, 12, true);
            WriteLiteral("</h4></td>\r\n");
            EndContext();
#line 30 "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Cars\GetCarsOfUser.cshtml"
                 if (CurrentUser.RoleId == Guid.Parse("DC043412-4FF5-4C80-BC4F-7F6C37F851C0"))
                {

#line default
#line hidden
            BeginContext(1225, 146, true);
            WriteLiteral("                    <td class=\" text-md-center\">\r\n                        <div class=\"butoaneTabel\">\r\n                            <a data-car-id=\"");
            EndContext();
            BeginContext(1372, 6, false);
#line 34 "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Cars\GetCarsOfUser.cshtml"
                                       Write(car.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1378, 120, true);
            WriteLiteral("\" role=\"button\" class=\"btn btn-danger deleteCar\">Șterge</a>\r\n                        </div>\r\n                    </td>\r\n");
            EndContext();
#line 37 "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Cars\GetCarsOfUser.cshtml"
                }

#line default
#line hidden
            BeginContext(1517, 21, true);
            WriteLiteral("\r\n            </tr>\r\n");
            EndContext();
#line 40 "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Cars\GetCarsOfUser.cshtml"

        }

#line default
#line hidden
            BeginContext(1551, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            BeginContext(1577, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12caaaa3bd6a43c9a77608aa36e03a9a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public AMDAuto.Entities.DTOs.CurrentUser CurrentUser { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserCarsVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
