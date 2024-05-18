using Microsoft.AspNetCore.Identity;

namespace HRSystem.Models
{
    public class CompanyInfo
    {
        public int Id { get; set; }
        //public String employeeId { get; set; }

        public IdentityUser employee { get; set; }

        public String Hire_Date { get; set; }

        public double Salary { get; set; }

       // public int positionId { get; set; }

        public Position position { get; set; }

       // public int departmentId { get; set; }

        public Department department { get; set; }

        public List<LeaveBalance> leaveBalances { get; set; }


    }
}
