using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlyStyle.Controllers
{
    public class ContentController : Controller
    {

        public ActionResult Typography()
        {
            return View();
        }
    }
}
