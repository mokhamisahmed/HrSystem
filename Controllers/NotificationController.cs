﻿using Microsoft.AspNetCore.Mvc;

namespace HRSystem.Controllers
{
    public class NotificationController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
