using System.Collections.Generic;
using HonduRutas.Domain.Contracts;

namespace HonduRutas.Domain.Entities
{
    //This entity is required
    public class Trip : BaseEntity
    {
        public string RouteId { get; set; }

        public string ServiceId { get; set; }

        public int TripId { get; set; }

        public string TripHeadsign { get; set; }

        public string TripShortName { get; set; }

        public bool? DirectionId { get; set; }

        public int? BlockId { get; set; }

        private string ShapeId { get; set; }

        public virtual Route Route { get; set; }

        public virtual Calendar Calendar { get; set; }

        public virtual ICollection<StopTime> StopTimes { get; set; }


    }
}