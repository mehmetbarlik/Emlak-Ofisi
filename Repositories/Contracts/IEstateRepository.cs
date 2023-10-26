using Entities.Models;
using Entities.RequestParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IEstateRepository : IRepositoryBase<Estate>
    {
        IQueryable<Estate> GetAllEstatesWithDetails(EstateRequestParameters p);
        IQueryable<Estate> GetShowCaseEstates(bool trackChanges);
        IQueryable<Estate> GetAllEstates(bool trackChanges);
        Estate? GetOneEstate(int id, bool trackChanges);
        void CreateOneEstate(Estate estate);
        void DeleteOneEstate(Estate estate);
        void UpdateOneEstate(Estate estate);
    }
}
