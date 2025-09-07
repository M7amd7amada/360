using Microsoft.AspNetCore.Mvc;
using Qutell.ThreeSixty.Application.Services;
using Qutell.ThreeSixty.Domain.Entities.Lookups.otherLookups;

namespace Qutell.ThreeSixty.Api.Controllers.otherLookups
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeCheckoutController : GenericController<EmployeeCheckout, int>
    {
        public EmployeeCheckoutController(ILookupCacheService<EmployeeCheckout, int> Service) : base(Service)
        {
        }
    }

}

