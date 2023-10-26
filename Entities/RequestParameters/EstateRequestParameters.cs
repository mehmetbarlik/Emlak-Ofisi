using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.RequestParameters
{
    public class EstateRequestParameters : RequestParameters
    {
        public int? CategoryId { get; set; }
        public int MinPrice { get; set; } = 0;
        public int MaxPrice { get; set; } = int.MaxValue;
        public bool IsValidPrice => MaxPrice > MinPrice;
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public EstateRequestParameters() : this(1, 6)
        {

        }
        public EstateRequestParameters(int pageNumber = 1, int pageSize = 6)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
    }
}
