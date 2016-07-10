using System.Collections.Generic;

namespace HonduRutas.Domain.Entities
{
    //This entity is required
    public class Trip : IEntity
    {
        public bool IsValid(out ICollection<string> erroresValidacion)
        {
            throw new System.NotImplementedException();
        }
    }
}