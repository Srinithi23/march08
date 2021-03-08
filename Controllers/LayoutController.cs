using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace march08.Controllers
{
    public class LayoutController : Controller
    {
        // GET: Layout
        public ActionResult Index()
        {
            return View();
        }
    }
}