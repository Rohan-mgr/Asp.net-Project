using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult SaveData(student students)
        {
            db.students.Add(students);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            student data = db.students.Find(id);
            //tbl_name data = db.tbl_employee.FirstOrDefault(x => x.id == id);
            return View( data);
        }
        public ActionResult Delete(int id)
        {
            student data = db.students.Find(id);
            db.students.Remove(data);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public ActionResult UpdateData(student students)
        {
            db.Entry(students).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}