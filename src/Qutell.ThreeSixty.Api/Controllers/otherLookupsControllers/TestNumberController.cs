using Microsoft.AspNetCore.Mvc;
using Qutell.ThreeSixty.Domain.Entities.Lookups.otherLookups;
using Qutell.ThreeSixty.Application.Services;

namespace Qutell.ThreeSixty.Api.Controllers.otherLookups
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestNumberController : GenericController<TestNumber, int>
    {
        public TestNumberController(ILookupCacheService<TestNumber, int> Service) : base(Service)
        {
        }
    }
}
