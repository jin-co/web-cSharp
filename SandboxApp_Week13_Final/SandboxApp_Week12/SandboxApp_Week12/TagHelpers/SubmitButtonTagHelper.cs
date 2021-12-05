using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandboxApp_Week12.TagHelpers
{
    public class SubmitButtonTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            // Make it a button element that has a start and an end tag
            output.TagName = "button";
            output.TagMode = TagMode.StartTagAndEndTag;

            // Turn this button in a submit type button
            output.Attributes.SetAttribute("type", "submit");

            // Add some bootstrap!
            string newClasses = "btn btn-warning";
            string oldClasses = output.Attributes["class"]?.Value?.ToString();

            string classes = (string.IsNullOrEmpty(oldClasses)) ?
                newClasses : $"{oldClasses} {newClasses}";

            output.Attributes.SetAttribute("class", classes);
        }
    }
}
