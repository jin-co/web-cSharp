using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandboxApp_Week12.TagHelpers
{
    [HtmlTargetElement("input", Attributes = "my-required")]
    public class RequiredInputTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            // add CSS class to input element
            output.Attributes.AppendCssClass("form-control");

            // create a <span> element
            TagBuilder span = new TagBuilder("span");
            span.Attributes.Add("class", "text-danger mr-2");
            span.InnerHtml.Append("This is just full of mistakes!");

            // add span element after input element
            output.PostElement.AppendHtml(span);

        }
    }
}
