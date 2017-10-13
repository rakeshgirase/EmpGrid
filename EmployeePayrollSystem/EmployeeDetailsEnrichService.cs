using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollSystem
{
    class EmployeeDetailsEnrichService
    {

        public List<EmployeeDetails> enrich(List<EmployeeDetails> employeeDetails, Employee employee, DateTime from, DateTime to)
        {
            List<EmployeeDetails> enrichedEmployeeDetails = employeeDetails;
            for (DateTime date = from; date <= to; date = date.AddDays(1)) {
                if (employeeDetails.Find(e => e.WorkDate.Equals(date)) == null)                
                {
                    EmployeeDetails ed = new EmployeeDetails();
                    ed.Employee = employee;
                    ed.EmpId = employee.EmpId;
                    ed.WorkDate = date;
                    enrichedEmployeeDetails.Add(ed);
                }
            }
            return enrichedEmployeeDetails.OrderBy(e=>e.WorkDate).ToList();
        }
    }
}
