using HRSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Device.Location;
namespace HRSystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult MyLeaves() {

            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}