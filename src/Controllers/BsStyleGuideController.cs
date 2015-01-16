using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bootstrap_3._0._2_dev.Controllers
{
    public class BsStyleGuideController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.StyleSrc = "~/Content/bs-theme-series5/bootstrap.css";
            return View();
        }

        public ActionResult DefaultStyle()
        {
            ViewBag.StyleSrc = "~/Content/bs-default/bootstrap.css";
            return View("Index");
        }
    }
}