using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace EmployeePayrollSystem
{
    /// <summary>
    /// Summary description for Class1
    /// </summary>
    public class Employee : INotifyPropertyChanged
    {

        private int EmpId;
        private String _firstName;
        public String FirstName
        {
            get { return _FirstName; }
            set
            {
                _firstName = value;
                RaisePropertyChanged();
            }
        }


        private String _lastName;
        public String LastName {
            get { return _lastName; }
            set {
                _lastName = value;
                RaisePropertyChanged();
            }
        }

        private DateTime _hireDate;
        public DateTime HireDate
        {
            get { return _hireDate; }
            set
            {
                _hireDate = value;
                RaisePropertyChanged();

            }
        }


        public event PropertyChangedEventHandler PropertyChanged; 

        private void RaisePropertyChanged([CallerMemberName] string caller="") {
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }


    }
}