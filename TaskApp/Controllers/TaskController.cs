﻿using Microsoft.AspNetCore.Mvc;

namespace TaskApp.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
