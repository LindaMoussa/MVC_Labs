using MVCDay3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDay3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            Employee emp = new Employee();
            return View("Index",emp);
        }
        [HttpGet]
        public ViewResult About()
        {
            
            return View();
        }
        
        public PartialViewResult test()
        {
            return PartialView("");
        }//goz2 mn l page byt3'yar
    }
}