using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services.Contracts;

namespace EmlakOfisiWebUI.Pages
{
    public class FavoriteListModel : PageModel
    {
        private readonly IServiceManager _manager;
        public FavoriteList FavoriteList { get; set; } //IoC

        public FavoriteListModel(IServiceManager manager, FavoriteList favoriteListService)
        {
            _manager = manager;
            FavoriteList = favoriteListService;

        }

        public string ReturnUrl { get; set; } = "/";

        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }

        public IActionResult OnPost(int estateId, string returnUrl)
        {
            Estate? estate = _manager.EstateService.GetOneEstate(estateId, false);

            if (estate is not null)
            {
                FavoriteList.AddItem(estate, 1);
            }
            return RedirectToPage(new { returnUrl = returnUrl }); //returnUrl
        }

        public IActionResult OnPostRemove(int id, string returnUrl)
        {
            FavoriteList.RemoveLine(FavoriteList.Lines.First(cl => cl.Estate.EstateId.Equals(id)).Estate);
            return Page();
        }
    }
}
