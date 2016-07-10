using System.Collections.Generic;
using HonduRutas.Domain.Contracts;

namespace HonduRutas.Domain.Entities
{
    //This entity is required
    public class Calendar : BaseEntity
    {
        public string ServiceId { get; set; }

        public bool Monday { get; set; }

        public bool Tuesday { get; set; }

        public bool Wednesday { get; set; }

        public bool Thursday { get; set; }

        public bool Friday { get; set; }

        public bool Saturday { get; set; }

        public bool Sunday { get; set; }

        public System.DateTime StartDate { get; set; }

        public System.DateTime EndDate { get; set; }

        public virtual ICollection<Trip> Trips { get; set; }

    }
}