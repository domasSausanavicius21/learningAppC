using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebApplication.Controllers
{
    
    public class DebugController : Controller
    {
        //[HttpPost]
        public IActionResult Test()
        {
            return View();
        }

        [ActionName("ParamTest")]
        public string GetParameter(int id)
        {
            return "I got id: " + id;
        }
    }
}
