using Microsoft.AspNetCore.Mvc;
using Qutell.ThreeSixty.Domain.Entities.Lookups.CompanyRelatedLookups;
using Qutell.ThreeSixty.Application.Interfaces;
using Qutell.ThreeSixty.Application.Services;

namespace Qutell.ThreeSixty.Api.Controllers.CompanyRelatedLookupsControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyTypeController : GenericController<CompanyType, int>
    {
        public CompanyTypeController(ILookupCacheService<CompanyType, int> Service) : base(Service)
        {
        }
    }
}
