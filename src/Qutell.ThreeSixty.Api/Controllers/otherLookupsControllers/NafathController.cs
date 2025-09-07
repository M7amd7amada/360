using Microsoft.AspNetCore.Mvc;
using Qutell.ThreeSixty.Application.Services;

namespace Qutell.ThreeSixty.Api.Controllers.otherLookups
{
    [ApiController]
    [Route("api/[controller]")]
    public class NafathController : GenericController<NafathController, int>
    {
        public NafathController(ILookupCacheService<NafathController, int> Service) : base(Service)
        {
        }
    }
}
