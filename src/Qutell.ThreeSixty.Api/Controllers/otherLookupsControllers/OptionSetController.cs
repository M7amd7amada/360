using Microsoft.AspNetCore.Mvc;
using Qutell.ThreeSixty.Domain.Entities.Lookups.otherLookups;
using Qutell.ThreeSixty.Application.Services;
namespace Qutell.ThreeSixty.Api.Controllers.otherLookups
{
    [ApiController]
    [Route("api/[controller]")]
    public class OptionSetController : GenericController<OptionSet, int>
    {
        public OptionSetController(ILookupCacheService<OptionSet, int> Service) : base(Service)
        {
        }
    }

}
