using Microsoft.AspNetCore.Mvc;
using Qutell.ThreeSixty.Application.Services;
using Qutell.ThreeSixty.Domain.Entities.Lookups.GeneralLookups;

namespace Qutell.ThreeSixty.Api.Controllers.GeneralLookupsControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NationalityController : GenericController<Nationality, int>
    {
        public NationalityController(ILookupCacheService<Nationality, int> Service) : base(Service)
        {
        }
    }
}
