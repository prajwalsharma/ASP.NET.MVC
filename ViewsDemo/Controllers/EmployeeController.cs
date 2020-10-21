using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewsDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee view through ActionResult
        public ActionResult Index()
        {
            return View();
        }

        // Return view from Viewresult using ActionMethod name
        public ViewResult Aboutus()
        {
            return View();
        }

        // Return view from shared folder using name
        public ViewResult Common()
        {
            return View("CommonView");
        }

        // Return view from another folder using view path
        public ViewResult MyView()
        {
            return View("~/Views/MyViews/MyView.cshtml");
        }
    }
}