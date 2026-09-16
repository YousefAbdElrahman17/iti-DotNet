﻿using Microsoft.AspNetCore.Mvc;
using MVCDay6.Context;
using MVCDay6.Models;
using Microsoft.EntityFrameworkCore;

namespace MVCDay6.Controllers
{
    public class EmployeeController : Controller
    {
        Company6DbContext db = new Company6DbContext();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            ViewBag.Emps = db.Employees.Include(emps => emps.Department).ToList();
            return View();

            //ViewData["Emps"] = db.Employees.ToList();
            //return View();
        }
        [HttpGet]
        public IActionResult Details(int Id)
        {
            var emp = db.Employees.Include(emps => emps.Department).SingleOrDefault(e => e.Id == Id);
  
            return View(emp);
        }
        [HttpGet]
        public IActionResult Create()
        { 
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            db.Employees.Add(emp);
            db.SaveChanges();
            return RedirectToAction("GetAll");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var emp=db.Employees.Include(emps => emps.Department).SingleOrDefault(e => e.Id == id);
            return View(emp);
        }
        [HttpPost]
        public IActionResult Edit(Employee emp)
        {
            db.Employees.Update(emp);
            db.SaveChanges();
            return RedirectToAction("GetAll");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var emp = db.Employees.SingleOrDefault(e => e.Id == id);
            db.Employees.Remove(emp);
            db.SaveChanges();
            return RedirectToAction("GetAll");
        }
    }
}