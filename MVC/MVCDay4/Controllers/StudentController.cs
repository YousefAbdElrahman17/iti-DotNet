﻿using Microsoft.AspNetCore.Mvc;
using MVCDay4.Context;
using MVCDay4.Models;
using MVCDay4.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace MVCDay4.Controllers
{
    public class StudentController : Controller
    {
        Company2DbContext db = new Company2DbContext();

        [HttpGet]
        public IActionResult GetAll()
        {
            var vm = new GetAllStudentsViewModel
            {
                Students = db.Students.Include(s => s.Department).ToList()
            };
            return View(vm);
        }

        [HttpGet]
        public IActionResult Details(int Id)
        {
            var vm = db.Students.Where(s => s.Id == Id).Select(s => new StudentViewModel
            {
                Id = s.Id,
                Name = s.Name,
                Age = s.Age,
                Address = s.Address,
                DepartmentName = s.Department.Name
            }).SingleOrDefault();

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
            var std = new Student
            {
                Name = vm.Name,
                Age = vm.Age,
                Address = vm.Address,
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
                DeptId = std.DeptId,
                Departments = db.Departments.ToList()
            };

            return View(vm);
        }

        [HttpPost]
        public IActionResult Edit(EditStudentViewModel vm)
        {
            var std = new Student
            {
                Id = vm.Id,
                Name = vm.Name,
                Age = vm.Age,
                Address = vm.Address,
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