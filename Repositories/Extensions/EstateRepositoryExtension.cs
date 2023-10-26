using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Extensions
{
    public static class EstateRepositoryExtension
    {
        public static IQueryable<Estate> FilteredByCategoryId(this IQueryable<Estate> estates, int? categoryId)
        {
            if (categoryId is null)
            {
                return estates;
            }
            else
            {
                return estates.Where(p => p.CategoryId.Equals(categoryId));
            }
        }
        public static IQueryable<Estate> FilteredBySearchTerm(this IQueryable<Estate> estates, String? searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return estates;
            }
            else
            {
                return estates.Where(est => est.EstateName.ToLower().Contains(searchTerm.ToLower()));
            }
        }

        public static IQueryable<Estate> FilteredByPrice(this IQueryable<Estate> estates, int minPrice, int maxPrice, bool isValidPrice)
        {
            if (isValidPrice)
            {
                return estates.Where(est => est.Price >= minPrice && est.Price <= maxPrice);
            }
            else
            {
                return estates;
            }
        }

        public static IQueryable<Estate> ToPaginate(this IQueryable<Estate> estates, int pageNumber, int pageSize)
        {
            return estates
                .Skip(((pageNumber - 1) * pageSize))
                .Take(pageSize);
        }
    }
}
