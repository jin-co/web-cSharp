using System.Collections.Generic;

namespace CheatSheetCSharp.Credential.Models
{
    public class CartViewModel 
    {
        public IEnumerable<CartItem> List { get; set; }
        public double SubTotal { get; set; }
        public RouteDictionary BookGridRoute { get; set; }
    }
}
