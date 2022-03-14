using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        public ActionResult Edit(int id)
        {
            empDetail data = db.empDetails.Find(id);
            //tbl_name data = db.tbl_employee.FirstOrDefault(x => x.id == id);
            return View(data);
        }
        public ActionResult UpdateData(empDetail empDetail)
        {
            db.Entry(empDetail).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}