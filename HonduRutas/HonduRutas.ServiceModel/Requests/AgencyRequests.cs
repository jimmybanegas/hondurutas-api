using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HonduRutas.ServiceModel.Requests
{
    [Route("/agencies", "POST")]
    public class CreateAgency
    {
        public string AgencyId { get; set; }

        public string AgencyName { get; set; }

        public string AgencyUrl { get; set; }

        public string AgencyLang { get; set; }

        public string AgencyPhone { get; set; }

        public string AgencyFareUrl { get; set; }

    }
}
