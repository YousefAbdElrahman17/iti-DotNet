﻿using Microsoft.AspNetCore.Mvc;
using MVCDay6.Context;
using MVCDay6.Models;
using MVCDay6.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace MVCDay6.Controllers
{
    public class DepartmentController : Controller
    {
        Company6DbContext db = new Company6DbContext();

                [HttpGet]
        public IActionResult GetAll()
        {
            int visitCount = 0;
            if (Request.Cookies["DepartmentGetAllVisitCount"] != null)
            {
                int.TryParse(Request.Cookies["DepartmentGetAllVisitCount"], out visitCount);
            }
            visitCount++;

            Response.Cookies.Append("DepartmentGetAllVisitCount", visitCount.ToString(), new CookieOptions
            {
                Expires = DateTimeOffset.Now.AddDays(7)
            });

            ViewBag.VisitCount = visitCount;
            ViewBag.LastViewedDeptName = HttpContext.Session.GetString("LastViewedDeptName");
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
           
            if (vm != null)
            {
                HttpContext.Session.SetInt32("LastViewedDeptId", Id);
                HttpContext.Session.SetString("LastViewedDeptName", vm.Name ?? "");
            }
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
            if (!ModelState.IsValid)
            {
                return View(vm);
            }

            var dept = new Department { Name = vm.Name };
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
            if (!ModelState.IsValid)
            {
                return View(vm);
            }

            var dept = new Department { DeptId = vm.DeptId, Name = vm.Name };
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