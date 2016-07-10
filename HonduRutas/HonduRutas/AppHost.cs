using Funq;
using ServiceStack;
using Autofac;
using ServiceStack.Text;
using System.Collections.Generic;
using HonduRutas.Adapters;
using HonduRutas.Data;
using HonduRutas.Data.ContractImplementation;
using HonduRutas.Domain.Contracts;
using System.Data.Entity;
using HonduRutas.Application.Services.Routes;
using HonduRutas.ServiceInterface.Services;
using HonduRutas.Application.Services.Agencies;

namespace HonduRutas
{
    public class AppHost : AppHostBase
    {
        private readonly ICollection<string> allowedOrigins = new[] { "*" };

        /// <summary>
        /// Default constructor.
        /// Base constructor requires a name and assembly to locate web service classes. 
        /// </summary>
        public AppHost()
            : base("HonduRutas", typeof(RouteService).Assembly)
        {

        }

        /// <summary>
        /// Application specific configuration
        /// </summary>
        public override void Configure(Container container)
        {
            var builder = new ContainerBuilder();
            JsConfig.EmitCamelCaseNames = true;
            Plugins.Add(new CorsFeature(
                allowedHeaders: "Content-Type",
                allowCredentials: false,
                allowOriginWhitelist: allowedOrigins
            ));

            ConfigureDataDependencies(builder);
            ConfigureApplicationLayerDependencies(builder);

            container.Adapter = new AutofacContainerAdapter(builder.Build());
        }

        private void ConfigureApplicationLayerDependencies(ContainerBuilder container)
        {
            container.RegisterType<RoutesAppService>().As<IRoutesAppService>();
            container.RegisterType<AgenciesAppService>().As<IAgenciesAppService>();
        }

        /// <summary>
        /// Register implementations for Data related interfaces
        /// </summary>
        /// <param name="builder"></param>
        private void ConfigureDataDependencies(ContainerBuilder builder)
        {
            var context = new APIContext();
            builder.RegisterInstance(context).As<DbContext>();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>));
        }
    }
}