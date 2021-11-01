using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlyStyle.Controllers
{
    public class _TemplateController : Controller
    {
        internal void SetPageInfo(string title,
            string description = "",
            string h1 = "",
            string keywords = "",
            string urlImage = "",
            bool hideTopRibbon = true,
            bool hideBottomRibbon = true)
        {
            if (!string.IsNullOrEmpty(title))
                ViewBag.Title = title;
            if (!string.IsNullOrEmpty(description))
                ViewBag.Description = description;
            ViewBag.Canonical = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}{HttpContext.Request.Path}".ToLower();
            if (!string.IsNullOrEmpty(h1))
                ViewBag.H1 = h1;
            if (!string.IsNullOrEmpty(keywords))
                ViewBag.Keywords = keywords;
            if (!string.IsNullOrEmpty(urlImage))
                ViewBag.UrlImage = urlImage;
            ViewBag.HideTopRibbon = hideTopRibbon;
            ViewBag.HideBottomRibbon = hideBottomRibbon;
        }
    }
}
