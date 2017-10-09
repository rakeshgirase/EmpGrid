using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollSystem
{
    class EmployeeService
    {
        public static ObservableCollection<Employee> GetEmployees()
        {
            ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
            employees.Add(new Employee() { EmpId= 1, FirstName = "Rakesh", LastName = "Girase", HireDate = new DateTime(2017, 10, 15) });
            employees.Add(new Employee() { EmpId = 2, FirstName = "Rakesh", LastName = "Girase", HireDate = new DateTime(2017, 10, 16) });
            employees.Add(new Employee() { EmpId = 3, FirstName = "Rakesh", LastName = "Girase", HireDate = new DateTime(2017, 10, 17) });
            employees.Add(new Employee() { EmpId = 4, FirstName = "Rakesh", LastName = "Girase", HireDate = new DateTime(2017, 10, 18) });
            return employees;
        }
    }
}
