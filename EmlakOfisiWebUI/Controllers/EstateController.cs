using EmlakOfisiWebUI.Models;
using Entities.Dtos;
using Entities.RequestParameters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Services.Contracts;

namespace EmlakOfisiWebUI.Controllers
{
    public class EstateController : Controller
    {
        private readonly IServiceManager _manager;

        public EstateController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index(EstateRequestParameters p)
        {
            var estates = _manager.EstateService.GetAllEstatesWithDetails(p);
            var pagination = new Pagination()
            {
                CurrentPage = p.PageNumber,
                ItemsPerPage = p.PageSize,
                TotalItems = _manager.EstateService.GetAllEstates(false).Count()
            };
            return View(new EstateListViewModel()
            {
                Estates = estates,
                Pagination = pagination
            });
        }

        public IActionResult AgentIndex(EstateRequestParameters p)
        {
            var estates = _manager.EstateService.GetAllEstatesWithDetails(p);
            var pagination = new Pagination()
            {
                CurrentPage = p.PageNumber,
                ItemsPerPage = p.PageSize,
                TotalItems = _manager.EstateService.GetAllEstates(false).Count()
            };
            return View(new EstateListViewModel()
            {
                Estates = estates,
                Pagination = pagination
            });
        }
        public IActionResult Get([FromRoute(Name = "id")] int id)
        {

            var model = _manager.EstateService.GetOneEstate(id, false);
            ViewData["Title"] = model?.EstateName;

            return View(model);
        }

        public IActionResult Create()
        {
            ViewBag.Categories = GetCategoriesSelectList();
            return View();
        }

        private SelectList GetCategoriesSelectList()
        {
            return new SelectList(_manager.CategoryService.GetAllCategories(false), "CategoryId", "CategoryName", "1");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromForm] EstateDtoForInsertion estateDto, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                //file operation
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                estateDto.ImageUrl = String.Concat("/images/", file.FileName);
                _manager.EstateService.CreateEstate(estateDto);
                TempData["success"] = $"{estateDto.EstateName} oluşturuldu.";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Update([FromRoute(Name = "id")] int id)
        {
            ViewBag.Categories = GetCategoriesSelectList();
            var model = _manager.EstateService.GetOneEstateForUpdate(id, false);
            ViewData["Title"] = model?.EstateName;
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update([FromForm] EstateDtoForUpdate estateDto, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                //file operation
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                estateDto.ImageUrl = String.Concat("/images/", file.FileName);
                _manager.EstateService.UpdateOneEstate(estateDto);
                return RedirectToAction("Index");
            }
            return View();

        }

        [HttpGet]
        public IActionResult Delete([FromRoute(Name = "id")] int id)
        {
            _manager.EstateService.DeleteOneEstate(id);
            TempData["danger"] = "Mülk kaldırıldı.";
            return RedirectToAction("Index");
        }
    }
}
