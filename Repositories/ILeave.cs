using HRSystem.Models;
namespace HRSystem.Repositories
{
    public interface ILeave:ICrud<Types>
    {
        public Task<List<LeaveBalance>> GetTypes(String userId); 

    }
}
