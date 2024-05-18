using Microsoft.AspNetCore.Identity;

namespace HRSystem.Models
{
    public class Attendance
    {
        public int Id { get; set; }

        public String enterDate {get;set;}

        public String ExitDate { get; set; }

      //  public String employeeId { get; set; }
        public IdentityUser employee { get; set; }


        




    }
}
