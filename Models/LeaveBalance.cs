using Microsoft.AspNetCore.Identity;

namespace HRSystem.Models
{
    public class LeaveBalance
    {
        public int Id { get; set; }

       //public String employeeId { get; set; }

        public IdentityUser employee { get; set; }
        public Types type { get; set; }

      // public int typeId { get; set; }

        public int mybalance { get; set; }
    }
}
