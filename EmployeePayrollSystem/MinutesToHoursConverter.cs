using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Data;

namespace EmployeePayrollSystem
{
    public class MinutesToHoursConverter : IValueConverter
    {
        private Regex DESCRIPTION_REGULAR_EXPRESSION = new Regex("^([0-9]|0[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$");
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int minutes = (int)value;
            int hours = minutes / 60;
            minutes %= 60;
            return hours+":"+minutes.ToString("D2");
            //return value;
        }
        
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            String result = value.ToString();
            if (DESCRIPTION_REGULAR_EXPRESSION.IsMatch(value.ToString())) {
                string[] temp = result.Split(':');                
                int mins = System.Convert.ToInt32(temp[0]) * 60 + System.Convert.ToInt32(temp[1]);
                result = mins.ToString();
            }
            return result;
        }
    }
}
