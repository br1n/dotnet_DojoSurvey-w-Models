using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoSurvey_Models.Models;
using Microsoft.AspNetCore.Http;

namespace DojoSurvey_Models
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("result")]
        public IActionResult Create(User newUser)
        {
            return View(newUser);
        }
    }
}
