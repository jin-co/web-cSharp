#pragma checksum "C:\Users\jin\Documents\GitHub\web-cSharp\A5_QuarterlySalesApp\QuarterlySales\Views\Shared\Components\TopQuartersByEmployee\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b26313fe38176ff864a402b8ad45c63f79e8073"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TopQuartersByEmployee_Default), @"mvc.1.0.view", @"/Views/Shared/Components/TopQuartersByEmployee/Default.cshtml")]
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
#line 1 "C:\Users\jin\Documents\GitHub\web-cSharp\A5_QuarterlySalesApp\QuarterlySales\Views\_ViewImports.cshtml"
using QuarterlySales;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jin\Documents\GitHub\web-cSharp\A5_QuarterlySalesApp\QuarterlySales\Views\_ViewImports.cshtml"
using QuarterlySales.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jin\Documents\GitHub\web-cSharp\A5_QuarterlySalesApp\QuarterlySales\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b26313fe38176ff864a402b8ad45c63f79e8073", @"/Views/Shared/Components/TopQuartersByEmployee/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34a2288594e55d59c3922c5b3932c56d4e098d0f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TopQuartersByEmployee_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Sales>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"img-thumbnail card shadow\">\r\n    <h5 class=\"p-1 bg-warning rounded text-white text-center\">Top Quarters by Employee</h5>\r\n    <div class=\"card-body bg-light text-center\">        \r\n");
#nullable restore
#line 6 "C:\Users\jin\Documents\GitHub\web-cSharp\A5_QuarterlySalesApp\QuarterlySales\Views\Shared\Components\TopQuartersByEmployee\Default.cshtml"
         for (int i = 0, j = 1; i < Model.Count; i++, j++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"card-text\">\r\n                ");
#nullable restore
#line 9 "C:\Users\jin\Documents\GitHub\web-cSharp\A5_QuarterlySalesApp\QuarterlySales\Views\Shared\Components\TopQuartersByEmployee\Default.cshtml"
           Write(j);

#line default
#line hidden
#nullable disable
            WriteLiteral(". ");
#nullable restore
#line 9 "C:\Users\jin\Documents\GitHub\web-cSharp\A5_QuarterlySalesApp\QuarterlySales\Views\Shared\Components\TopQuartersByEmployee\Default.cshtml"
               Write(Model[i].Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Q ");
#nullable restore
#line 9 "C:\Users\jin\Documents\GitHub\web-cSharp\A5_QuarterlySalesApp\QuarterlySales\Views\Shared\Components\TopQuartersByEmployee\Default.cshtml"
                                Write(Model[i].Quarter);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 9 "C:\Users\jin\Documents\GitHub\web-cSharp\A5_QuarterlySalesApp\QuarterlySales\Views\Shared\Components\TopQuartersByEmployee\Default.cshtml"
                                                    Write(Model[i].Amount?.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                <br />\r\n                <small class=\"bg-secondary text-light py-1 px-2 rounded\" \r\n                       style=\"display: flex; flex-wrap: wrap; justify-content: center\">\r\n                    ");
#nullable restore
#line 13 "C:\Users\jin\Documents\GitHub\web-cSharp\A5_QuarterlySalesApp\QuarterlySales\Views\Shared\Components\TopQuartersByEmployee\Default.cshtml"
               Write(Model[i].Employee.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </small> \r\n            </p>\r\n");
#nullable restore
#line 16 "C:\Users\jin\Documents\GitHub\web-cSharp\A5_QuarterlySalesApp\QuarterlySales\Views\Shared\Components\TopQuartersByEmployee\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Sales>> Html { get; private set; }
    }
}
#pragma warning restore 1591