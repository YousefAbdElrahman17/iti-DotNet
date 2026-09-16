using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCDay6.Models;
using MVCDay6.Context;
using Microsoft.EntityFrameworkCore;

namespace MVCDay6.Controllers;

public class HomeController : Controller
{
    Company6DbContext db;
    public HomeController()
    {
        db= new Company6DbContext();
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
