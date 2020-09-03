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
    public class ReportingStructureRespository : IReportingStructureRepository
     
    {
        private readonly ReportingStructureContext _reportingStructureContext;
         private readonly EmployeeContext _employeeContext;

        private readonly ILogger<IReportingStructureRepository> _logger;

        public ReportingStructureRespository(ILogger<IReportingStructureRepository> logger, ReportingStructureContext ReportingStructureContext)
        {
            _reportingStructureContext = ReportingStructureContext;
            _logger = logger;
        }
        public Employee GetById(string id)
        {
            return _employeeContext.Employees.SingleOrDefault(e => e.EmployeeId == id);
        }

        public int SumDirectReports(string id)
        {
            return 1234;
            //return _ReportingStructureContext.ReportingStructures.SingleOrDefault(e => e.ReportingStructureId == id);
        }
    }
}
