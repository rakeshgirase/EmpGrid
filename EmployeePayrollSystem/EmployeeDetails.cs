using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeePayrollSystem
{
    [Table("EmployeeHours")]
    public class EmployeeDetails : INotifyPropertyChanged
    {

        private Employee _employee;
        [Key]
        public Employee Employee {
            get { return _employee; }
            set {
                _employee = value;
                RaisePropertyChanged();
            }
        }
        
        private DateTime _workDate;
        [Key]
        public DateTime Workdate
        {
            get { return _workDate; }
            set
            {
                _workDate = value;
                RaisePropertyChanged();

            }
        }

        private String _description;
        public String description
        {
            get { return _description; }
            set
            {
                _description = value;
                RaisePropertyChanged();

            }
        }

        private int _hoursWorked;
        public int hoursWorked
        {
            get { return _hoursWorked; }
            set
            {
                _hoursWorked = value;
                RaisePropertyChanged();

            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged([CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }
   }
}