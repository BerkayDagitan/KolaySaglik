﻿using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class AnasayfaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AnaPanel()
        { 
            return View();
        }
    }
}