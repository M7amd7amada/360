using Microsoft.AspNetCore.Mvc;
using Qutell.ThreeSixty.Domain.Entities.Lookups.otherLookups;
using Qutell.ThreeSixty.Application.Services;

namespace Qutell.ThreeSixty.Api.Controllers.otherLookups
{
    [ApiController]
    [Route("api/[controller]")]
    public class StaticPageController : GenericController<StaticPage, int>
    {
        public StaticPageController(ILookupCacheService<StaticPage, int> Service) : base(Service)
        {
        }
    }
}
