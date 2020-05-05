using Day2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDay02.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Form()
        {
            User u = new User();
            return View(u);
        }
        [HttpPost]
        public ViewResult Form(User u)
        {
            
            var x = ModelState;
            if (ModelState.IsValid)
            {
                AddNewUser(u);
                return View("Welcome" , u); // class name
            }
            else
            {

            return View("Form",u);
            }
        }

        private void AddNewUser(User u)
        {
            Model1 ctx = new Model1();
            User user = new User();
            // fields to be insert
                user.id = u.id;
                user.name = u.name;
                user.email = u.email;
                user.salary = u.salary;
                user.gender = u.gender;
                user.address = u.address;
                ctx.Users.Add(user);
                // executes the commands to implement the changes to the database
                ctx.SaveChanges();
            
        }
    }


}