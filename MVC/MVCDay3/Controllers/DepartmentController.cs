﻿using Microsoft.AspNetCore.Mvc;
using MVCDay3.Context;
using MVCDay3.Models;
using Microsoft.EntityFrameworkCore;

namespace MVCDay3.Controllers
{
    public class DepartmentController : Controller
    {
        Company1DbContext db = new Company1DbContext();

        [HttpGet]
        public IActionResult GetAll()
        {
            ViewBag.Depts = db.Departments.ToList();
            return View();
        }

        [HttpGet]
        public IActionResult Details(int Id)
        {
            var dept = db.Departments.Include(d => d.Students).SingleOrDefault(d => d.DeptId == Id);
            ViewData["Dept"] = dept;
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Department dept)
        {
            db.Departments.Add(dept);
            db.SaveChanges();
            return RedirectToAction("GetAll");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var dept = db.Departments.SingleOrDefault(d => d.DeptId == id);
            return View(dept);
        }

        [HttpPost]
        public IActionResult Edit(Department dept)
        {
            db.Departments.Update(dept);
            db.SaveChanges();
            return RedirectToAction("GetAll");
        }
    }
}