using Microsoft.AspNetCore.Identity;

namespace HRSystem.Models
{
    public class EmployeePermission
    {
        public int Id { get; set; }
       // public String  employeeId { get; set; }
              
        public IdentityUser employee { get; set; }
       // public int permissionId { get; set; }
        public Permission permission { get; set; }
       
        public int balance { get; set; } 


    }
}
