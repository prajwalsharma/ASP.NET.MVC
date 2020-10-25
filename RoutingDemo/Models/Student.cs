using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoutingDemo.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public Address StudentAddress { get; set; }
    }
}