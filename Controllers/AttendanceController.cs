using HRSystem.Models;
using HRSystem.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HRSystem.Controllers
{
    public class AttendanceController : Controller
    {
        private readonly ICrud<Attendance> crud;

        public AttendanceController(ICrud<Attendance> crud)
        {
            this.crud = crud;

        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> AddAttendance(Attendance attendance)
        {
            await this.crud.Create(attendance);

            return Ok();



        }
        
       
    }
}
