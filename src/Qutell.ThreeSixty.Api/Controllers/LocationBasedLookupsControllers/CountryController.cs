using Microsoft.AspNetCore.Mvc;
using Qutell.ThreeSixty.Application.Services;
using Qutell.ThreeSixty.Domain.Entities.Lookups.LocationBasedLookups;

namespace Qutell.ThreeSixty.Api.Controllers.LocationBasedLookupsControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountryController : GenericController<Country, int>
    {
        public CountryController(ILookupCacheService<Country, int> Service) : base(Service)
        {
        }
    }
}
