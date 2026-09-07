﻿using Microsoft.AspNetCore.Mvc;
using MVCDay1.Context;
using MVCDay1.Models;

namespace MVCDay1.Controllers
{
    public class EmployeeController : Controller
    {
        CompanyDbContext db;
        public EmployeeController()
        {
            db = new CompanyDbContext();
        }
        public IActionResult GetAll()
        {
            var emps = db.Employees.ToList();
            return Json(emps);
        }
        [HttpGet]
        public void add(Employee emp)
        {
            db.Add(emp);
            db.SaveChanges();
        }
        [HttpGet]
        public void update(Employee e)
        {
            db.Update(e);
            db.SaveChanges();
        }
        [HttpGet]
        public void delete(int id)
        { 
            var emp = db.Employees.SingleOrDefault(e => e.Id == id);
            db.Employees.Remove(emp);
            db.SaveChanges();
        }
    }
}