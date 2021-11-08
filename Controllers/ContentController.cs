using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlyStyle.Controllers
{
    public class ContentController : _TemplateController
    {
        public ActionResult Colors()
        {
            SetPageInfo("OnlyStyle Colors", "Colors style", "OnlyStyle Colors");
            return View();
        }
        public ActionResult Grid()
        {
            SetPageInfo("OnlyStyle Grid", "Grid style", "OnlyStyle Grid");
            return View();
        }
        public ActionResult Typography()
        {
            SetPageInfo("OnlyStyle Typography", "Typography", "OnlyStyle Typography");
            return View();
        }
    }
}
