﻿using Microsoft.AspNetCore.Mvc;
using MVCDay5.Context;
using MVCDay5.Models;
using MVCDay5.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace MVCDay5.Controllers
{
    public class DepartmentController : Controller
    {
        Company5DbContext db = new Company5DbContext();

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
            var vm = db.Departments.Where(d => d.DeptId == Id)
            .Select(d => new DepartmentViewModel
            {
                DeptId = d.DeptId,
                Name = d.Name,
                StudentNames = d.Students.Select(s => s.Name).ToList()
            }).SingleOrDefault();
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

            var vm = new EditDepartmentViewModel
            {
                DeptId = dept.DeptId,
                Name = dept.Name
            };

            return View(vm);
        }

        [HttpPost]
        public IActionResult Edit(EditDepartmentViewModel vm)
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