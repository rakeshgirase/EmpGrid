using System;
using System.Globalization;
using System.Windows.Data;

namespace EmployeePayrollSystem
{
    public class DateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime date = (DateTime)value;
            return date.ToString("d");
        }
        
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string stringValue = value as string;
            DateTime resultDateTime;
            if (DateTime.TryParse(stringValue, out resultDateTime))
            {
                return resultDateTime;
            }
            throw new Exception("Unable to convert string to datetime!!!");
        }
    }
}
