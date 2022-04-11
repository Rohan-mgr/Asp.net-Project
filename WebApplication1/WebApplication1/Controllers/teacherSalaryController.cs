using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class teacherSalaryController : Controller
    {
        // GET: teacherSalary
        EmployeeEntities db = new EmployeeEntities();
        public ActionResult Index(DateTime? search, DateTime? search2)
        {
            List<teacher_salary> data = db.teacher_salary.Where(x => (x.paid_date >= search && x.paid_date <= search2) || search == null).ToList();
            return View(data);
        }
        public ActionResult Create()
        {
            var teacherList = db.teachers.ToList();
            ViewBag.teacherList = new SelectList(teacherList, "tid", "tname");
            return View();
        }
        public ActionResult Edit(int id)
        {
            teacher_salary data = db.teacher_salary.Find(id);
            //tbl_name data = db.tbl_employee.FirstOrDefault(x => x.id == id);
            var teacherList = db.teachers.ToList();
            ViewBag.teacherList = new SelectList(teacherList, "tid", "tname");
            return View(data);
        }
        public ActionResult UpdateData(teacher_salary teacher_Salary)
        {
            db.Entry(teacher_Salary).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            teacher_salary data = db.teacher_salary.Find(id);
            db.teacher_salary.Remove(data);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Create(teacher_salary teacher_salary)
        {
            db.teacher_salary.Add(teacher_salary);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}