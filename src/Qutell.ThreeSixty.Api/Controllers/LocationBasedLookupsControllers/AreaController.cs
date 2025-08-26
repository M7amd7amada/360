using Microsoft.AspNetCore.Mvc;
using Qutell.ThreeSixty.Domain.Entities.Lookups.LocationBasedLookups;
using Qutell.ThreeSixty.Infrastructure.UnitofWork;

namespace Qutell.ThreeSixty.Api.Controllers.LocationBasedLookupsControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AreaController : GenericController<Area,int>
    {
        public AreaController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
    }
}
