using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using challenge.Models;
using Microsoft.Extensions.Logging;
using challenge.Repositories;

namespace challenge.Services
{
    public class ReportingStructureService : IReportingStructureService 

  
    {
        private readonly IReportingStructureService _reportingStructureRepository;
        private readonly ILogger<ReportingStructureService> _logger;

        private readonly IEmployeeRepository _employeeRepository;
        

        public ReportingStructureService(ILogger<ReportingStructureService> logger, IReportingStructureRepository reportingStructureRepository)
        {
            _reportingStructureRepository = reportingStructureRepository;
            _logger = logger;
        }

        /*public Employee GetById(string id)
        {
            if(!String.IsNullOrEmpty(id))
            {
                return _employeeRepository.GetById(id);
            }

            return null;
        }*/

            public Employee GetById(string id)        {
                            {
            return _employeeContext.Employees.SingleOrDefault(e => e.EmployeeId == id);
        }
        }
    }
}
