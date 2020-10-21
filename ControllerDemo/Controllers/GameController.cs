using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllerDemo.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public string Index()
        {
            return "Welcome to the Game!";
        }

        public string Name(string name = "")
        {
            return $"Welcome to the game: {name}";
        }

        public string FullName(string first = "", string last = "")
        {
            if(first != "" && last != "")
            {
                return $"Your first name is = {first} and last name is = {last}";
            }
            else if(first == "" && last != "")
            {
                return $"Your last name is = {last}";
            }
            else if(first != "" && last == "")
            {
                return $"Your first name is = {first}";
            }

            return "Name is not provided!";
            
        }
    }
}