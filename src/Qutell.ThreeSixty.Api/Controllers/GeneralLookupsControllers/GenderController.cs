using Microsoft.AspNetCore.Mvc;
using Qutell.ThreeSixty.Application.Services;
using Qutell.ThreeSixty.Domain.Entities.Lookups.GeneralLookups;
namespace Qutell.ThreeSixty.Api.Controllers.GeneralLookupsControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenderController : GenericController<Gender, int>
    {
        public GenderController(ILookupCacheService<Gender, int> Service) : base(Service)
        {
        }
    }
}
