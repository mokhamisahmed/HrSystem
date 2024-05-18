using Microsoft.AspNetCore.Identity;

namespace HRSystem.Models
{
    public class LeaveRegistration
    {
        public int Id { get; set; }

     //  public String employeeId { get; set; }
        public IdentityUser employee { get; set; }

        public String StartDate { get; set; }

        public String EndDate { get; set; }

     // public int typeId { get; set; }

        public Types type { get; set; }

        public int duration { get; set; }

        public int  isAccept { get; set; }   // 0 1 2  // 0 is pending 1 accept 2 reject 

    }
}
