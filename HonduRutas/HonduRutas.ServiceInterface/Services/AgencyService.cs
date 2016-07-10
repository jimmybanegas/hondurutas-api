using HonduRutas.Application.Services.Agencies;
using HonduRutas.ServiceModel.Requests;
using ServiceStack;
using System;

namespace HonduRutas.ServiceInterface.Services
{
    public class AgencyService : Service
    {
        private readonly IAgenciesAppService _agenciesAppService;

        public AgencyService(IAgenciesAppService agenciesAppService)
        {
            if (agenciesAppService == null)
                throw new ArgumentNullException("agenciesAppService");

            _agenciesAppService = agenciesAppService;
        }

        public string Post(CreateAgency request)
        {
            _agenciesAppService.CreateAgency(request);
            return "Successfully created agency!";
        }
    }
}
