using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCDay4.Models;
using MVCDay4.Context;
using Microsoft.EntityFrameworkCore;

namespace MVCDay4.Controllers;

public class HomeController : Controller
{
    Company2DbContext db;
    public HomeController()
    {
        db= new Company2DbContext();
    }
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
