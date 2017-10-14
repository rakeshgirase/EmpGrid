using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace EmployeePayrollSystem
{
    class EmployeeDetailsWrapper: BaseModel, INotifyDataErrorInfo
    {
        public EmployeeDetailsWrapper(EmployeeDetails employeeDetails)
        {
            EmployeeDetails = employeeDetails;
        }

        public EmployeeDetails EmployeeDetails { get; }

        public int EmpId { get { return EmployeeDetails.EmpId; } }

        public Employee Employee { get { return EmployeeDetails.Employee; } }

        public string Description { get { return EmployeeDetails.Description; } }

        public int HoursWorked { get { return EmployeeDetails.HoursWorked; }
        set {
                EmployeeDetails.HoursWorked = value;
                //RaisePropertyChanged();
                ValidateProperty(nameof(HoursWorked));
            }
        }

        public DateTime WorkDate {
            get { return EmployeeDetails.WorkDate; }
        }

        private void ValidateProperty(string propertyName)
        {
            clearErrors(propertyName);
            if (propertyName.Equals("HoursWorked")) {
                if (HoursWorked < 1 || HoursWorked > 600)
                {
                    AddError(propertyName, "Hours Worked should be between 1 and 600!!!");
                }
            }
        }

        private Dictionary<String, List<String>> _errorsByPropertyName = new Dictionary<string, List<string>>();
        public bool HasErrors => _errorsByPropertyName.Any();

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public IEnumerable GetErrors(string propertyName)
        {
            return _errorsByPropertyName.ContainsKey(propertyName) ? _errorsByPropertyName[propertyName] : null;
        }

        private void OnErrorChanged(string propertyName) {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        }

        private void AddError(string propertyName, string error) {
            if (!_errorsByPropertyName.ContainsKey(propertyName)) {
                _errorsByPropertyName[propertyName] = new List<string>();
            }
            if(!_errorsByPropertyName[propertyName].Contains(error)) {
                _errorsByPropertyName[propertyName].Add(error);
                OnErrorChanged(propertyName);
            }
        }

        private void clearErrors(string propertyName) {
            _errorsByPropertyName.Remove(propertyName);
            OnErrorChanged(propertyName);
        }
    }
}
