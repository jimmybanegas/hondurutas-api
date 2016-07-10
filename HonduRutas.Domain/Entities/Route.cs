using System.Collections.Generic;
using HonduRutas.Domain.Contracts;

namespace HonduRutas.Domain.Entities
{
    using System.Collections.ObjectModel;
    //This entity is required
    public class Route : BaseEntity
    {
        public int RouteId { get; set; }

        public string AgencyId { get; set; }

        public string RouteShortName { get; set; }

        public string RouteLongName { get; set; }

        public string RouteDesc { get; set; }

        public int RouteType { get; set; }

        public string RouteUrl { get; set; }

        public string RouteColor { get; set; }

        public string RouteTextColor { get; set; }

        // TODO: Setup a mapping for these entities before attempting to commit changes to the database
        public virtual Agency Agency { get; set; }

        //public virtual  ICollection<Trip> Trips { get; set; }

    }
}