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
        

        public ReportingStructureService(ILogger<ReportingStructureService> logger)
        {
            //_reportingStructureRepository = reportingStructureRepository;
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

            public ReportingStructure GetById(string id)        {
                            {
            //return _employeeContext.Employees.SingleOrDefault(e => e.EmployeeId == id);
                ReportingStructure rs = new ReportingStructure();
                rs.EmployeeId = "1234";
                rs.NumberofReports = 1;
                return(rs);
        }
        }
    }
}
