using Microsoft.AspNetCore.Mvc;
using Qutell.ThreeSixty.Application.Services;
using DomainTimeZone = Qutell.ThreeSixty.Domain.Entities.Lookups.TimeRelatedLookups.TimeZone;


namespace Qutell.ThreeSixty.Api.Controllers.TimeRelatedLookupsControllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class TimeZoneController : GenericController<DomainTimeZone, int>
    {
        public TimeZoneController(ILookupCacheService<DomainTimeZone, int> Service) : base(Service)
        {
        }
    }

}

