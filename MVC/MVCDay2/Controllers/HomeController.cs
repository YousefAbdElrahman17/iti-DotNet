using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCDay2.Models;
using MVCDay2.Context;
using Microsoft.EntityFrameworkCore;

namespace MVCDay2.Controllers;

public class HomeController : Controller
{
    CompanyDbContext db;
    public HomeController()
    {
        db= new CompanyDbContext();
    }

    // public IActionResult welcome2(int id ,string name,int age)
    // {
    //     return Content($"hello welcom2,{id},{name},{age}");
    // }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Welcome()
    {
        return View();
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
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
