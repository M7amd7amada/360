using Microsoft.AspNetCore.Mvc;
using Qutell.ThreeSixty.Domain.Entities.Lookups.otherLookups;
using Qutell.ThreeSixty.Infrastructure.UnitofWork;

namespace Qutell.ThreeSixty.Api.Controllers.otherLookups
{
    [ApiController]
    [Route("api/[controller]")]
    public class OptionSetController : GenericController<OptionSet, int>
    {
        public OptionSetController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }

}
