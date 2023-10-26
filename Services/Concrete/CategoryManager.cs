using AutoMapper;
using Entities.Dtos;
using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;


        public CategoryManager(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public IEnumerable<Category> GetAllCategories(bool trackChanges)
        {
            return _manager.Category.FindAll(trackChanges);
        }

        public void CreateCategory(CategoryDtoForInsertion categoryDto)
        {
            Category category = _mapper.Map<Category>(categoryDto);
            _manager.Category.Create(category);
            _manager.Save();
        }
    }
}
