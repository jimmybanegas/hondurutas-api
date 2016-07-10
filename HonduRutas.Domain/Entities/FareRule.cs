using System.Collections.Generic;
using HonduRutas.Domain.Contracts;

namespace HonduRutas.Domain.Entities
{
    //This entity is not required
    public class FareRule : BaseEntity
    {
        public string FareId { get; set; }
        public string RouteId { get; set; }
        public string OriginId { get; set; }
        public string DestinationId { get; set; }
        public string ContainsId { get; set; }
    }
}