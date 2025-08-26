using Microsoft.AspNetCore.Mvc;
using Qutell.ThreeSixty.Domain.Entities.Lookups.otherLookups;
using Qutell.ThreeSixty.Infrastructure.UnitofWork;

namespace Qutell.ThreeSixty.Api.Controllers.otherLookups
{
    [ApiController]
    [Route("api/[controller]")]
    public class SettingController :GenericController<Setting,int>
    {
        public SettingController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
