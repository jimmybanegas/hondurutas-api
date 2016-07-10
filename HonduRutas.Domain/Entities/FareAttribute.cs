using System.Collections.Generic;
using HonduRutas.Domain.Contracts;

namespace HonduRutas.Domain.Entities
{
    //This entity is not required
    public class FareAttribute : BaseEntity
    {
        public string FareId { get; set; }
        public decimal Price { get; set; }
        public string CurrencyType { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public int? Transfers { get; set; }
        public int? TransferDuration { get; set; }
    }

    public enum PaymentMethod
    {
        FareIsPaidOnBoard = 0,
        FareMustBePaidBeforeBoarding = 1
    }
}