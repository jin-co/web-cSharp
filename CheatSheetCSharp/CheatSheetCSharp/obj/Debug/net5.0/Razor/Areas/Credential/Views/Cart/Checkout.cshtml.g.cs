#pragma checksum "C:\Users\jin\Documents\GitHub\web-cSharp\CheatSheetCSharp\CheatSheetCSharp\Areas\Credential\Views\Cart\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2efef99565c13b71424fc80aeedad6d859e29c2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Credential_Views_Cart_Checkout), @"mvc.1.0.view", @"/Areas/Credential/Views/Cart/Checkout.cshtml")]
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
#line 1 "C:\Users\jin\Documents\GitHub\web-cSharp\CheatSheetCSharp\CheatSheetCSharp\Areas\Credential\Views\_ViewImports.cshtml"
using CheatSheetCSharp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jin\Documents\GitHub\web-cSharp\CheatSheetCSharp\CheatSheetCSharp\Areas\Credential\Views\_ViewImports.cshtml"
using CheatSheetCSharp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jin\Documents\GitHub\web-cSharp\CheatSheetCSharp\CheatSheetCSharp\Areas\Credential\Views\_ViewImports.cshtml"
using CheatSheetCSharp.Models.DomainModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jin\Documents\GitHub\web-cSharp\CheatSheetCSharp\CheatSheetCSharp\Areas\Credential\Views\_ViewImports.cshtml"
using CheatSheetCSharp.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jin\Documents\GitHub\web-cSharp\CheatSheetCSharp\CheatSheetCSharp\Areas\Credential\Views\_ViewImports.cshtml"
using CheatSheetCSharp.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jin\Documents\GitHub\web-cSharp\CheatSheetCSharp\CheatSheetCSharp\Areas\Credential\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2efef99565c13b71424fc80aeedad6d859e29c2e", @"/Areas/Credential/Views/Cart/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8705ac54a8d6c73faa139c7ea922201f6ef9ca07", @"/Areas/Credential/Views/_ViewImports.cshtml")]
    public class Areas_Credential_Views_Cart_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\jin\Documents\GitHub\web-cSharp\CheatSheetCSharp\CheatSheetCSharp\Areas\Credential\Views\Cart\Checkout.cshtml"
  
    ViewData["Title"] = "Checkout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Checkout</h1>
<ul class=""list-group"">
    <li class=""list-group-item bg-danger text-white"">
        <h4>Don't roll your own checkout! It isn't secure!</h4>
    </li>
    <li class=""list-group-item bg-warning"">
        Use a third party payment service, like 
        <a href=""https://stripe.com/"" target=""_blank"">Stripe</a> or
        <a href=""https://transferwise.com/us"" target=""_blank"">TransferWise</a>. 

        Most are pretty easy to incorporate in to your own web application, and then
        you aren't handling money or trying to store credit card numbers.
    </li>
</ul>");
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
