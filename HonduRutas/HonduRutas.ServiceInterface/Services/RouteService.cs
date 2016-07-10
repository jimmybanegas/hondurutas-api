using HonduRutas.Application.Services.Routes;
using HonduRutas.ServiceModel.Requests;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HonduRutas.ServiceInterface.Services
{
    public class RouteService : Service
    {
        private readonly IRoutesAppService _routesAppService;

        public RouteService(IRoutesAppService routesAppService)
        {
            if (routesAppService == null)
                throw new ArgumentNullException("routesAppService");

            _routesAppService = routesAppService;
        }

        public void Post(CreateRoute request)
        {
            _routesAppService.CreateRoute(request);
        }
    }
}
