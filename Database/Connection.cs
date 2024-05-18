using HRSystem.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HRSystem.Database
{
    public class Connection: IdentityDbContext<IdentityUser>
    {

            public Connection(DbContextOptions<Connection> option) : base(option)
            {
            

            }


        public DbSet<Attendance> Attendances { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<EmployeePermission> EmployeePermissions { get; set; }

        public DbSet<LeaveBalance> LeaveBalances { get; set; }

        public DbSet<Permission> Permissions { get; set; }

        public DbSet<PersonalInfo> PersonalInformations { get; set; }

        public DbSet<Position> Positions { get; set; }

        public DbSet<Types> types { get; set; }

        public DbSet<LeaveRegistration> LeaveRegistrations { get; set; }

        }
}
