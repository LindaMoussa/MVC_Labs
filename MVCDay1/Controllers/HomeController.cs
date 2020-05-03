using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDay1.Controllers
{
    public class User
    {
        public string name { get; set; }
        public string email { get; set; }
    }
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ViewResult Index()
        {
            return View(); // class name
        }
        [HttpGet]
        public ViewResult Form()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Form(User u)
        {
            if (u.name != null && u.email != null )
            {
                ViewBag.Name = u.name;
                return View("welcome"); // class name
            }
            return View();
        }
    }
}