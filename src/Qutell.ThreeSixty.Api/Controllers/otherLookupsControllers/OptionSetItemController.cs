using Microsoft.AspNetCore.Mvc;
using Qutell.ThreeSixty.Domain.Entities.Lookups.otherLookups;
using Qutell.ThreeSixty.Application.Services;
namespace Qutell.ThreeSixty.Api.Controllers.otherLookups
{
    [ApiController]
    [Route("api/[controller]")]
    public class OptionSetItemController : GenericController<OptionSetItem, int>
    {
        public OptionSetItemController(ILookupCacheService<OptionSetItem, int> Service) : base(Service)
        {
        }
    }

}

