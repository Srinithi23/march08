using march08.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace march08.Controllers
{
    public class CustomerController : Controller
    { 
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            return View();
        }
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
    }
}