using HonduRutas.ServiceModel.DTO.Transit;
using HonduRutas.ServiceModel.Requests;
using System;

namespace HonduRutas.Application.Services.Routes
{
    /// <summary>
    /// Contract for the routes application service
    /// </summary>
    public interface IRoutesAppService : IDisposable
    {
        /// <summary>
        /// Creates a new route
        /// </summary>
        void CreateRoute(CreateRoute request);
        RouteDTO GetRoute(GetRoute request);
        RouteDTO RemoveRoute(RemoveRoute request);
    }
}
