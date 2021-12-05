using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandboxApp_Week12.TagHelpers
{
    public class ButtonTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("class", "btn btn-primary");

            // using extension
            output.Attributes.AppendCssClass("btn btn-primary");
        }
    }
}
