using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StoreFront.UI.MVC.Exceptions;

namespace StoreFront.UI.MVC.Controllers
{
    public class CustomErrorsController : Controller
    {
        // GET: CustomErrors
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Unresolved()
        {
            return View();
        }
    }
}