using Microsoft.AspNetCore.Mvc;
using Qutell.ThreeSixty.Domain.Entities.Lookups.GeneralLookups;
using Qutell.ThreeSixty.Application.Interfaces;
using Qutell.ThreeSixty.Application.Services;

namespace Qutell.ThreeSixty.Api.Controllers.GeneralLookupsControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BusinessTypeController : GenericController<BusinessType, int>
    {
        public BusinessTypeController(ILookupCacheService<BusinessType, int> Service) : base(Service)
        {
        }
    }
}
