using EmlakOfisiWebUI.Infrastructure.Extensions;
using Entities.Models;
using System.Text.Json.Serialization;

namespace EmlakOfisiWebUI.Models
{
    public class SessionFavoriteList : FavoriteList
    {
        [JsonIgnore]
        public ISession? Session { get; set; }

        public static FavoriteList GetCart(IServiceProvider services)
        {
            ISession? session = services.GetRequiredService<IHttpContextAccessor>().HttpContext?.Session;

            SessionFavoriteList favoriteList = session.GetJson<SessionFavoriteList>("favoriteList") ?? new SessionFavoriteList();
            favoriteList.Session = session;
            return favoriteList;
        }

        public override void AddItem(Estate estate, int quantity)
        {
            base.AddItem(estate, quantity);
            Session?.SetJson<SessionFavoriteList>("favoriteList", this);
        }

        public override void Clear()
        {
            base.Clear();
            Session?.Remove("favoriteList");
        }

        public override void RemoveLine(Estate estate)
        {
            base.RemoveLine(estate);
            Session?.SetJson<SessionFavoriteList>("favoriteList", this);
        }
    }
}
