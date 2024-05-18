using HRSystem.Models;
namespace HRSystem.Repositories
{
    public interface IRegistration:ICrud<LeaveRegistration>
    {

        public Task<List<LeaveRegistration>> GetMyLeaves(String id);
        public  Task<List<LeaveRegistration>> GetAllLeaves();

        public Task<int> UpdateAccept(int id);

        public  Task<int> UpdateRefuse(int id);

    }
}
