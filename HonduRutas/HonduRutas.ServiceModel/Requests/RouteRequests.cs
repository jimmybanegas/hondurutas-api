using HonduRutas.ServiceModel.DTO.Transit;
using ServiceStack;
using System.Collections.Generic;

namespace HonduRutas.ServiceModel.Requests
{
    [Route("/routes", "POST")]
    public class CreateRoute
    {
        public string Username { get; set; }
        public string RouteName { get; set; }
        public List<StopDTO> Stops { get; set; }
    }
}
