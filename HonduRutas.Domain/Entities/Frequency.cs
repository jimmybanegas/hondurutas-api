using System;
using System.Collections.Generic;
using HonduRutas.Domain.Contracts;

namespace HonduRutas.Domain.Entities
{
    //This entity is not required
    public class Frequency : BaseEntity
    {
        public string TripId { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int HeadwaySecs { get; set; }
        public bool? ExactTimes { get; set; }
    }
}