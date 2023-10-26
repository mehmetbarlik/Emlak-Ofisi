using Entities.Dtos;
using Entities.Models;
using Entities.RequestParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IEstateService
    {
        IQueryable<Estate> GetAllEstatesWithDetails(EstateRequestParameters p);
        IEnumerable<Estate> GetAllEstates(bool trackChanges);
        IEnumerable<Estate> GetShowcaseEstates(bool trackChanges);
        Estate? GetOneEstate(int id, bool trackChanges);
        void CreateEstate(EstateDtoForInsertion estateDto);
        void UpdateOneEstate(EstateDtoForUpdate estateDto);
        void DeleteOneEstate(int id);
        EstateDtoForUpdate GetOneEstateForUpdate(int id, bool trackChanges);
    }
}
