using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class employeeController : Controller
    {
        // GET: employee
        EmployeeEntities db = new EmployeeEntities();
        public ActionResult Index()
        {
            List<empDetail> data = db.empDetails.ToList();
            return View(data);
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult SaveData(empDetail empDetail)
        {
            db.empDetails.Add(empDetail);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}