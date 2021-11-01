using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlyStyle.Controllers
{
    public class ComponentsController : _TemplateController
    {
        public IActionResult Alerts()
        {
            SetPageInfo("OnlyStyle Components. Alerts", "Alerts style", "OnlyStyle Components. Alerts");
            return View();
        }
        public IActionResult Badge()
        {
            SetPageInfo("OnlyStyle Components. Badge", "Badges style", "OnlyStyle Components. Badge");
            return View();
        }
        public IActionResult Buttons()
        {
            SetPageInfo("OnlyStyle Components. Buttons", "Buttons style", "OnlyStyle Components. Buttons");
            return View();
        }
        public IActionResult Cards()
        {
            SetPageInfo("OnlyStyle Components. Cards", "Cards style", "OnlyStyle Components. Cards");
            return View();
        }
        public IActionResult Details()
        {
            SetPageInfo("OnlyStyle Components. Details", "Details style", "OnlyStyle Components. Details");
            return View();
        }
        public IActionResult Dropdown()
        {
            SetPageInfo("OnlyStyle Components. Dropdown", "Dropdown style", "OnlyStyle Components. Dropdown");
            return View();
        }

        public IActionResult Table()
        {
            SetPageInfo("OnlyStyle Components. Table", "Table style", "OnlyStyle Components. Table");
            return View();
        }
    }
}
