using Microsoft.AspNetCore.Mvc;
using Qutell.ThreeSixty.Infrastructure.UnitofWork;

namespace Qutell.ThreeSixty.Api.Controllers.otherLookups
{
    [ApiController]
    [Route("api/[controller]")]
    public class NafathController : GenericController<NafathController, int>
    {
        public NafathController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
