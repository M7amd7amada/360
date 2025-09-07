using Microsoft.AspNetCore.Mvc;
using Qutell.ThreeSixty.Application.Services;
using Qutell.ThreeSixty.Domain.Entities.Lookups.GeneralLookups;

namespace Qutell.ThreeSixty.Api.Controllers.GeneralLookupsControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobTypeController : GenericController<JobType, int>
    {
        public JobTypeController(ILookupCacheService<JobType, int> Service) : base(Service)
        {
        }
    }
}
