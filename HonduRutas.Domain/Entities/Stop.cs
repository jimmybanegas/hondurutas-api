using System.Collections.Generic;
using HonduRutas.Domain.Contracts;

namespace HonduRutas.Domain.Entities
{
    //This entity is required
    public class Stop  : BaseEntity
    {
        public string StopId { get; set; }

        public string StopCode { get; set; }

        public string StopName { get; set; }

        public string StopDesc { get; set; }

        public float StopLat { get; set; }

        public float StopLon { get; set; }

        public string ZoneId { get; set; }

        public string StopUrl { get; set; }

        public bool? LocationType { get; set; }

        public bool? ParentStation { get; set; }

        public string StopTimezone { get; set; }

        public virtual ICollection<StopTime> StopTimes { get; set; }
 
    }
}