using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Concrete
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private readonly IEstateRepository _estateRepository;
        private readonly ICategoryRepository _categoryRepository;

        public RepositoryManager(IEstateRepository estateRepository, RepositoryContext context, ICategoryRepository categoryRepository)
        {
            _context = context;
            _estateRepository = estateRepository;
            _categoryRepository = categoryRepository;
        }

        public IEstateRepository Estate => _estateRepository;
        public ICategoryRepository Category => _categoryRepository;

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
