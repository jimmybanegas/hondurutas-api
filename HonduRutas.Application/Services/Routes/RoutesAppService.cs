using HonduRutas.Data.ContractImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HonduRutas.ServiceModel.Requests;
using HonduRutas.Domain.Entities;
using HonduRutas.Domain.Contracts;

namespace HonduRutas.Application.Services.Routes
{
    public class RoutesAppService : DisposableBase, IRoutesAppService
    {
        private readonly IRepository<Route> _routesRepository;

        public RoutesAppService(IRepository<Route> routesRepository)
        {
            if (routesRepository == null)
                throw new ArgumentNullException("routesRepository");

            _routesRepository = routesRepository;
        }

        public void CreateRoute(CreateRoute request)
        {
            var newRoutes = new Route()
            {
                RouteId = "test"
            };
            _routesRepository.Insert(newRoutes);

            _routesRepository.UnitOfWork.SaveChanges();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_routesRepository != null) _routesRepository.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
