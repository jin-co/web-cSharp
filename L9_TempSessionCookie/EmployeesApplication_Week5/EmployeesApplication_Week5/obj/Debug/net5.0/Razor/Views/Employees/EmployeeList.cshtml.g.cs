#pragma checksum "C:\Users\jin\Desktop\1.conestoga\0_Semester_3\2.MicrosoftWebTech(2230)\lab\solution\TempSessionCookie\EmployeesApplication_Week5\EmployeesApplication_Week5\Views\Employees\EmployeeList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55fd07aed64e96a4804fa53ac8fb173df414463b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_EmployeeList), @"mvc.1.0.view", @"/Views/Employees/EmployeeList.cshtml")]
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
#line 1 "C:\Users\jin\Desktop\1.conestoga\0_Semester_3\2.MicrosoftWebTech(2230)\lab\solution\TempSessionCookie\EmployeesApplication_Week5\EmployeesApplication_Week5\Views\_ViewImports.cshtml"
using EmployeesApplication_Week5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jin\Desktop\1.conestoga\0_Semester_3\2.MicrosoftWebTech(2230)\lab\solution\TempSessionCookie\EmployeesApplication_Week5\EmployeesApplication_Week5\Views\_ViewImports.cshtml"
using EmployeesApplication_Week5.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jin\Desktop\1.conestoga\0_Semester_3\2.MicrosoftWebTech(2230)\lab\solution\TempSessionCookie\EmployeesApplication_Week5\EmployeesApplication_Week5\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55fd07aed64e96a4804fa53ac8fb173df414463b", @"/Views/Employees/EmployeeList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1019561ef2e9dc2b5c6743b3012c2dd4ca83bd9d", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_EmployeeList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EmployeesApplication_Week5.Models.Employee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Companies", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\jin\Desktop\1.conestoga\0_Semester_3\2.MicrosoftWebTech(2230)\lab\solution\TempSessionCookie\EmployeesApplication_Week5\EmployeesApplication_Week5\Views\Employees\EmployeeList.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 7 "C:\Users\jin\Desktop\1.conestoga\0_Semester_3\2.MicrosoftWebTech(2230)\lab\solution\TempSessionCookie\EmployeesApplication_Week5\EmployeesApplication_Week5\Views\Employees\EmployeeList.cshtml"
Write(ViewBag.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h2>");
#nullable restore
#line 8 "C:\Users\jin\Desktop\1.conestoga\0_Semester_3\2.MicrosoftWebTech(2230)\lab\solution\TempSessionCookie\EmployeesApplication_Week5\EmployeesApplication_Week5\Views\Employees\EmployeeList.cshtml"
Write(ViewBag.TickerSymbol);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55fd07aed64e96a4804fa53ac8fb173df414463b6365", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\jin\Desktop\1.conestoga\0_Semester_3\2.MicrosoftWebTech(2230)\lab\solution\TempSessionCookie\EmployeesApplication_Week5\EmployeesApplication_Week5\Views\Employees\EmployeeList.cshtml"
           Write(Html.DisplayNameFor(model => model.Company.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\jin\Desktop\1.conestoga\0_Semester_3\2.MicrosoftWebTech(2230)\lab\solution\TempSessionCookie\EmployeesApplication_Week5\EmployeesApplication_Week5\Views\Employees\EmployeeList.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\jin\Desktop\1.conestoga\0_Semester_3\2.MicrosoftWebTech(2230)\lab\solution\TempSessionCookie\EmployeesApplication_Week5\EmployeesApplication_Week5\Views\Employees\EmployeeList.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\jin\Desktop\1.conestoga\0_Semester_3\2.MicrosoftWebTech(2230)\lab\solution\TempSessionCookie\EmployeesApplication_Week5\EmployeesApplication_Week5\Views\Employees\EmployeeList.cshtml"
           Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Role\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 36 "C:\Users\jin\Desktop\1.conestoga\0_Semester_3\2.MicrosoftWebTech(2230)\lab\solution\TempSessionCookie\EmployeesApplication_Week5\EmployeesApplication_Week5\Views\Employees\EmployeeList.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <tr>
                <td>
                    <!-- Clicking on the company name entry within each record will promptly redirect the
                        user to the /Companies/Edit/1 routing path in order to allow users to edit the specified
                        company entries' information. -->
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55fd07aed64e96a4804fa53ac8fb173df414463b10146", async() => {
                WriteLiteral("\r\n                        ");
#nullable restore
#line 44 "C:\Users\jin\Desktop\1.conestoga\0_Semester_3\2.MicrosoftWebTech(2230)\lab\solution\TempSessionCookie\EmployeesApplication_Week5\EmployeesApplication_Week5\Views\Employees\EmployeeList.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Company.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "C:\Users\jin\Desktop\1.conestoga\0_Semester_3\2.MicrosoftWebTech(2230)\lab\solution\TempSessionCookie\EmployeesApplication_Week5\EmployeesApplication_Week5\Views\Employees\EmployeeList.cshtml"
                                                                       WriteLiteral(item.CompanyID);

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
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "C:\Users\jin\Desktop\1.conestoga\0_Semester_3\2.MicrosoftWebTech(2230)\lab\solution\TempSessionCookie\EmployeesApplication_Week5\EmployeesApplication_Week5\Views\Employees\EmployeeList.cshtml"
               Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "C:\Users\jin\Desktop\1.conestoga\0_Semester_3\2.MicrosoftWebTech(2230)\lab\solution\TempSessionCookie\EmployeesApplication_Week5\EmployeesApplication_Week5\Views\Employees\EmployeeList.cshtml"
               Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 54 "C:\Users\jin\Desktop\1.conestoga\0_Semester_3\2.MicrosoftWebTech(2230)\lab\solution\TempSessionCookie\EmployeesApplication_Week5\EmployeesApplication_Week5\Views\Employees\EmployeeList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 57 "C:\Users\jin\Desktop\1.conestoga\0_Semester_3\2.MicrosoftWebTech(2230)\lab\solution\TempSessionCookie\EmployeesApplication_Week5\EmployeesApplication_Week5\Views\Employees\EmployeeList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Role.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55fd07aed64e96a4804fa53ac8fb173df414463b14929", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\jin\Desktop\1.conestoga\0_Semester_3\2.MicrosoftWebTech(2230)\lab\solution\TempSessionCookie\EmployeesApplication_Week5\EmployeesApplication_Week5\Views\Employees\EmployeeList.cshtml"
                                           WriteLiteral(item.EmployeeID);

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
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55fd07aed64e96a4804fa53ac8fb173df414463b17223", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "C:\Users\jin\Desktop\1.conestoga\0_Semester_3\2.MicrosoftWebTech(2230)\lab\solution\TempSessionCookie\EmployeesApplication_Week5\EmployeesApplication_Week5\Views\Employees\EmployeeList.cshtml"
                                              WriteLiteral(item.EmployeeID);

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
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55fd07aed64e96a4804fa53ac8fb173df414463b19523", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "C:\Users\jin\Desktop\1.conestoga\0_Semester_3\2.MicrosoftWebTech(2230)\lab\solution\TempSessionCookie\EmployeesApplication_Week5\EmployeesApplication_Week5\Views\Employees\EmployeeList.cshtml"
                                             WriteLiteral(item.EmployeeID);

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
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 65 "C:\Users\jin\Desktop\1.conestoga\0_Semester_3\2.MicrosoftWebTech(2230)\lab\solution\TempSessionCookie\EmployeesApplication_Week5\EmployeesApplication_Week5\Views\Employees\EmployeeList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EmployeesApplication_Week5.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
