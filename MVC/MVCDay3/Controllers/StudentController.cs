﻿using Microsoft.AspNetCore.Mvc;
using MVCDay3.Context;
using MVCDay3.Models;
using Microsoft.EntityFrameworkCore;

namespace MVCDay3.Controllers
{
    public class StudentController : Controller
    {
        Company1DbContext db = new Company1DbContext();
        [HttpGet]
        public IActionResult GetAll()
        {
            ViewBag.Stds = db.Students.Include(s => s.Department).ToList();
            return View();
        }

        [HttpGet]
        public IActionResult Details(int Id)
        {
            var std = db.Students.Include(s => s.Department).SingleOrDefault(s => s.Id == Id);
            ViewBag.Std = std;
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student std)
        {
            db.Students.Add(std);
            db.SaveChanges();
            return RedirectToAction("GetAll");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var std = db.Students.SingleOrDefault(s => s.Id == id);
            return View(std);
        }

        [HttpPost]
        public IActionResult Edit(Student std)
        {
            db.Students.Update(std);
            db.SaveChanges();
            return RedirectToAction("GetAll");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var std = db.Students.SingleOrDefault(s => s.Id == id);
            db.Students.Remove(std);
            db.SaveChanges();
            return RedirectToAction("GetAll");
        }
    }
}