using Microsoft.AspNetCore.Mvc;
using Qutell.ThreeSixty.Application.Services;
using Qutell.ThreeSixty.Domain.Entities.Lookups.CompanyRelatedLookups;

namespace Qutell.ThreeSixty.Api.Controllers.CompanyRelatedLookupsControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PackageItemController : GenericController<PackageItem, int>
    {
        public PackageItemController(ILookupCacheService<PackageItem, int> Service) : base(Service)
        {
        }
    }
}
