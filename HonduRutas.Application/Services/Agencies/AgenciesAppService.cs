using HonduRutas.Data.ContractImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HonduRutas.ServiceModel.Requests;
using HonduRutas.Domain.Entities;
using HonduRutas.Domain.Contracts;

namespace HonduRutas.Application.Services.Agencies
{
    public class AgenciesAppService : DisposableBase, IAgenciesAppService
    {
        private readonly IRepository<Agency> _agencyRepository;

        public AgenciesAppService(IRepository<Agency> agencyRepository)
        {
            if (agencyRepository  == null)
                throw new ArgumentNullException("agencyRepository");

            _agencyRepository = agencyRepository;
        }

        public void CreateAgency(CreateAgency request)
        {
            var newAgency = new Agency
            {
                AgencyId = request.AgencyId,
                AgencyName = request.AgencyName,
                AgencyUrl = request.AgencyUrl,
                AgencyFareUrl = request.AgencyFareUrl,
                AgencyLang = request.AgencyLang,
                AgencyPhone = request.AgencyPhone
            };

            _agencyRepository.Insert(newAgency);
            _agencyRepository.UnitOfWork.SaveChanges();
        }
    }
}
