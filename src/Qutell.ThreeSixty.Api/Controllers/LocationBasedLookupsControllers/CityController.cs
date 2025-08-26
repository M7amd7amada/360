using Microsoft.AspNetCore.Mvc;
using Qutell.ThreeSixty.Domain.Entities.Lookups.LocationBasedLookups;
using Qutell.ThreeSixty.Infrastructure.UnitofWork;

namespace Qutell.ThreeSixty.Api.Controllers.LocationBasedLookupsControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CityController : GenericController<City,int>
    {
        public CityController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
    }
}
