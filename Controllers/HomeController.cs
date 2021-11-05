using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlyStyle.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OnlyStyle.Controllers
{
    public class HomeController : _TemplateController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            SetPageInfo("OnlyStyle Home Page", "Compact, fast framework. Without use JavaScript", "OnlyStyle Framework");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public FileResult DownloadLatestVersion()
        {
            return File("/versions/current/onlystyle.min.css", "text/plain", "onlystyle.min.css");
        }

        public IActionResult ErrorStatus(int statusCode)
        {
            return View(statusCode);
        }
    }
}
