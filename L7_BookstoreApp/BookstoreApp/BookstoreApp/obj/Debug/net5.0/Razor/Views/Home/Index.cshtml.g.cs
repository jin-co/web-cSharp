#pragma checksum "C:\Users\jin\Documents\GitHub\web-cSharp\L7_BookstoreApp\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9eb7d028e599647e13671f863e42d1d8735f912"
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
#line 1 "C:\Users\jin\Documents\GitHub\web-cSharp\L7_BookstoreApp\BookstoreApp\BookstoreApp\Views\_ViewImports.cshtml"
using BookstoreApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jin\Documents\GitHub\web-cSharp\L7_BookstoreApp\BookstoreApp\BookstoreApp\Views\_ViewImports.cshtml"
using BookstoreApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9eb7d028e599647e13671f863e42d1d8735f912", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"880f90a60fb1730ff25856cf57ac1e1dd1188e27", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-current", new global::Microsoft.AspNetCore.Html.HtmlString("page"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\jin\Documents\GitHub\web-cSharp\L7_BookstoreApp\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Bookstore";

    string Active(string filter, string selected)
    {
        return (filter.ToLower() == selected.ToLower()) ? "active" : "";
    }

    string BookGenreLabelColour(string genre)
    {
        switch (genre)
        {
            case "Horror":
                return "bg-danger";
            case "Adventure":
                return "bg-warning";
            default:
                return "bg-info";
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-12\">\r\n        <ul class=\"nav nav-tabs\">\r\n");
#nullable restore
#line 28 "C:\Users\jin\Documents\GitHub\web-cSharp\L7_BookstoreApp\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
             foreach (Genre genre in ViewBag.Genres)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"nav-item\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9eb7d028e599647e13671f863e42d1d8735f9126121", async() => {
#nullable restore
#line 35 "C:\Users\jin\Documents\GitHub\web-cSharp\L7_BookstoreApp\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
                                                                       Write(genre.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 727, "nav-link", 727, 8, true);
#nullable restore
#line 31 "C:\Users\jin\Documents\GitHub\web-cSharp\L7_BookstoreApp\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
AddHtmlAttributeValue(" ", 735, Active(genre.GenreID, ViewBag.ActiveGenre), 736, 43, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-activeGenre", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\jin\Documents\GitHub\web-cSharp\L7_BookstoreApp\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
                                  WriteLiteral(genre.GenreID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activeGenre"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-activeGenre", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activeGenre"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "C:\Users\jin\Documents\GitHub\web-cSharp\L7_BookstoreApp\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
                                   WriteLiteral(ViewBag.ActiveAuthor);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activeAuthor"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-activeAuthor", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activeAuthor"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "C:\Users\jin\Documents\GitHub\web-cSharp\L7_BookstoreApp\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
                                      WriteLiteral(ViewBag.ActivePublisher);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activePublisher"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-activePublisher", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activePublisher"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </li>\r\n");
#nullable restore
#line 37 "C:\Users\jin\Documents\GitHub\web-cSharp\L7_BookstoreApp\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-sm-3\">\r\n        <h5 class=\"mt-3\">Author</h5>\r\n        <div class=\"list-group\">\r\n");
#nullable restore
#line 46 "C:\Users\jin\Documents\GitHub\web-cSharp\L7_BookstoreApp\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
             foreach (Author author in ViewBag.Authors)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9eb7d028e599647e13671f863e42d1d8735f91211325", async() => {
                WriteLiteral("\r\n                    ");
#nullable restore
#line 54 "C:\Users\jin\Documents\GitHub\web-cSharp\L7_BookstoreApp\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
               Write(author.FullName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-activeGenre", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "C:\Users\jin\Documents\GitHub\web-cSharp\L7_BookstoreApp\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
                              WriteLiteral(ViewBag.ActiveGenre);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activeGenre"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-activeGenre", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activeGenre"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\jin\Documents\GitHub\web-cSharp\L7_BookstoreApp\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
                               WriteLiteral(author.AuthorID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activeAuthor"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-activeAuthor", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activeAuthor"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "C:\Users\jin\Documents\GitHub\web-cSharp\L7_BookstoreApp\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
                                  WriteLiteral(ViewBag.ActivePublisher);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activePublisher"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-activePublisher", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activePublisher"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1580, "list-group-item", 1580, 15, true);
#nullable restore
#line 52 "C:\Users\jin\Documents\GitHub\web-cSharp\L7_BookstoreApp\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
AddHtmlAttributeValue(" ", 1595, Active(author.AuthorID,
                                           ViewBag.ActiveAuthor), 1596, 90, false);

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
            WriteLiteral("\r\n");
#nullable restore
#line 56 "C:\Users\jin\Documents\GitHub\web-cSharp\L7_BookstoreApp\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <h5 class=\"mt-3\">Publisher</h5>\r\n        <div class=\"list-group mb-3\">\r\n");
#nullable restore
#line 60 "C:\Users\jin\Documents\GitHub\web-cSharp\L7_BookstoreApp\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
             foreach (Publisher publisher in ViewBag.Publishers)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9eb7d028e599647e13671f863e42d1d8735f91216666", async() => {
                WriteLiteral("\r\n                    ");
#nullable restore
#line 68 "C:\Users\jin\Documents\GitHub\web-cSharp\L7_BookstoreApp\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
               Write(publisher.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-activeGenre", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "C:\Users\jin\Documents\GitHub\web-cSharp\L7_BookstoreApp\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
                              WriteLiteral(ViewBag.ActiveGenre);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activeGenre"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-activeGenre", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activeGenre"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "C:\Users\jin\Documents\GitHub\web-cSharp\L7_BookstoreApp\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
                               WriteLiteral(ViewBag.ActiveAuthor);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activeAuthor"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-activeAuthor", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activeAuthor"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "C:\Users\jin\Documents\GitHub\web-cSharp\L7_BookstoreApp\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
                                  WriteLiteral(publisher.PublisherID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activePublisher"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-activePublisher", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activePublisher"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2202, "list-group-item", 2202, 15, true);
#nullable restore
#line 66 "C:\Users\jin\Documents\GitHub\web-cSharp\L7_BookstoreApp\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
AddHtmlAttributeValue(" ", 2217, Active(publisher.PublisherID,
                                           ViewBag.ActivePublisher), 2218, 99, false);

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
            WriteLiteral("\r\n");
#nullable restore
#line 70 "C:\Users\jin\Documents\GitHub\web-cSharp\L7_BookstoreApp\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n    <div class=\"col-sm-9\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 75 "C:\Users\jin\Documents\GitHub\web-cSharp\L7_BookstoreApp\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
             foreach (Book book in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-sm-6 col-md-4 mt-2 text-center\">\r\n                    <div><h6>");
#nullable restore
#line 78 "C:\Users\jin\Documents\GitHub\web-cSharp\L7_BookstoreApp\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
                        Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 78 "C:\Users\jin\Documents\GitHub\web-cSharp\L7_BookstoreApp\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
                                      Write(book.Price.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6></div>\r\n                    <div>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c9eb7d028e599647e13671f863e42d1d8735f91222700", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2766, "~/images/", 2766, 9, true);
#nullable restore
#line 80 "C:\Users\jin\Documents\GitHub\web-cSharp\L7_BookstoreApp\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2775, book.LogoImageSource, 2775, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 80 "C:\Users\jin\Documents\GitHub\web-cSharp\L7_BookstoreApp\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2803, book.Title, 2803, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 8, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 81 "C:\Users\jin\Documents\GitHub\web-cSharp\L7_BookstoreApp\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2878, book.Title, 2878, 11, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue(" ", 2889, "|", 2890, 2, true);
#nullable restore
#line 81 "C:\Users\jin\Documents\GitHub\web-cSharp\L7_BookstoreApp\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
AddHtmlAttributeValue(" ", 2891, book.Author.FullName, 2892, 21, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2913, ",", 2913, 1, true);
#nullable restore
#line 81 "C:\Users\jin\Documents\GitHub\web-cSharp\L7_BookstoreApp\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
AddHtmlAttributeValue(" ", 2914, book.Genre.Name, 2915, 16, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue(" ", 2931, "(", 2932, 2, true);
#nullable restore
#line 81 "C:\Users\jin\Documents\GitHub\web-cSharp\L7_BookstoreApp\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2933, book.Publisher.Name, 2933, 20, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2953, ")", 2953, 1, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <div>\r\n                        <span class=\"badge bg-primary text-light\">");
#nullable restore
#line 84 "C:\Users\jin\Documents\GitHub\web-cSharp\L7_BookstoreApp\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
                                                             Write(book.Author.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <span");
            BeginWriteAttribute("class", " class=\"", 3140, "\"", 3205, 3);
            WriteAttributeValue("", 3148, "badge", 3148, 5, true);
#nullable restore
#line 85 "C:\Users\jin\Documents\GitHub\web-cSharp\L7_BookstoreApp\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 3153, BookGenreLabelColour(book.Genre.Name), 3154, 40, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 3194, "text-light", 3195, 11, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 85 "C:\Users\jin\Documents\GitHub\web-cSharp\L7_BookstoreApp\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
                                                                                           Write(book.Genre.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <span class=\"badge bg-secondary text-light\">");
#nullable restore
#line 86 "C:\Users\jin\Documents\GitHub\web-cSharp\L7_BookstoreApp\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
                                                               Write(book.Publisher.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 89 "C:\Users\jin\Documents\GitHub\web-cSharp\L7_BookstoreApp\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
