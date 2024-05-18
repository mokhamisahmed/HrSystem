using HRSystem.Repositories;
using HRSystem.Models;
using HRSystem.Database;
using Microsoft.EntityFrameworkCore;

namespace HRSystem.Services
{
    public class PersonalService :  CrudService<PersonalInfo> ,IProfile
    {
        private readonly Connection context;
        public PersonalService(Connection context) : base(context)
        {
            this.context = context;
        }

        public async Task<PersonalInfo> ReadWithInclude(String id)
        {
           return await this.context.PersonalInformations.Include(u => u.User).SingleOrDefaultAsync(u=>u.User.Id==id);
           
        }
    }
}
