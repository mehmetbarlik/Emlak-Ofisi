using EmlakOfisiWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EmlakOfisiWebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Welcome";
            return View();
        }

    }
}