using Microsoft.AspNetCore.Mvc;
using Qutell.ThreeSixty.Application.Interfaces;
using Qutell.ThreeSixty.Application.Services;
using Qutell.ThreeSixty.Domain.Entities.Lookups.CompanyRelatedLookups;
using Qutell.ThreeSixty.Infrastructure.UnitofWork;

namespace Qutell.ThreeSixty.Api.Controllers.CompanyRelatedLookupsControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyScaleController : GenericController<CompanyScale, int>
    {
        public CompanyScaleController(ILookupCacheService<CompanyScale, int> Service) : base(Service)
        {
        }
    }
}
