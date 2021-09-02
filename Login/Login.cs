using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CriptomonedasProject.Login
{
    public class Login : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
