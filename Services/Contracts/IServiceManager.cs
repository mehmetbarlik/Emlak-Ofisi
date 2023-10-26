using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IServiceManager
    {
        IEstateService EstateService { get; }
        ICategoryService CategoryService { get; }
        IAuthService AuthService { get; }
    }
}
