using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class teacherController : Controller
    {
        // GET: teacher
        EmployeeEntities db = new EmployeeEntities();
        public ActionResult Index()
        {
            List<teacher> data = db.teachers.ToList();
            return View(data);
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult SaveData(teacher teachers)
        {
            db.teachers.Add(teachers);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            teacher data = db.teachers.Find(id);
            //tbl_name data = db.tbl_employee.FirstOrDefault(x => x.id == id);
            return View(data);
        }
        public ActionResult UpdateData(teacher teachers)
        {
            db.Entry(teachers).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            teacher data = db.teachers.Find(id);
            db.teachers.Remove(data);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}