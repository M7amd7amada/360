using Microsoft.AspNetCore.Mvc;
using Qutell.ThreeSixty.Domain.Entities.Lookups.otherLookups;
using Qutell.ThreeSixty.Application.Services;
namespace Qutell.ThreeSixty.Api.Controllers.otherLookups
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrganizingScheduleController : GenericController<OrganizingSchedule, int>
    {
        public OrganizingScheduleController(ILookupCacheService<OrganizingSchedule, int> Service) : base(Service)
        {
        }
    }
}
