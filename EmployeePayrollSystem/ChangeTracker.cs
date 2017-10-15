using System.Collections.Generic;
using System.ComponentModel;

namespace EmployeePayrollSystem
{
    internal class ChangeTracker
    {
        public static List<EmployeeDetails> changedItems = new List<EmployeeDetails>();
        
        public static void Add_Changed_Element(object sender, PropertyChangedEventArgs e)
        {
            EmployeeDetailsWrapper wrapper = (EmployeeDetailsWrapper)sender;
            changedItems.Add(wrapper.EmployeeDetails);
        }

        public static void Clear()
        {
            changedItems.Clear();
        }
    }
}