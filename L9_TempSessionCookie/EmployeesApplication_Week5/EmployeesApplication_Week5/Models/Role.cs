using System.ComponentModel.DataAnnotations;

namespace EmployeesApplication_Week5.Models
{
    public class Role
    {
        [Key]
        public int RoleID { get; set; }

        public string Name { get; set; }
    }
}
