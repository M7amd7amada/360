using Microsoft.AspNetCore.Mvc;
using Qutell.ThreeSixty.Domain.Entities.Lookups.TimeRelatedLookups;
using Qutell.ThreeSixty.Application.Services;

namespace Qutell.ThreeSixty.Api.Controllers.TimeRelatedLookupsControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FinanceYearController : GenericController<FinanceYear, int>
    {
        public FinanceYearController(ILookupCacheService<FinanceYear, int> Service) : base(Service)
        {
        }
    }
}
