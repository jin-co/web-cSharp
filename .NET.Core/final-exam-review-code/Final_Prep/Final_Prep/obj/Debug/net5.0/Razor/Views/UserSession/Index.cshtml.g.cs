#pragma checksum "C:\Users\jin\Documents\GitHub\web-cSharp\final-exam-review-code\Final_Prep\Final_Prep\Views\UserSession\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08f56f061178dfa6684bc7d4f17e44ac8078c784"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserSession_Index), @"mvc.1.0.view", @"/Views/UserSession/Index.cshtml")]
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
#line 1 "C:\Users\jin\Documents\GitHub\web-cSharp\final-exam-review-code\Final_Prep\Final_Prep\Views\_ViewImports.cshtml"
using Final_Prep;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jin\Documents\GitHub\web-cSharp\final-exam-review-code\Final_Prep\Final_Prep\Views\_ViewImports.cshtml"
using Final_Prep.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jin\Documents\GitHub\web-cSharp\final-exam-review-code\Final_Prep\Final_Prep\Views\_ViewImports.cshtml"
using Final_Prep.Models.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jin\Documents\GitHub\web-cSharp\final-exam-review-code\Final_Prep\Final_Prep\Views\_ViewImports.cshtml"
using Final_Prep.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jin\Documents\GitHub\web-cSharp\final-exam-review-code\Final_Prep\Final_Prep\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08f56f061178dfa6684bc7d4f17e44ac8078c784", @"/Views/UserSession/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6cc0a8c819a7503318caa8299cea9f1ae1dda32", @"/Views/_ViewImports.cshtml")]
    public class Views_UserSession_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<string>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\jin\Documents\GitHub\web-cSharp\final-exam-review-code\Final_Prep\Final_Prep\Views\UserSession\Index.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"jumbotron\">\r\n        <h2>No actions performed</h2>\r\n    </div>\r\n");
#nullable restore
#line 8 "C:\Users\jin\Documents\GitHub\web-cSharp\final-exam-review-code\Final_Prep\Final_Prep\Views\UserSession\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <ul>\r\n");
#nullable restore
#line 13 "C:\Users\jin\Documents\GitHub\web-cSharp\final-exam-review-code\Final_Prep\Final_Prep\Views\UserSession\Index.cshtml"
             foreach (var i in Model)
	        {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t         <li class=\"list-group-item\">");
#nullable restore
#line 15 "C:\Users\jin\Documents\GitHub\web-cSharp\final-exam-review-code\Final_Prep\Final_Prep\Views\UserSession\Index.cshtml"
                                        Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 16 "C:\Users\jin\Documents\GitHub\web-cSharp\final-exam-review-code\Final_Prep\Final_Prep\Views\UserSession\Index.cshtml"
	        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n");
#nullable restore
#line 19 "C:\Users\jin\Documents\GitHub\web-cSharp\final-exam-review-code\Final_Prep\Final_Prep\Views\UserSession\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<string>> Html { get; private set; }
    }
}
#pragma warning restore 1591
