using Microsoft.AspNetCore.Mvc;
using Qutell.ThreeSixty.Domain.Entities.Lookups.CompanyRelatedLookups;
using Qutell.ThreeSixty.Infrastructure.UnitofWork;

namespace Qutell.ThreeSixty.Api.Controllers.CompanyRelatedLookupsControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyScaleController : GenericController<CompanyScale,int>
    {
        public CompanyScaleController(IUnitOfWork unetOfWork) : base(unetOfWork)
        {

        }
    }
}
