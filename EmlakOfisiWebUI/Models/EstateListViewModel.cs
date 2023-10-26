using Entities.Models;

namespace EmlakOfisiWebUI.Models
{
    public class EstateListViewModel
    {
        public IEnumerable<Estate> Estates { get; set; } = Enumerable.Empty<Estate>();
        public Pagination Pagination { get; set; } = new();
        public int TotalCount => Estates.Count();
    }
}
