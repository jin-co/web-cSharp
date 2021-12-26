using System.ComponentModel.DataAnnotations;

namespace CheatSheetCSharp.Session.Models
{
    public class Role
    {
        [Key]
        public int RoleID { get; set; }

        public string Name { get; set; }
    }
}
