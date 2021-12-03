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
        //Breadcrumb
        public IActionResult Breadcrumb()
        {
            SetPageInfo("OnlyStyle Components. Breadcrumb", "Breadcrumb style", "OnlyStyle Components. Breadcrumb");
            return View();
        }
        public IActionResult Buttons()
        {
            SetPageInfo("OnlyStyle Components. Buttons", "Buttons style", "OnlyStyle Components. Buttons");
            return View();
        }
        public IActionResult ButtonsGroup()
        {
            SetPageInfo("OnlyStyle Components. Buttons group", "Buttons group style", "OnlyStyle Components. Buttons group");
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

        public IActionResult Forms()
        {
            SetPageInfo("OnlyStyle Components. Forms", "Form elements style", "OnlyStyle Components. Forms");
            return View();
        }
        public IActionResult Listgroup()
        {
            SetPageInfo("OnlyStyle Components. List group", "List group style", "OnlyStyle Components. List group");
            return View();
        }
        public IActionResult Material()
        {
            SetPageInfo("OnlyStyle Components. Material input", "Material input style", "OnlyStyle Components. Material input");
            return View();
        }
        public IActionResult Navbar()
        {
            SetPageInfo("OnlyStyle Components. Navbar", "Navbar style", "OnlyStyle Components. Navbar");
            return View();
        }
        public IActionResult Progress()
        {
            SetPageInfo("OnlyStyle Components. Progress", "Progress style", "OnlyStyle Components. Progress");
            return View();
        }
        public IActionResult Spinner()
        {
            SetPageInfo("OnlyStyle Components. Spinner", "Spinner style", "OnlyStyle Components. Spinner");
            return View();
        }
        //Switch
        public IActionResult Switch()
        {
            SetPageInfo("OnlyStyle Components. Switch", "Switch style", "OnlyStyle Components. Switch");
            return View();
        }

        public IActionResult Table()
        {
            SetPageInfo("OnlyStyle Components. Table", "Table style", "OnlyStyle Components. Table");
            return View();
        }
        public IActionResult Tooltip()
        {
            SetPageInfo("OnlyStyle Components. Tooltip", "Tooltip style", "OnlyStyle Components. Tooltip");
            return View();
        }
    }
}
