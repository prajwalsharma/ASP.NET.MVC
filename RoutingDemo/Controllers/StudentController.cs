using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RoutingDemo.Models;

namespace RoutingDemo.Controllers
{
    [RoutePrefix("Students")]
    public class StudentController : Controller
    {
        [Route("")]
        public ActionResult GetAllStudents()
        {
            var students = Students();
            return View(students);
        }

        [Route("{id:int}")]
        public ActionResult GetStudent(int? id)
        {
            var student = Students().FirstOrDefault(x => x.StudentID == id);
            return View(student);
        }

        [Route("{id}/Address")]
        public ActionResult GetStudentAddress(int? id)
        {
            var address = Students().Where(x => x.StudentID == id).Select(x => x.StudentAddress).FirstOrDefault();
            return View(address);
        }

        [Route("{id}")]
        public ContentResult DuplicateRoute(string id)
        {
            return Content("Hello from Duplicate Route with type string");
        }

        [Route("~/about-us")]
        public ContentResult WithoutPrefix()
        {
            return Content("View without controller name");
        }

        private List<Student> Students()
        {
            return new List<Student>()
            {
                new Student()
                {
                    StudentID = 1,
                    Name = "Prajwal",
                    StudentAddress = new Address(){
                        HouseNumber = 123,
                        HouseAddress = "ABC Road"
                    }
                },
                new Student()
                {
                    StudentID = 2,
                    Name = "John",
                    StudentAddress = new Address(){
                        HouseNumber = 456,
                        HouseAddress = "DEF Road"
                    }
                },
                new Student()
                {
                    StudentID = 3,
                    Name = "Jane",
                    StudentAddress = new Address(){
                        HouseNumber = 789,
                        HouseAddress = "XYZ Road"
                    }
                }
            };
        }
    }
}