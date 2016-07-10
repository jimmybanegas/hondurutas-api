using HonduRutas.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HonduRutas.Data.ContractImplementation
{
    public class UnitOfWork : DisposableBase, IUnitOfWork
    {
        protected DbContext Context { get; set; }

        public UnitOfWork(DbContext context)
        {
            Context = context;
        }
        public void SaveChanges()
        {
            Context.SaveChanges();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Release managed resources.
                if (Context != null) Context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
