using MVCDay3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDay3.Controllers
{
    public class EmployeeController : Controller
    {
        ModelContext context = new ModelContext(); 

        // GET: Employee
        [HttpGet]
        public ViewResult Index()
        {
            return View(context.Employees.ToList());
        }
        [ChildActionOnly]
        //public PartialViewResult EmployeePartial(Employee emp)
        //{
        //    return PartialView("_EmployeePartial",emp);
        //}

        [HttpGet]
        public ViewResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Employee emp )
        {
            if( ModelState.IsValid)
            {
                context.Employees.Add(emp);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}