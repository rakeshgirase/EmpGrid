using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollSystem
{
    class EmployeeDetailsEnrichService
    {

        public List<EmployeeDetailsWrapper> enrich(List<EmployeeDetails> employeeDetails, Employee employee, DateTime from, DateTime to)
        {
            List<EmployeeDetailsWrapper> enrichedEmployeeDetails = employeeDetails.Select(e=>new EmployeeDetailsWrapper(e)).ToList();
            for (DateTime date = from; date <= to; date = date.AddDays(1)) {
                if (employeeDetails.Find(e => e.WorkDate.Equals(date)) == null)                
                {
                    EmployeeDetails ed = new EmployeeDetails();
                    ed.Employee = employee;
                    ed.EmpId = employee.EmpId;
                    ed.WorkDate = date;
                    enrichedEmployeeDetails.Add(new EmployeeDetailsWrapper(ed));
                }
            }
            return enrichedEmployeeDetails.OrderBy(e=>e.WorkDate).ToList();
        }
    }
}
