using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace EmlakOfisiWebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]

    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            TempData["info"] = $"Welcome Back, {DateTime.Now.ToShortTimeString()}";
            return View();
        }
    }
}
