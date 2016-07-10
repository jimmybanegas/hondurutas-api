using HonduRutas.ServiceModel.Requests;
using ServiceStack;

namespace HonduRutas.ServiceInterface.Services
{
    public class AwakeService : Service
    {
        public string Get(AwakenRequest request)
        {
            return "API is awake! Cheers!";
        }
    }
}
