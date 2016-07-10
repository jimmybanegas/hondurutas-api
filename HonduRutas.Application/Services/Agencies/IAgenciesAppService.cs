using HonduRutas.ServiceModel.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HonduRutas.Application.Services.Agencies
{
    public interface IAgenciesAppService : IDisposable
    {
        void CreateAgency(CreateAgency request);
    }
}
