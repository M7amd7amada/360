using Microsoft.AspNetCore.Mvc;
using Qutell.ThreeSixty.Domain.Entities.Lookups.TimeRelatedLookups;
using Qutell.ThreeSixty.Infrastructure.UnitofWork;

namespace Qutell.ThreeSixty.Api.Controllers.TimeRelatedLookupsControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShiftTypeController : GenericController<ShiftType,int>
    {
        public ShiftTypeController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
