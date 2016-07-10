using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HonduRutas.ServiceModel.DTO.Transit
{
    public class RouteDTO
    {
        public string AgencyId { get; set; }
        public string LongName { get; set; }
        public int RouteId { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
    }
}
