using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace EmlakOfisiWebUI.Components
{
    public class ShowcaseViewComponent : ViewComponent
    {
        private readonly IServiceManager _manager;

        public ShowcaseViewComponent(IServiceManager manager)
        {
            _manager = manager;
        }

        public IViewComponentResult Invoke(string page = "default")
        {
            var estates = _manager.EstateService.GetShowcaseEstates(false);
            return page.Equals("default")
            ? View(estates)
            : View("List", estates);
        }
    }
}
