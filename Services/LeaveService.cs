using HRSystem.Repositories;
using HRSystem.Models;
using HRSystem.Database;
using Microsoft.EntityFrameworkCore;

namespace HRSystem.Services
{
    public class LeaveService : CrudService<Types>, ILeave
    {
        private readonly Connection context;
        public LeaveService(Connection context) : base(context)
        {
            this.context = context;
        }

        public async Task<List<LeaveBalance>> GetTypes(String userId)
        {
            //  return await this.context.LeaveBalances.Include(l => l.employee).Include(l=>l.type).Where(u=>u.employeeId==userId).ToListAsync();

            return null;
        
        }
    }
}
