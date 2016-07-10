using System.Collections.Generic;
using HonduRutas.Domain.Contracts;

namespace HonduRutas.Domain.Entities
{
    //This entity is required
    public class Agency : BaseEntity
    {
        public string AgencyId { get; set; }

        public string AgencyName { get; set; }

        public string AgencyUrl { get; set; }

        public string AgencyTimezone { get; set; }

        public string AgencyLang { get; set; }

        public string AgencyPhone { get; set; }

        public string AgencyFareUrl { get; set; }

        public ICollection<Route> Routes { get; set; }

    }
}