using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeesApplication_Week5.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        [ForeignKey("RoleID")]
        public int RoleID { get; set; }

        public Role Role { get; set; }

        [ForeignKey("CompanyID")]
        public int CompanyID { get; set; }

        public Company Company { get; set; }
    }
}
