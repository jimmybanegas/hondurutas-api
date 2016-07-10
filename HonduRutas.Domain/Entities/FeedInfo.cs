using System.Collections.Generic;

namespace HonduRutas.Domain.Entities
{
    //This entity is not required
    public class FeedInfo : IEntity
    {
        public bool IsValid(out ICollection<string> erroresValidacion)
        {
            throw new System.NotImplementedException();
        }
    }
}