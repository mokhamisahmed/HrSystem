using Microsoft.AspNetCore.Mvc;
using HRSystem.Repositories;
using HRSystem.Models;
namespace HRSystem.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly IRegistration registration;
       

        public RegistrationController(IRegistration registration) {
            this.registration = registration;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RegisterLeave(LeaveRegistration registration)
        {
            

            LeaveRegistration r =  await this.registration.Create(registration);

            // return RedirectToAction("MyLeaves", new {id=registration.employeeId });
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> MyLeaves(String id)
        {
            return View(await this.registration.GetMyLeaves(id));

        }

        [HttpGet]
        public async Task<IActionResult> GetLeavesRegistration()
        {

            return View(await this.registration.GetAllLeaves());

        }

        [HttpPost]
        public async Task<IActionResult> Accept(LeaveRegistration registration)
        {
           await  this.registration.UpdateAccept(registration.Id);
            return Ok();

        }
        [HttpPost]
        public async Task<IActionResult> Refuse(LeaveRegistration registration)
        {
            await this.registration.UpdateRefuse(registration.Id);
            return Ok();

        }


    }
}
