using Autofac;
using ServiceStack.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HonduRutas.Adapters
{
    /// <summary>
    /// Autofac implementation of the ServiceStack's ICOntainerAdapter
    /// </summary>
    public class AutofacContainerAdapter : IContainerAdapter
    {
        private readonly IContainer container;

        public AutofacContainerAdapter(IContainer container)
        {
            this.container = container;
        }

        public T Resolve<T>()
        {
            return container.Resolve<T>();
        }

        public T TryResolve<T>()
        {
            T result;

            if (container.TryResolve<T>(out result))
            {
                return result;
            }

            return default(T);
        }
    }
}
