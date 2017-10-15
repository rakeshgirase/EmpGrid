using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EmployeePayrollSystem
{
    class EmployeeDetailsEnrichService
    {

        public ObservableCollection<EmployeeDetailsWrapper> enrich(List<EmployeeDetails> employeeDetails, Employee employee, DateTime from, DateTime to)
        {
            List<EmployeeDetailsWrapper> enrichedEmployeeDetails = employeeDetails.Select(avatar=>new EmployeeDetailsWrapper(avatar)).ToList();
            for (DateTime date = from; date <= to; date = date.AddDays(1)) {
                if (isRecordMissingForExistForDate(employeeDetails, date))                
                {
                    EmployeeDetails ed = new EmployeeDetails();
                    ed.Employee = employee;
                    ed.EmpId = employee.EmpId;
                    ed.WorkDate = date;
                    enrichedEmployeeDetails.Add(new EmployeeDetailsWrapper(ed));
                }
            }
            return new ObservableCollection<EmployeeDetailsWrapper>(enrichedEmployeeDetails.OrderBy(e => e.WorkDate).ToList());
        }

        private bool isRecordMissingForExistForDate(List<EmployeeDetails> employeeDetails, DateTime date)
        {
            return employeeDetails.Find(e => e.WorkDate.ToShortDateString().Equals(date.ToShortDateString())) == null;
        }
    }
}
