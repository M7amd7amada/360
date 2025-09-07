using Microsoft.AspNetCore.Mvc;
using Qutell.ThreeSixty.Application.Services;
using Qutell.ThreeSixty.Domain.Entities.Lookups.otherLookups;

namespace Qutell.ThreeSixty.Api.Controllers.otherLookups
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlockedNumberController : GenericController<BlockedNumber, int>
    {
        public BlockedNumberController(ILookupCacheService<BlockedNumber, int> Service) : base(Service)
        {
        }
    }
}
