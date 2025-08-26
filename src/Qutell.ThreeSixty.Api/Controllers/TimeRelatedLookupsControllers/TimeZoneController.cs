using Microsoft.AspNetCore.Mvc;
using Qutell.ThreeSixty.Infrastructure.UnitofWork;
using DomainTimeZone = Qutell.ThreeSixty.Domain.Entities.Lookups.TimeRelatedLookups.TimeZone;


namespace Qutell.ThreeSixty.Api.Controllers.TimeRelatedLookupsControllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class TimeZoneController : GenericController<DomainTimeZone, int>
    {
        public TimeZoneController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }

}

