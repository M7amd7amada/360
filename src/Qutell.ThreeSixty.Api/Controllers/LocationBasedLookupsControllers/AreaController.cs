using Microsoft.AspNetCore.Mvc;
using Qutell.ThreeSixty.Application.Services;
using Qutell.ThreeSixty.Domain.Entities.Lookups.LocationBasedLookups;

namespace Qutell.ThreeSixty.Api.Controllers.LocationBasedLookupsControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AreaController : GenericController<Area, int>
    {
        public AreaController(ILookupCacheService<Area, int> Service) : base(Service)
        {
        }
    }
}
