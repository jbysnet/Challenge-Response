using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using challenge.Models;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using challenge.Data;

namespace challenge.Repositories
{
    public class CompensationRespository : ICompensationRepository
    {
        private readonly CompensationContext _CompensationContext;
        private readonly ILogger<ICompensationRepository> _logger;

        public CompensationRespository(ILogger<ICompensationRepository> logger, CompensationContext CompensationContext)
        {
            _CompensationContext = CompensationContext;
            _logger = logger;
        }
        public Compensation GetById(string id)
        {
            return _CompensationContext.TotalCompensation.SingleOrDefault(e => e.EmployeeId == id);
        }
    }
}
