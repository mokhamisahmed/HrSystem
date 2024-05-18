using Microsoft.AspNetCore.Identity;

namespace HRSystem.Models
{
    public class LeaveNotification
    {
        public int Id { get; set; }

      

        public String Title = "Leave Notification";

        public int registrationId {get;set;}

        public LeaveRegistration registration { get; set; }

       

    }
}
