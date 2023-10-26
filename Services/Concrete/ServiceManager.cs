using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Concrete
{
    public class ServiceManager : IServiceManager
    {
        private readonly IEstateService _estateService;
        private readonly ICategoryService _categoryService;
        private readonly IAuthService _authService;

        public ServiceManager(IEstateService estateService, ICategoryService categoryService, IAuthService authService)
        {
            _estateService = estateService;
            _categoryService = categoryService;
            _authService = authService;
        }

        public IEstateService EstateService => _estateService;
        public ICategoryService CategoryService => _categoryService;
        public IAuthService AuthService => _authService;
    }
}
