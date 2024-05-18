using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRSystem.Models
{
    public class PersonalInfo
    {

        public int Id { get; set; }

       // public String UserId { get; set; }
       public IdentityUser User { get; set; } 
        public String BirthDate { get; set; }

        public String Phone { get; set; }

        public String insurance_no { get; set; }
        public String? Image_path { get; set; }
        [NotMapped]
        public IFormFile file { get; set; }

        public String Marital { get; set; }

        public String Military { get; set; }







    }
}
