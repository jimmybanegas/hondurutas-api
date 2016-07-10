using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HonduRutas.Domain.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        void SaveChanges();
    }
}
