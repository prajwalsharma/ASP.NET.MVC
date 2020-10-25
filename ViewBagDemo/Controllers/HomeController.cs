using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewBagDemo.Models;

namespace ViewBagDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            // Example 1: Simple string in ViewBag
            ViewBag.SimpleString = "Hello from ViewBag";

            // Example 2: List in ViewBag
            ViewBag.SimpleList = new List<string>()
            {
                "Helllo", "From", "string", "List"
            };

            // Example 3: Object in ViewBAg
            ViewBag.SimpleModel = new Employee()
            {
                EmpID = 123,
                Name = "Prajwal",
                Department = "CSE"
            };

            // Example 4: List of model objects in ViewBag
            ViewBag.ListOfEmployees = new List<Employee>()
            {
                new Employee()
                {
                    EmpID = 1,
                    Name = "Prajwal",
                    Department = "CSE"
                },
                new Employee()
                {
                    EmpID = 2,
                    Name = "Sharma",
                    Department = "ECE"
                }
            };

            return View();
        }
    }
}