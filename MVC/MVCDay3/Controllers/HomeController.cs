using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCDay3.Models;
using MVCDay3.Context;
using Microsoft.EntityFrameworkCore;

namespace MVCDay3.Controllers;

public class HomeController : Controller
{
    Company1DbContext db;
    public HomeController()
    {
        db= new Company1DbContext();
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
