using Entities.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using System.Data;

namespace EmlakOfisiWebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        private readonly IServiceManager _manager;

        public CategoryController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            return View(_manager.CategoryService.GetAllCategories(false));
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([FromForm] CategoryDtoForInsertion categoryDto)
        {
            if (ModelState.IsValid)
            {
                _manager.CategoryService.CreateCategory(categoryDto);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
