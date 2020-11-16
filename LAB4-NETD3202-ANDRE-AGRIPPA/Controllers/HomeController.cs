using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LAB4_NETD3202_ANDRE_AGRIPPA.Models;
using Microsoft.AspNetCore.Mvc;

namespace LAB4_NETD3202_ANDRE_AGRIPPA.Controllers
{
    public class HomeController : Controller
    {
        // public string Index()
        // {
        //     FirstModel message = new FirstModel();
        //     return View(message);
        // }
        public IActionResult Index()
        {
            FirstModel message = new FirstModel();
            return View(message);
        }
    }
}
