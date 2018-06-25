using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlugAbleModule.Areas.Maintenance.Controllers
{
    public class HomeController : Controller
    {
        // GET: Maintenance/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}