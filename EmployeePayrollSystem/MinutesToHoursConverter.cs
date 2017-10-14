using System;
using System.Globalization;
using System.Windows.Data;

namespace EmployeePayrollSystem
{
    public class MinutesToHoursConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //TODO:
            //DateTime date = (DateTime)value;
            return value;
        }
        
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
