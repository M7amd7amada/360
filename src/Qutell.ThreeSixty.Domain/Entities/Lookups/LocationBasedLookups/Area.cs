using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qutell.ThreeSixty.Domain.Entities.Lookups.LocationBasedLookups
{
    public class Area(ILogger<Area> logger) : LookupBase
    {
        public int CityId { get; set; }
    }
}
