using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using challenge.Models;
using Microsoft.Extensions.Logging;
using challenge.Repositories;

namespace challenge.Services
{
    public class CompensationService : ICompensationService
    {
        private readonly ICompensationRepository _CompensationRepository;
        private readonly ILogger<CompensationService> _logger;

        public CompensationService(ILogger<CompensationService> logger, ICompensationRepository CompensationRepository)
        {
            _CompensationRepository = CompensationRepository;
            _logger = logger;
        }

/*         public Compensation Create(Compensation Compensation)
        {
            if(Compensation != null)
            {
                _CompensationRepository.Add(Compensation);
                _CompensationRepository.SaveAsync().Wait();
            }

            return Compensation;
        } */

        public Compensation GetById(string id)
        {
            if(!String.IsNullOrEmpty(id))
            {
                return _CompensationRepository.GetById(id);
            }

            return null;
        }

       /*  public Compensation Replace(Compensation originalCompensation, Compensation newCompensation)
        {
            if(originalCompensation != null)
            {
                _CompensationRepository.Remove(originalCompensation);
                if (newCompensation != null)
                {
                    // ensure the original has been removed, otherwise EF will complain another entity w/ same id already exists
                    _CompensationRepository.SaveAsync().Wait();

                    _CompensationRepository.Add(newCompensation);
                    // overwrite the new id with previous Compensation id
                    newCompensation.CompensationId = originalCompensation.CompensationId;
                }
                _CompensationRepository.SaveAsync().Wait();
            }

            return newCompensation;
        } */
    }
}
