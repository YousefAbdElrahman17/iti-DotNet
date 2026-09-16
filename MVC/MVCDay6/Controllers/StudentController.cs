﻿using Microsoft.AspNetCore.Mvc;
using MVCDay6.Context;
using MVCDay6.Models;
using MVCDay6.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace MVCDay6.Controllers
{
    public class StudentController : Controller
    {
        Company6DbContext db = new Company6DbContext();

        [HttpGet]
        public IActionResult GetAll()
        {
            int visitCount = 0;
            if (Request.Cookies["StudentGetAllVisitCount"] != null)
            {
                int.TryParse(Request.Cookies["StudentGetAllVisitCount"], out visitCount);
            }
            visitCount++;

            Response.Cookies.Append("StudentGetAllVisitCount", visitCount.ToString(), new CookieOptions
            {
                Expires = DateTimeOffset.Now.AddDays(7)
            });

            ViewBag.VisitCount = visitCount;
            ViewBag.LastViewedStudentName = HttpContext.Session.GetString("LastViewedStudentName");
            var vm = new GetAllStudentsViewModel
            {
                Students = db.Students.Include(s => s.Department).OrderBy(s => s.Id).ToList()
            };
            return View(vm);
        }

        [HttpGet]
        public IActionResult Details(int Id)
        {
            var std = db.Students.Include(s => s.Department).SingleOrDefault(s => s.Id == Id);
            HttpContext.Session.SetInt32("LastViewedStudentId", Id);
            HttpContext.Session.SetString("LastViewedStudentName", std.Name ?? "");
            var vm = new StudentViewModel
            {
                Id = std.Id,
                Name = std.Name,
                Age = std.Age,
                Address = std.Address,
                Email = std.Email,
                Password = std.Password,
                DepartmentName = std.Department?.Name
            };

            return View(vm);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var vm = new AddStudentViewModel
            {
                Departments = db.Departments.ToList()
            };
            return View(vm);
        }

       [HttpPost]
        public IActionResult Create(AddStudentViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                vm.Departments = db.Departments.ToList();
                return View(vm);
            }

            var std = new Student
            {
                Name = vm.Name,
                Age = vm.Age,
                Address = vm.Address,
                Email = vm.Email,
                Password = vm.Password,
                DeptId = vm.DeptId
            };

            db.Students.Add(std);
            db.SaveChanges();
            return RedirectToAction("GetAll");
        }
        
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var std = db.Students.SingleOrDefault(s => s.Id == id);

            var vm = new EditStudentViewModel
            {
                Id = std.Id,
                Name = std.Name,
                Age = std.Age,
                Address = std.Address,
                Email = std.Email,
                Password = std.Password,
                DeptId = std.DeptId,
                Departments = db.Departments.ToList()
            };

            return View(vm);
        }

        [HttpPost]
        public IActionResult Edit(EditStudentViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                vm.Departments = db.Departments.ToList();
                return View(vm);
            }

            var std = new Student
            {
                Id = vm.Id,
                Name = vm.Name,
                Age = vm.Age,
                Address = vm.Address,
                Email = vm.Email,
                Password = vm.Password,
                DeptId = vm.DeptId
            };

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