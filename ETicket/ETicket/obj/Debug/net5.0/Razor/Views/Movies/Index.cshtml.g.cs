#pragma checksum "C:\Users\jin\Documents\GitHub\web-cSharp\ETicket\ETicket\Views\Movies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "287f20674b1fc28b089254ca282c9e59b7b3971b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Index), @"mvc.1.0.view", @"/Views/Movies/Index.cshtml")]
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
#line 1 "C:\Users\jin\Documents\GitHub\web-cSharp\ETicket\ETicket\Views\_ViewImports.cshtml"
using ETicket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jin\Documents\GitHub\web-cSharp\ETicket\ETicket\Views\_ViewImports.cshtml"
using ETicket.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"287f20674b1fc28b089254ca282c9e59b7b3971b", @"/Views/Movies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbcd1179f2872963ce41c50fd3dde2a18c896f85", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Movie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-white float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddItemToShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\jin\Documents\GitHub\web-cSharp\ETicket\ETicket\Views\Movies\Index.cshtml"
   ViewData["Title"] = "List of Movies"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row\">\n");
#nullable restore
#line 6 "C:\Users\jin\Documents\GitHub\web-cSharp\ETicket\ETicket\Views\Movies\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""col-md-4 col-xs-6 border-primary mb-3"">
    <div class=""card mb-3"" style=""max-width: 540px;"">
        <div class=""row g-0"">
            <div class=""col-md-12"">
                <div class=""card-header text-white bg-info"">
                    <p class=""card-text"">
                        <h5 class=""card-title"">
                            ");
#nullable restore
#line 15 "C:\Users\jin\Documents\GitHub\web-cSharp\ETicket\ETicket\Views\Movies\Index.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 16 "C:\Users\jin\Documents\GitHub\web-cSharp\ETicket\ETicket\Views\Movies\Index.cshtml"
                             if (User.Identity.IsAuthenticated && User.IsInRole("Admin"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "287f20674b1fc28b089254ca282c9e59b7b3971b6489", async() => {
                WriteLiteral("\n                                    <i class=\"bi bi-pencil-square\"></i>\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "C:\Users\jin\Documents\GitHub\web-cSharp\ETicket\ETicket\Views\Movies\Index.cshtml"
                                     WriteLiteral(item.Id);

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
            WriteLiteral("\n");
#nullable restore
#line 23 "C:\Users\jin\Documents\GitHub\web-cSharp\ETicket\ETicket\Views\Movies\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </h5>\n                    </p>\n                </div>\n            </div>\n            <div class=\"col-md-6\">\n                <img");
            BeginWriteAttribute("src", " src=\"", 1080, "\"", 1100, 1);
#nullable restore
#line 29 "C:\Users\jin\Documents\GitHub\web-cSharp\ETicket\ETicket\Views\Movies\Index.cshtml"
WriteAttributeValue("", 1086, item.ImageURL, 1086, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100%\"");
            BeginWriteAttribute("alt", " alt=\"", 1114, "\"", 1130, 1);
#nullable restore
#line 29 "C:\Users\jin\Documents\GitHub\web-cSharp\ETicket\ETicket\Views\Movies\Index.cshtml"
WriteAttributeValue("", 1120, item.Name, 1120, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n            </div>\n            <div class=\"col-md-6\">\n                <div class=\"card-body\">\n                    <p class=\"card-text\">");
#nullable restore
#line 33 "C:\Users\jin\Documents\GitHub\web-cSharp\ETicket\ETicket\Views\Movies\Index.cshtml"
                                    Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <p class=\"card-text\">\n                        <b>Cinema: </b>");
#nullable restore
#line 35 "C:\Users\jin\Documents\GitHub\web-cSharp\ETicket\ETicket\Views\Movies\Index.cshtml"
                                  Write(item.Cinema.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </p>\n                    <p class=\"card-text\">\n                        <b>Category: </b>");
#nullable restore
#line 38 "C:\Users\jin\Documents\GitHub\web-cSharp\ETicket\ETicket\Views\Movies\Index.cshtml"
                                    Write(item.MovieCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </p>\n                    <p class=\"card-text\">\n                        <b>Start Date: </b>");
#nullable restore
#line 41 "C:\Users\jin\Documents\GitHub\web-cSharp\ETicket\ETicket\Views\Movies\Index.cshtml"
                                      Write(item.StartDate.ToString("dd MMM yy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </p>\n                    <p class=\"card-text\">\n                        <b>End Date: </b>");
#nullable restore
#line 44 "C:\Users\jin\Documents\GitHub\web-cSharp\ETicket\ETicket\Views\Movies\Index.cshtml"
                                    Write(item.EndDate.ToString("dd MMM yy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </p>\n                    <p class=\"card-text \">\n                        <b>Status: </b>\n");
#nullable restore
#line 48 "C:\Users\jin\Documents\GitHub\web-cSharp\ETicket\ETicket\Views\Movies\Index.cshtml"
                         if (DateTime.Now >= item.StartDate
                           && DateTime.Now <= item.EndDate)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"badge bg-success text-white\">AVAILABLE</span> ");
#nullable restore
#line 51 "C:\Users\jin\Documents\GitHub\web-cSharp\ETicket\ETicket\Views\Movies\Index.cshtml"
                                                                                       }
                        else if (DateTime.Now > item.EndDate)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"badge bg-danger text-white\">EXPIRED</span> ");
#nullable restore
#line 54 "C:\Users\jin\Documents\GitHub\web-cSharp\ETicket\ETicket\Views\Movies\Index.cshtml"
                                                                                    }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"badge bg-primary text-white\">UPCOMING</span>");
#nullable restore
#line 57 "C:\Users\jin\Documents\GitHub\web-cSharp\ETicket\ETicket\Views\Movies\Index.cshtml"
                                                                                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </p>\n                </div>\n            </div>\n            <div class=\"col-md-12\">\n                <div class=\"card-footer \">\n                    <p class=\"card-text\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "287f20674b1fc28b089254ca282c9e59b7b3971b13788", async() => {
                WriteLiteral("\n                            <i class=\"bi bi-eye-fill\"></i> Show Details\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "C:\Users\jin\Documents\GitHub\web-cSharp\ETicket\ETicket\Views\Movies\Index.cshtml"
                                                  WriteLiteral(item.Id);

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
            WriteLiteral("\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "287f20674b1fc28b089254ca282c9e59b7b3971b16152", async() => {
                WriteLiteral("\n                            <i class=\"bi bi-cart-plus\"></i>\n                            Add to Cart (Price ");
#nullable restore
#line 74 "C:\Users\jin\Documents\GitHub\web-cSharp\ETicket\ETicket\Views\Movies\Index.cshtml"
                                          Write(item.Price.ToString("c"));

#line default
#line hidden
#nullable disable
                WriteLiteral(")\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2935, "btn", 2935, 3, true);
            AddHtmlAttributeValue(" ", 2938, "btn-success", 2939, 12, true);
            AddHtmlAttributeValue(" ", 2950, "text-white", 2951, 11, true);
#nullable restore
#line 68 "C:\Users\jin\Documents\GitHub\web-cSharp\ETicket\ETicket\Views\Movies\Index.cshtml"
AddHtmlAttributeValue("\n                           ", 2961, (DateTime.Now > item.EndDate) ? "disabled" : "", 2989, 50, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "C:\Users\jin\Documents\GitHub\web-cSharp\ETicket\ETicket\Views\Movies\Index.cshtml"
                             WriteLiteral(item.Id);

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
            WriteLiteral("\n                    </p>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>");
#nullable restore
#line 81 "C:\Users\jin\Documents\GitHub\web-cSharp\ETicket\ETicket\Views\Movies\Index.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n");
#nullable restore
#line 84 "C:\Users\jin\Documents\GitHub\web-cSharp\ETicket\ETicket\Views\Movies\Index.cshtml"
Write(await Html.PartialAsync("PartialViews/_CreateItem", "Movies"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
