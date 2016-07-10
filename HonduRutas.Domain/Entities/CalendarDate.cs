using System;
using System.Collections.Generic;
using HonduRutas.Domain.Contracts;

namespace HonduRutas.Domain.Entities
{
    //This entity is not required
    public class CalendarDate : BaseEntity
    {
        public string ServiceId { get; set; }

        public DateTime Date { get; set; }
     
        public ExceptionType ExceptionType { get; set; }
    }

    public enum ExceptionType
    {
        Added = 1,
        Removed = 2
    }
}