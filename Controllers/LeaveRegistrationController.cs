using HRSystem.Repositories;
using Microsoft.AspNetCore.Mvc;
using HRSystem.Models;
namespace HRSystem.Controllers
{
    public class LeaveRegistrationController : Controller
    {
        private readonly ILeave leave;

        public LeaveRegistrationController(ILeave leave)
        {
            this.leave = leave;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> RegisterLeave(String id)
        {
            
            return  View(await this.leave.GetTypes(id));
        }


       




    }
}
