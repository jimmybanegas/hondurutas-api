using System.Collections.Generic;

namespace HonduRutas.Domain.Entities
{
    //This entity is required
    public class Agency : IEntity
    {
        public string AgencyId { get; set; }

        public string AgencyName { get; set; }

        public string AgencyUrl { get; set; }

        public string AgencyTimezone { get; set; }

        public string AgencyLang { get; set; }

        public string AgencyPhone { get; set; }

        public string AgencyFareUrl { get; set; }

        public ICollection<Route> Routes { get; set; }

        public bool IsValid(out ICollection<string> erroresValidacion)
        {
            throw new System.NotImplementedException();
        }
    }
}