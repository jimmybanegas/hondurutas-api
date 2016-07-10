using HonduRutas.Domain.Contracts;

namespace HonduRutas.Domain.Entities
{
    //This entity is required
    public class StopTime : BaseEntity
    {
        public int TripId { get; set; }

        public string ArrivalTime { get; set; }

        public string DepartureTime { get; set; }

        public string StopId { get; set; }

        public int StopSequence { get; set; }

        public string StopHeadsign { get; set; }

        public int? PickupType { get; set; }

        public int? DropOffType { get; set; }

        public string ShapeDistTraveled { get; set; }

        public virtual Stop Stop { get; set; }

        public virtual Trip Trip { get; set; }

    }
}