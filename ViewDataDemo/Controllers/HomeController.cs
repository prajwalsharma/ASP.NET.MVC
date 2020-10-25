using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewDataDemo.Models;

namespace ViewDataDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            // Example 1: String in ViewData
            ViewData["SimpleString"] = "Hello World";

            // Example 2: List in ViewData
            ViewData["SimpleList"] = new List<string>()
            {
                "Hello", "From", "List", "Of", "Strings"
            };

            // Example 3: Model object in ViewData
            ViewData["EmployeeModel"] = new Employee()
            {
                EmpID = 1,
                Name = "Prajwal",
                Department = "CSE"
            };

            // Example 4: List of model objects in ViewData
            ViewData["EmployeeModelList"] = new List<Employee>()
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