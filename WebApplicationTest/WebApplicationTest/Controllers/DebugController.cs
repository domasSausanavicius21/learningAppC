using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationTest.Controllers
{
    public class DebugController : Controller
    {

        [HttpGet]
        public string Index()
        {
            return "Hello world!";
        }

        [ActionName("Hello")]
        public ViewResult SuperDuperGoodFunctionName()
        {
            return View();
        }

        public string SayBye()
        {
            return "Bye... world!";
        }

        public string TestProps(int id =111, string name = "Test")
        {
            return "Testing datat id is " + id + " name is " + name;
        }
    }
}