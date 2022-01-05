using System.Collections.Generic;

namespace CheatSheetCSharp.Credential.Models
{
    public class DropDownViewModel
    {
        public Dictionary<string, string> Items { get; set; }
        public string SelectedValue { get; set; }
        public string DefaultValue { get; set; }
    }
}
