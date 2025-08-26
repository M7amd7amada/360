using Microsoft.AspNetCore.Mvc;
using Qutell.ThreeSixty.Domain.Entities.Lookups.LocationBasedLookups;
using Qutell.ThreeSixty.Infrastructure.UnitofWork;

namespace Qutell.ThreeSixty.Api.Controllers.LocationBasedLookupsControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountryController : GenericController<Country, int>
    {
        public CountryController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
