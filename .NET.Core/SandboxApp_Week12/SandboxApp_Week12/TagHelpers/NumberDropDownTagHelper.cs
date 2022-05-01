using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandboxApp_Week12.TagHelpers
{
    [HtmlTargetElement("select", Attributes = "my-min-number, my-max-number")]
    public class NumberDropDownTagHelper : TagHelper
    {
        [HtmlAttributeName("my-min-number")]
        public int Min { get; set; }

        [HtmlAttributeName("my-max-number")]
        public int Max { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            for (int i = Min; i <= Max; i++)
            {
                TagBuilder option = new TagBuilder("option");
                option.InnerHtml.Append(i.ToString());
                output.Content.AppendHtml(option);
            }
        }
    }
}
