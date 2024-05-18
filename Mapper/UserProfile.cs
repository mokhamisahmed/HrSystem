
using AutoMapper;
using HRSystem.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace E_Commerce_WebSite.Mapper
{
    public class UserProfile:Profile
    {

        public UserProfile()
        {

            CreateMap<UserRegister, IdentityUser>();
        }
    }
}
