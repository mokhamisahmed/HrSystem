using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HRSystem.Controllers
{
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;

        public RoleController(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> AddRole()
        {
            IdentityRole role = new IdentityRole()
            {
                Name="Admin"
            };
           var result= await this.roleManager.CreateAsync(role);

            return RedirectToAction("SignUp","Account");

        }
    }
}
