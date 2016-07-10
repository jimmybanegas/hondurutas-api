using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HonduRutas.Domain.Contracts
{
    /// <summary>
    /// Base class for all entities in order to work with the repository
    /// </summary>
    public class BaseEntity : IEntity
    {
        public bool IsValid(out ICollection<string> erroresValidacion)
        {
            throw new NotImplementedException();
        }
    }
}
