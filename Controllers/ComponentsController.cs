using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlyStyle.Controllers
{
    public class ComponentsController : Controller
    {
        public IActionResult Buttons()
        {
            return View();
        }
        public IActionResult Cards()
        {
            return View();
        }

        public IActionResult Dropdown()
        {
            return View();
        }

        public IActionResult Table()
        {
            return View();
        }
    }
}
