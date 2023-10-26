using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace EmlakOfisiWebUI.Components
{
    public class EstateSummaryViewComponent : ViewComponent
    {
        private readonly IServiceManager _manager;

        public EstateSummaryViewComponent(IServiceManager manager)
        {
            _manager = manager;
        }

        public string Invoke()
        {
            //service
            return _manager.EstateService.GetAllEstates(false).Count().ToString();

        }
    }
}
