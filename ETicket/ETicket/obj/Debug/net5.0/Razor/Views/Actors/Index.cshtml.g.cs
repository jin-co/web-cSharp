#pragma checksum "C:\Users\jin\Documents\GitHub\web-cSharp\ETicket\ETicket\Views\Actors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cea765b24511cf5c21683669cf81406c0acc86b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Actors_Index), @"mvc.1.0.view", @"/Views/Actors/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cea765b24511cf5c21683669cf81406c0acc86b", @"/Views/Actors/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbcd1179f2872963ce41c50fd3dde2a18c896f85", @"/Views/_ViewImports.cshtml")]
    public class Views_Actors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Actor>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\jin\Documents\GitHub\web-cSharp\ETicket\ETicket\Views\Actors\Index.cshtml"
  
    // this is linked to the title(go to _Layout to check)
    ViewData["Title"] = "List of Actors";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-8 offset-md-2\">\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr class=\"text-center\">\r\n");
            WriteLiteral("                    <th>");
#nullable restore
#line 19 "C:\Users\jin\Documents\GitHub\web-cSharp\ETicket\ETicket\Views\Actors\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.ProfilePictureURL));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 20 "C:\Users\jin\Documents\GitHub\web-cSharp\ETicket\ETicket\Views\Actors\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 21 "C:\Users\jin\Documents\GitHub\web-cSharp\ETicket\ETicket\Views\Actors\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.Bio));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>Actions</th>\r\n                </tr>\r\n            </thead>\r\n\r\n            <tbody>\r\n");
#nullable restore
#line 27 "C:\Users\jin\Documents\GitHub\web-cSharp\ETicket\ETicket\Views\Actors\Index.cshtml"
                 foreach (var i in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td class=\"align-middle\">\r\n                            <img class=\"rounded-circle\"");
            BeginWriteAttribute("src", " src=\"", 1110, "\"", 1136, 1);
#nullable restore
#line 31 "C:\Users\jin\Documents\GitHub\web-cSharp\ETicket\ETicket\Views\Actors\Index.cshtml"
WriteAttributeValue("", 1116, i.ProfilePictureURL, 1116, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                 style=\"max-width: 150px;\"/>\r\n                        </td>\r\n                        <td class=\"align-middle\">\r\n                            ");
#nullable restore
#line 35 "C:\Users\jin\Documents\GitHub\web-cSharp\ETicket\ETicket\Views\Actors\Index.cshtml"
                       Write(i.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                        </td>\r\n                        <td class=\"align-middle\">\r\n                            ");
#nullable restore
#line 39 "C:\Users\jin\Documents\GitHub\web-cSharp\ETicket\ETicket\Views\Actors\Index.cshtml"
                       Write(i.Bio);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                        </td>
                        <td class=""align-middle"">
                            <a class=""btn btn-outline-primary"">
                                <i class=""bi bi-pencil-square"">Edit</i>                                
                            </a> |
                            <a class=""btn btn-outline-primary"">
                                <i class=""bi bi-eye"">Details</i>                                
                            </a> |
                            <a class=""btn btn-danger text-light"">
                                <i class=""bi bi-trash"">Delete</i>
                            </a>
                        </td>
                    </tr>        
");
#nullable restore
#line 54 "C:\Users\jin\Documents\GitHub\web-cSharp\ETicket\ETicket\Views\Actors\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Actor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
