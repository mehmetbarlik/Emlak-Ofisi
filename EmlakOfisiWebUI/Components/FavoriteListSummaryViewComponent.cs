using Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmlakOfisiWebUI.Components
{
    public class FavoriteListSummaryViewComponent : ViewComponent
    {
        private readonly FavoriteList _favoriteList;

        public FavoriteListSummaryViewComponent(FavoriteList favoriteList)
        {
            _favoriteList = favoriteList;
        }

        public string Invoke()
        {
            return _favoriteList.Lines.Count().ToString();
        }
    }
}
