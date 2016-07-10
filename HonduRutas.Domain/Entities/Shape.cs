using System.Collections.Generic;
using HonduRutas.Domain.Contracts;

namespace HonduRutas.Domain.Entities
{
    //This entity is not required
    public class Shape : BaseEntity
    {
        public string ShapeId { get; set; }

        public decimal ShapePtLat { get; set; }

        public decimal ShapePtLon { get; set; }

        public int ShapePtSequence { get; set; }

        public decimal ShapeDistTraveled { get; set; }

    }
}