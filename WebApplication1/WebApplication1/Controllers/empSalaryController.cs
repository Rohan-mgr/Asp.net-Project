using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class empSalaryController : Controller
    {
        // GET: empSalary
        EmployeeEntities db = new EmployeeEntities();
        public ActionResult Index()
        {
            List<employee_salary_details> data = db.employee_salary_details.ToList();
            return View(data);
        }
        public ActionResult Create()
        {
            var employeeList = db.empDetails.ToList();
            ViewBag.employeeList = new SelectList(employeeList, "eid", "ename");
            return View();
        }
        public ActionResult Edit(int id)
        {
            employee_salary_details data = db.employee_salary_details.Find(id);
            //tbl_name data = db.tbl_employee.FirstOrDefault(x => x.id == id);
            var employeeList = db.empDetails.ToList();
            ViewBag.employeeList = new SelectList(employeeList, "eid", "ename");
            return View(data);
        }
        public ActionResult UpdateData(employee_salary_details employee_Salary_Details)
        {
            db.Entry(employee_Salary_Details).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            employee_salary_details data = db.employee_salary_details.Find(id);
            db.employee_salary_details.Remove(data);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Create(employee_salary_details employee_Salary_Details)
        {
            db.employee_salary_details.Add(employee_Salary_Details);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
    }
}