using System.Collections.Generic;

namespace HonduRutas.Domain.Entities
{
    //This entity is required
    public class Calendar : IEntity
    {
        public string CalendarId { get; set; }

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

        public bool IsValid(out ICollection<string> erroresValidacion)
        {
            throw new System.NotImplementedException();
        }
    }
}