using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataFromViewToController.Models;

namespace DataFromViewToController.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PostWithParameters(string firstname, string lastname)
        {
            return Content($"Firstname: {firstname}, Lastname: {lastname}");
        }

        [HttpPost]
        public ActionResult PostWithRequest()
        {
            string firstName = Request["firstname"].ToString();
            string lastName = Request["lastname"].ToString();

            return Content($"Firstname: {firstName}, Lastname: {lastName}");
        }

        [HttpPost]
        public ActionResult PostWithFormCollection(FormCollection form)
        {
            string firstName = form["firstname"].ToString();
            string lastName = form["lastname"].ToString();

            return Content($"Firstname: {firstName}, Lastname: {lastName}");
        }

        [HttpPost]
        public ActionResult PostWithModelBinding(Employee employee)
        {
            return Content($"Firstname: {employee.FirstName}, Lastname: {employee.LastName}");
        }

        [HttpPost]
        public ActionResult PostWithAjax(string firstname, string lastname)
        {
            return Content($"Firstname: {firstname}, Lastname: {lastname}");
        }
    }
}