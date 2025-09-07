using Microsoft.AspNetCore.Mvc;
using Qutell.ThreeSixty.Domain.Entities.Lookups.TimeRelatedLookups;
using Qutell.ThreeSixty.Application.Services;

namespace Qutell.ThreeSixty.Api.Controllers.TimeRelatedLookupsControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TimeTypeController : GenericController<TimeType, int>
    {
        public TimeTypeController(ILookupCacheService<TimeType, int> Service) : base(Service)
        {
        }
    }
}
