using Microsoft.AspNetCore.Mvc;
using Qutell.ThreeSixty.Application.Services;
using Qutell.ThreeSixty.Domain.Entities.Lookups.LocationBasedLookups;

namespace Qutell.ThreeSixty.Api.Controllers.LocationBasedLookupsControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CityController : GenericController<City, int>
    {
        public CityController(ILookupCacheService<City, int> Service) : base(Service)
        {
        }
    }
}
