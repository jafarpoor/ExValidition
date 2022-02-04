using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Validition.Models.Entities;

namespace Validition.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Rigester()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Rigester(User user)
        {
            if (ModelState.IsValid)
            {
                //
            }
            else
            {
                //
            }
            return View();
        }
    }
}
