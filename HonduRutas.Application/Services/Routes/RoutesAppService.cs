using HonduRutas.Data.ContractImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HonduRutas.ServiceModel.Requests;
using HonduRutas.Domain.Entities;
using HonduRutas.Domain.Contracts;
using HonduRutas.ServiceModel.DTO.Transit;

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
                AgencyId = request.AgencyId,
                RouteShortName = request.RouteShortName,
                RouteLongName = request.RouteLongName,
                RouteDesc = request.RouteDescription
            };
            _routesRepository.Insert(newRoutes);

            _routesRepository.UnitOfWork.SaveChanges();
        }

        public RouteDTO GetRoute(GetRoute request)
        {
            var foundRoute = _routesRepository.FirstOrDefault(r => r.RouteId == request.RouteId);

            if (foundRoute == null) return null;

            return CreateDTOFromRoute(foundRoute);
        }

        private RouteDTO CreateDTOFromRoute(Route foundRoute)
        {
            return new RouteDTO
            {
                AgencyId = foundRoute.AgencyId,
                RouteId = foundRoute.RouteId,
                ShortName = foundRoute.RouteShortName,
                LongName = foundRoute.RouteLongName,
                Description = foundRoute.RouteDesc
            };
        }

        public RouteDTO RemoveRoute(RemoveRoute request)
        {
            var foundRoute = _routesRepository.FirstOrDefault(r => r.RouteId == request.RouteId);

            if (foundRoute == null) return null;

            _routesRepository.Delete(foundRoute);
            _routesRepository.UnitOfWork.SaveChanges();

            return CreateDTOFromRoute(foundRoute);
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
