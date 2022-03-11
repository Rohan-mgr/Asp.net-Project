using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class studentController : Controller
    {
        // GET: student
        EmployeeEntities db = new EmployeeEntities();
        public ActionResult Index()
        {
            List<student> data = db.students.ToList();
            return View("student", data);
        }
    }
}