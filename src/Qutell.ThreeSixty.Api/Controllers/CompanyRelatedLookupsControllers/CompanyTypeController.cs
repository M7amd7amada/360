using Microsoft.AspNetCore.Mvc;
using Qutell.ThreeSixty.Domain.Entities.Lookups.CompanyRelatedLookups;
using Qutell.ThreeSixty.Infrastructure.UnitofWork;

namespace Qutell.ThreeSixty.Api.Controllers.CompanyRelatedLookupsControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyTypeController : GenericController<CompanyType,int>
    {
        public CompanyTypeController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
    }
}
