using HRSystem.Database;
using HRSystem.Models;
using HRSystem.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HRSystem.Services
{
    public class RegistrationService : CrudService<LeaveRegistration>,IRegistration
    {
        private readonly Connection context;
        public RegistrationService(Connection context) : base(context)
        {
            this.context = context;
        }

        public async Task<List<LeaveRegistration>> GetMyLeaves(String id)
        {
            //  return await this.context.LeaveRegistrations.Where(l=>l.employeeId==id).Include(l=>l.type).ToListAsync();

            return null;
        }

        public async Task<List<LeaveRegistration>> GetAllLeaves()
        {

            return await this.context.LeaveRegistrations.Include(l => l.type).Include(e => e.employee).ToListAsync();
        }
        public async Task<int> UpdateAccept(int id) {

            var r = await this.context.LeaveRegistrations.FindAsync(id);

            r.isAccept = 1;

           return await this.context.SaveChangesAsync();
        
        }
        public async Task<int> UpdateRefuse(int id)
        {

            var r = await this.context.LeaveRegistrations.FindAsync(id);

            r.isAccept = 2;

            return await this.context.SaveChangesAsync();

        }

    }
}
