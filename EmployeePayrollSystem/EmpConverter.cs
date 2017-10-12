using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace EmployeePayrollSystem
{
    public class EmpConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Employee employee = (Employee)value;
            StringBuilder stringBuilder = new StringBuilder();
            return stringBuilder.Append(employee.EmpId).Append(" - ").Append(employee.LastName).Append(" , ").Append(employee.FirstName).Append(" - ").Append(employee.HireDate).ToString();            
        }


        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {            
            throw new Exception("Unable to convert string to datetime!!!");
        }
    }
}
