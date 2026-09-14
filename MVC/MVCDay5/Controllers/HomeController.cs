using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCDay5.Models;
using MVCDay5.Context;
using Microsoft.EntityFrameworkCore;

namespace MVCDay5.Controllers;

public class HomeController : Controller
{
    Company5DbContext db;
    public HomeController()
    {
        db= new Company5DbContext();
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
