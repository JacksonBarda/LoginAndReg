﻿using Microsoft.AspNetCore.Mvc;

namespace LoginAndRegistration.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
