using Microsoft.AspNetCore.Mvc;
using Qutell.ThreeSixty.Domain.Entities.Lookups.CompanyRelatedLookups;
using Qutell.ThreeSixty.Infrastructure.UnitofWork;

namespace Qutell.ThreeSixty.Api.Controllers.CompanyRelatedLookupsControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AvailableServiceController : GenericController<AvailableService, int>
    {
        public AvailableServiceController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
