using JillelaWeek6.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JillelaWeek6.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
       
    }
}