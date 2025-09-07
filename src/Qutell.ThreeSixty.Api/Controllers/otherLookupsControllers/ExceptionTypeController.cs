using Microsoft.AspNetCore.Mvc;
using Qutell.ThreeSixty.Domain.Entities.Lookups.otherLookups;
using Qutell.ThreeSixty.Application.Services;

namespace Qutell.ThreeSixty.Api.Controllers.otherLookups
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExceptionTypeController : GenericController<ExceptionType, int>
    {
        public ExceptionTypeController(ILookupCacheService<ExceptionType, int> Service) : base(Service)
        {
        }
    }
}
