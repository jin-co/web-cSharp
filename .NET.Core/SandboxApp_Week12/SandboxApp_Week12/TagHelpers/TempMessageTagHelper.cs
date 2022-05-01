using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandboxApp_Week12.TagHelpers
{
    [HtmlTargetElement("my-temp-message")]
    public class TempMessageTagHelper : TagHelper
    {
        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewCtx { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var tempData = ViewCtx.TempData;
            if (tempData.Keys.Contains("message"))
            {
                output.BuildTag("h4", "bg-info text-center text-white p-2");
                output.Content.SetContent(tempData["message"].ToString());
            }
            else
            {
                output.SuppressOutput();
            }
        }
    }
}
