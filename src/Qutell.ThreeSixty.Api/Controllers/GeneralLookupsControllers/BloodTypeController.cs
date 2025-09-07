using Microsoft.AspNetCore.Mvc;
using Qutell.ThreeSixty.Application.Services;
using Qutell.ThreeSixty.Domain.Entities.Lookups.GeneralLookups;

namespace Qutell.ThreeSixty.Api.Controllers.GeneralLookupsControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BloodTypeController : GenericController<BloodType, int>
    {
        public BloodTypeController(ILookupCacheService<BloodType, int> Service) : base(Service)
        {
        }
    }
}
