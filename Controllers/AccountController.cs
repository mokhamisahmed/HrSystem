using AutoMapper;
using HRSystem.Database;
using HRSystem.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Device.Location;

namespace HRSystem.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;

        private readonly SignInManager<IdentityUser> signInManager;

        private readonly RoleManager<IdentityRole> roleManager;

        private IMapper mapper;

        private readonly Connection context;

        public AccountController(Connection context, IMapper _mapper, RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this.roleManager = roleManager;
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.context = context;
            this.mapper = _mapper;

        }
        [HttpGet]

        public IActionResult LogIn()
        {

            return View();
        }


      


        [HttpGet]

        public IActionResult Test()
        {

            return Content("done");
        }

        [HttpGet]
        public IActionResult SignUp()
        {


            List<IdentityRole> roles = this.roleManager.Roles.ToList();
               

            return View(roles);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogIn(UserLogIn u)
        {


            if (ModelState.IsValid)
            {
                IdentityUser user = await this.userManager.FindByEmailAsync(u.Email);

                if (user != null)
                {
                    bool isCorrect = await this.userManager.CheckPasswordAsync(user, u.Password);

                    if (isCorrect)
                    {

                        await this.signInManager.SignInAsync(user, false);

                        return RedirectToAction("MyLeaves", "Registration", new {id=user.Id });
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "password invalid");
                        return View(u);
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "username and password invalid");
                    return View(u);
                }



            }

            return View(u);



        }


        [HttpPost]

        public async Task<IActionResult> SignUp(UserRegister u)
        {

            if (ModelState.IsValid)
            {
               IdentityUser user = this.mapper.Map<IdentityUser>(u);

                var result = await this.userManager.CreateAsync(user, u.Password);

                if (result.Succeeded)
                {
                    var RoleName = roleManager.Roles.SingleOrDefault(r => r.Id == u.roleId);
                    if (RoleName != null)
                    {
                        await this.userManager.AddToRoleAsync(user, RoleName.Name);

                    }

                    
                      

                   
                    return RedirectToAction("Index","Home");
                }

            }


            return View();
        }


        public IActionResult Index()
        {
            return View();
        }

    }
}
