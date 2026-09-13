﻿using Microsoft.AspNetCore.Mvc;
using MVCDay2.Context;
using MVCDay2.Models;
using Microsoft.EntityFrameworkCore;

namespace MVCDay2.Controllers
{
    public class EmployeeController : Controller
    {
        CompanyDbContext db;
        public EmployeeController()
        {
            db = new CompanyDbContext();
        }
        public IActionResult AddEmp()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult AddEmp(Employee Emp)
        {
            db.Add(Emp);
            db.SaveChanges();
            return RedirectToAction("GetAllEmps");
        }
        
        public IActionResult GetEmpWithId(int id)
        {
            var emp = db.Employees.Include(e => e.Department).SingleOrDefault(e => e.Id==id);
            return View(emp);
        }
        public IActionResult GetAllEmps()
        {
            var emp = db.Employees.Include(e => e.Department).ToList();
            return View(emp);
        }

    }
}