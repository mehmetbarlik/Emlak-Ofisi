using Entities.Models;
using Entities.RequestParameters;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using Repositories.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Concrete
{
    public sealed class EstateRepository : RepositoryBase<Estate>, IEstateRepository
    {
        public EstateRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateOneEstate(Estate estate) => Create(estate);

        public void DeleteOneEstate(Estate estate) => Remove(estate);

        public IQueryable<Estate> GetAllEstates(bool trackChanges) => FindAll(trackChanges);
        public IQueryable<Estate> GetAllEstatesWithDetails(EstateRequestParameters p)
        {
            return _context.Estates.FilteredByCategoryId(p.CategoryId)
                                   .FilteredBySearchTerm(p.SearchTerm)
                                   .FilteredByPrice(p.MinPrice, p.MaxPrice, p.IsValidPrice)
                                   .ToPaginate(p.PageNumber, p.PageSize);
        }

        public Estate? GetOneEstate(int id, bool trackChanges)
        {
            return FindyByCondition(est => est.EstateId.Equals(id), trackChanges);
        }

        public IQueryable<Estate> GetShowCaseEstates(bool trackChanges)
        {
            return FindAll(trackChanges).Where(p => p.Showcase.Equals(true));
        }

        public void UpdateOneEstate(Estate estate) => Update(estate);
    }
}
