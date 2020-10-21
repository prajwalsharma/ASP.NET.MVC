using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelsDemo.Models;

namespace ModelsDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            var employee = GetEmployee();
            return View(employee);
        }

        public ViewResult Employees()
        {
            var employees = GetEmployees();
            return View(employees);
        }

        private Employee GetEmployee()
        {
            return new Employee()
            {
                Id = 12345,
                Name = "Prajwal Sharma",
                Department = "CSE"
            };
        }

        private List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();

            for(int i = 1; i < 10; i++)
            {
                employees.Add(new Employee() { 
                    Id = i,
                    Name = "Prajwal",
                    Department = Guid.NewGuid().ToString()
                });
            }

            return employees;
        }
    }
}