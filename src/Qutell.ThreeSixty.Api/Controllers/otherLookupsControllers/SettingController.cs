using Microsoft.AspNetCore.Mvc;
using Qutell.ThreeSixty.Domain.Entities.Lookups.otherLookups;
using Qutell.ThreeSixty.Application.Services;

namespace Qutell.ThreeSixty.Api.Controllers.otherLookups
{
    [ApiController]
    [Route("api/[controller]")]
    public class SettingController : GenericController<Setting, int>
    {
        public SettingController(ILookupCacheService<Setting, int> Service) : base(Service)
        {
        }
    }
}
