using AutoMapper;
using Entities.Dtos;
using Entities.Models;
using Entities.RequestParameters;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Concrete
{
    public class EstateManager : IEstateService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public EstateManager(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public void CreateEstate(EstateDtoForInsertion estateDto)
        {
            Estate estate = _mapper.Map<Estate>(estateDto);
            _manager.Estate.CreateOneEstate(estate);
            _manager.Save();
        }

        public void DeleteOneEstate(int id)
        {
            Estate estate = GetOneEstate(id, false);
            if (estate != null)
            {
                _manager.Estate.DeleteOneEstate(estate);
                _manager.Save();
            }
        }

        public IEnumerable<Estate> GetAllEstates(bool trackChanges)
        {
            return _manager.Estate.GetAllEstates(trackChanges);
        }

        public IQueryable<Estate> GetAllEstatesWithDetails(EstateRequestParameters p)
        {
            return _manager.Estate.GetAllEstatesWithDetails(p);
        }

        public Estate? GetOneEstate(int id, bool trackChanges)
        {
            var estate = _manager.Estate.GetOneEstate(id, trackChanges);
            if (estate == null)
            {
                throw new Exception("Aradığınız kriterlerde ev bulunamadı.");
            }
            return estate;
        }

        public EstateDtoForUpdate GetOneEstateForUpdate(int id, bool trackChanges)
        {
            var estate = GetOneEstate(id, trackChanges);
            var estateDto = _mapper.Map<EstateDtoForUpdate>(estate);
            return estateDto;
        }

        public IEnumerable<Estate> GetShowcaseEstates(bool trackChanges)
        {
            var estates = _manager.Estate.GetShowCaseEstates(trackChanges);
            return estates;
        }

        public void UpdateOneEstate(EstateDtoForUpdate estateDto)
        {
            var estate = _mapper.Map<Estate>(estateDto);
            _manager.Estate.UpdateOneEstate(estate);
            _manager.Save();
        }
    }
}
