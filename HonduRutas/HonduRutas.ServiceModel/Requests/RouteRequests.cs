using HonduRutas.ServiceModel.DTO.Transit;
using ServiceStack;
using System.Collections.Generic;

namespace HonduRutas.ServiceModel.Requests
{
    [Route("/routes", "POST")]
    public class CreateRoute
    {
        public string AgencyId { get; set; }
        public string RouteName { get; set; }
        public string RouteShortName { get; set; }
        public string RouteLongName { get; set; }
        public string RouteDescription { get; set; }
        public List<StopDTO> Stops { get; set; }
    }

    [Route("/routes/{RouteId}", "GET")]
    public class GetRoute
    {
        public int RouteId { get; set; }
    }

    [Route("/routes/{RouteId}", "DELETE")]
    public class RemoveRoute
    {
        public int RouteId { get; set; }
    }
}
