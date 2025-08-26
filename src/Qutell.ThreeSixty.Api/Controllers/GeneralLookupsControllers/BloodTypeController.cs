using Microsoft.AspNetCore.Mvc;
using Qutell.ThreeSixty.Domain.Entities.Lookups.GeneralLookups;
using Qutell.ThreeSixty.Infrastructure.UnitofWork;

namespace Qutell.ThreeSixty.Api.Controllers.GeneralLookupsControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BloodTypeController : GenericController<BloodType,int>
    {
        public BloodTypeController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
    }
}
