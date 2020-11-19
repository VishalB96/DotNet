using MVC_practice01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_practice01.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        EmployeeLayer e1 = new EmployeeLayer();

        public ActionResult Index()
        {

            return View(e1.Employees);
        }
        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }

        
    }
}