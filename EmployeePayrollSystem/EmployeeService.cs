using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollSystem
{
    class EmployeeService
    {
        private Func<EmpDbContext> _empDbContext;

        public EmployeeService()
        {
            
        }

        public async Task<ObservableCollection<Employee>> GetEmployeesAsync()
        {
            ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
            foreach (var employee in await getEmpFromDatabaseAsync())
            {
                employees.Add(employee);
            } 
            return employees;
        }

        public static Collection<Employee> getPlainEmployees() {
            Collection<Employee> employees = new Collection<Employee>();
            employees.Add(new Employee() { EmpId = 1, FirstName = "Rakesh", LastName = "Girase", HireDate = new DateTime(2017, 10, 15) });
            employees.Add(new Employee() { EmpId = 2, FirstName = "Rakesh", LastName = "Girase", HireDate = new DateTime(2017, 10, 16) });
            employees.Add(new Employee() { EmpId = 3, FirstName = "Rakesh", LastName = "Girase", HireDate = new DateTime(2017, 10, 17) });
            employees.Add(new Employee() { EmpId = 4, FirstName = "Rakesh", LastName = "Girase", HireDate = new DateTime(2017, 10, 18) });
            return employees;
        }

        public static async Task<List<Employee>> getEmpFromDatabaseAsync() {
            using (var ctx = new EmpDbContext()) {
                return await ctx.Employee.AsNoTracking().ToListAsync(); 
            }
        }

        public async Task<List<EmployeeDetails>> GetPayDetail(Employee selectedEmployee, DateTime from, DateTime to)
        {
            using (var ctx = new EmpDbContext())
            {
                return await ctx.EmployeeDetails.AsNoTracking().ToListAsync();
            }
        }
    }
}