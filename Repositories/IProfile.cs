using HRSystem.Models;
using HRSystem.Repositories;
namespace HRSystem.Repositories
{
    public interface IProfile : ICrud<PersonalInfo>
    {
        public Task<PersonalInfo> ReadWithInclude(String id);

       
    }
}
