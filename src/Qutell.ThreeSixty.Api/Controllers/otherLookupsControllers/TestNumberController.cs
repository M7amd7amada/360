using Microsoft.AspNetCore.Mvc;
using Qutell.ThreeSixty.Domain.Entities.Lookups.otherLookups;
using Qutell.ThreeSixty.Infrastructure.UnitofWork;
using System.Security.Cryptography.X509Certificates;

namespace Qutell.ThreeSixty.Api.Controllers.otherLookups
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestNumberController:GenericController<TestNumber,int>
    {
        public TestNumberController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
