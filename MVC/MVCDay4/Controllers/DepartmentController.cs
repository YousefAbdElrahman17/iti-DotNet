﻿using Microsoft.AspNetCore.Mvc;
using MVCDay4.Context;
using MVCDay4.Models;
using MVCDay4.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace MVCDay4.Controllers
{
    public class DepartmentController : Controller
    {
        Company2DbContext db = new Company2DbContext();

        [HttpGet]
        public IActionResult GetAll()
        {
            var vm = new GetAllDepartmentsViewModel
            {
                Departments = db.Departments.ToList()
            };
            return View(vm);
        }

        [HttpGet]
        public IActionResult Details(int Id)
        {
            var dept = db.Departments.Include(d => d.Students).SingleOrDefault(d => d.DeptId == Id);

            var vm = new DepartmentViewModel
            {
                DeptId = dept.DeptId,
                Name = dept.Name,
                StudentNames = dept.Students.Select(s => s.Name).ToList()
            };

            return View(vm);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var vm = new AddDepartmentViewModel();
            return View(vm);
        }

        [HttpPost]
        public IActionResult Create(AddDepartmentViewModel vm)
        {
            var dept = new Department
            {
                Name = vm.Name
            };

            db.Departments.Add(dept);
            db.SaveChanges();
            return RedirectToAction("GetAll");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var dept = db.Departments.SingleOrDefault(d => d.DeptId == id);

            var vm = new AddDepartmentViewModel
            {
                DeptId = dept.DeptId,
                Name = dept.Name
            };

            return View(vm);
        }

        [HttpPost]
        public IActionResult Edit(AddDepartmentViewModel vm)
        {
            var dept = new Department
            {
                DeptId = vm.DeptId,
                Name = vm.Name
            };

            db.Departments.Update(dept);
            db.SaveChanges();
            return RedirectToAction("GetAll");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var dept = db.Departments.SingleOrDefault(d => d.DeptId == id);
            db.Departments.Remove(dept);
            db.SaveChanges();
            return RedirectToAction("GetAll");
        }
    }
}