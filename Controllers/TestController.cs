﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class TestController : Controller
    {
        //20052020 Enam
        public IActionResult Index()
        {
            return View();
        }
    }
}