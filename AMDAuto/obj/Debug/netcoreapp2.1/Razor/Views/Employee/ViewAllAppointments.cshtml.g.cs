#pragma checksum "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Employee\ViewAllAppointments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea7bc6508c9d6794156a8e3c6cd66ff84431e5c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_ViewAllAppointments), @"mvc.1.0.view", @"/Views/Employee/ViewAllAppointments.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/ViewAllAppointments.cshtml", typeof(AspNetCore.Views_Employee_ViewAllAppointments))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea7bc6508c9d6794156a8e3c6cd66ff84431e5c1", @"/Views/Employee/ViewAllAppointments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"055a7cf4c463b34b504c7f7b2be136bdf0b5dc5a", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_ViewAllAppointments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PendingAppointmentsList>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/ListTableDisplay.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "select", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control statuses"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Appointment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AppointmentDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info col-md-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditAppointment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success col-md-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/ChangeStatus.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/TakeAppointment.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/DeleteAppointment.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("style", async() => {
                BeginContext(49, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(55, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "42541e4c66b047faba56bcdf4e1b2d20", async() => {
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
                BeginContext(114, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(119, 525, true);
            WriteLiteral(@"

<table class=""table"">
    <thead class=""table-dark"">
        <tr class=""col-md-12 row rowHeader"">
            <th scope=""col"" class=""text-md-center col-md-2"">Marca</th>
            <th scope=""col"" class=""text-md-center col-md-2"">Model</th>
            <th scope=""col"" class=""text-md-center col-md-3"">Operatia</th>
            <th scope=""col"" class=""text-md-center col-md-3"">Data</th>
            <th scope=""col"" class=""text-md-center col-md-2 lastHeader"">Status</th>
        </tr>

    </thead>

    <tbody>
");
            EndContext();
#line 21 "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Employee\ViewAllAppointments.cshtml"
         foreach (var app in Model.PendingAppointments)
        {

#line default
#line hidden
            BeginContext(712, 116, true);
            WriteLiteral("            <tr class=\"col-md-12 row rowData\">\r\n                <td scope=\"row\" class=\"text-md-center col-md-2\"><h4>");
            EndContext();
            BeginContext(829, 11, false);
#line 24 "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Employee\ViewAllAppointments.cshtml"
                                                               Write(app.CarMake);

#line default
#line hidden
            EndContext();
            BeginContext(840, 80, true);
            WriteLiteral("</h4></td>\r\n                <td scope=\"row\" class=\"text-md-center col-md-2\"><h4>");
            EndContext();
            BeginContext(921, 12, false);
#line 25 "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Employee\ViewAllAppointments.cshtml"
                                                               Write(app.CarModel);

#line default
#line hidden
            EndContext();
            BeginContext(933, 80, true);
            WriteLiteral("</h4></td>\r\n                <td scope=\"row\" class=\"text-md-center col-md-3\"><h5>");
            EndContext();
            BeginContext(1014, 17, false);
#line 26 "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Employee\ViewAllAppointments.cshtml"
                                                               Write(app.OperationName);

#line default
#line hidden
            EndContext();
            BeginContext(1031, 80, true);
            WriteLiteral("</h5></td>\r\n                <td scope=\"row\" class=\"text-md-center col-md-3\"><h4>");
            EndContext();
            BeginContext(1112, 22, false);
#line 27 "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Employee\ViewAllAppointments.cshtml"
                                                               Write(app.ScheduledOnDisplay);

#line default
#line hidden
            EndContext();
            BeginContext(1134, 78, true);
            WriteLiteral("</h4></td>\r\n                <td scope=\"row\" class=\"text-md-center col-md-2\">\r\n");
            EndContext();
#line 29 "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Employee\ViewAllAppointments.cshtml"
                     if (app.IsEditable)
                    {

#line default
#line hidden
            BeginContext(1277, 82, true);
            WriteLiteral("                        <div class=\"text-md-center\">\r\n                            ");
            EndContext();
            BeginContext(1359, 229, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cba662d53cd24ba997158a0efa044c4a", async() => {
                BeginContext(1452, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(1486, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eac3098c94b44027993d748e7c77d141", async() => {
                    BeginContext(1534, 6, true);
                    WriteLiteral("Select");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1549, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            BeginWriteTagHelperAttribute();
#line 32 "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Employee\ViewAllAppointments.cshtml"
                                                    Write(app.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-appointment-id", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 32 "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Employee\ViewAllAppointments.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = app.Statuses;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1588, 34, true);
            WriteLiteral("\r\n                        </div>\r\n");
            EndContext();
#line 36 "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Employee\ViewAllAppointments.cshtml"
                    }
                    else
                    {
                        if (app.StatusName != null)
                        {

#line default
#line hidden
            BeginContext(1774, 47, true);
            WriteLiteral("                            <h4 class=\"status\">");
            EndContext();
            BeginContext(1822, 14, false);
#line 41 "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Employee\ViewAllAppointments.cshtml"
                                          Write(app.StatusName);

#line default
#line hidden
            EndContext();
            BeginContext(1836, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
#line 42 "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Employee\ViewAllAppointments.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1927, 66, true);
            WriteLiteral("                            <h4 class=\"status\">Nespecificat</h4>\r\n");
            EndContext();
#line 46 "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Employee\ViewAllAppointments.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(2043, 109, true);
            WriteLiteral("                </td>\r\n\r\n\r\n                <td class=\"butoaneTabel  align-items-center col-md-12 noBorder\">\r\n");
            EndContext();
#line 52 "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Employee\ViewAllAppointments.cshtml"
                     if (app.IsEditable)
                    {

#line default
#line hidden
            BeginContext(2217, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(2241, 142, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be234092fdf84da39fb763bc96adc90a", async() => {
                BeginContext(2372, 7, true);
                WriteLiteral("Detalii");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 54 "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Employee\ViewAllAppointments.cshtml"
                                                                                          WriteLiteral(app.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2383, 109, true);
            WriteLiteral("\r\n                        <a role=\"button\" class=\"btn btn-danger deleteButton col-md-3\" data-appointment-id=\"");
            EndContext();
            BeginContext(2493, 6, false);
#line 55 "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Employee\ViewAllAppointments.cshtml"
                                                                                                      Write(app.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2499, 59, true);
            WriteLiteral("\" style=\"color: white\">Șterge</a>\r\n                        ");
            EndContext();
            BeginContext(2558, 143, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d4a89af739b4e45bc4ff5a127043e70", async() => {
                BeginContext(2689, 8, true);
                WriteLiteral("Editează");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 56 "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Employee\ViewAllAppointments.cshtml"
                                                                                       WriteLiteral(app.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2701, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 57 "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Employee\ViewAllAppointments.cshtml"
                    }

#line default
#line hidden
            BeginContext(2726, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 58 "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Employee\ViewAllAppointments.cshtml"
                     if (app.EmployeeId != Guid.Empty)
                    {


#line default
#line hidden
            BeginContext(2807, 84, true);
            WriteLiteral("                        <p id=\"mechanic\" class=\"text-center\">Programare preluata de ");
            EndContext();
            BeginContext(2892, 16, false);
#line 61 "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Employee\ViewAllAppointments.cshtml"
                                                                               Write(app.EmployeeName);

#line default
#line hidden
            EndContext();
            BeginContext(2908, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 62 "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Employee\ViewAllAppointments.cshtml"

                    }

                    else
                    {

#line default
#line hidden
            BeginContext(2990, 112, true);
            WriteLiteral("                        <a role=\"button\" class=\"btn btn-success col-md-12 TakeAppointment\" data-appointment-id=\"");
            EndContext();
            BeginContext(3103, 6, false);
#line 67 "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Employee\ViewAllAppointments.cshtml"
                                                                                                           Write(app.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3109, 45, true);
            WriteLiteral("\" style=\"color: white\">Preia programare</a>\r\n");
            EndContext();
#line 68 "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Employee\ViewAllAppointments.cshtml"
                    }

#line default
#line hidden
            BeginContext(3177, 48, true);
            WriteLiteral("\r\n                </td>\r\n\r\n\r\n            </tr>\r\n");
            EndContext();
#line 74 "G:\Licenta\AMDAutoIUNIE\AMDAuto\AMDAuto\Views\Employee\ViewAllAppointments.cshtml"

        }

#line default
#line hidden
            BeginContext(3238, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(3281, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3287, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5041114e6944aaca686bcd3b7a973d8", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3331, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3337, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fadfd92137f746398200ce5a2557bea6", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3384, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3390, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8da3085f5ab47208db1ca18625a5353", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3439, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PendingAppointmentsList> Html { get; private set; }
    }
}
#pragma warning restore 1591
