using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;

namespace EmployeePayrollSystem
{
    class EmployeeDetailsWrapper: BaseModel, INotifyDataErrorInfo
    {
        private Regex DESCRIPTION_REGULAR_EXPRESSION = new Regex("Shift-[A-D];+");
        public EmployeeDetailsWrapper(EmployeeDetails employeeDetails)
        {
            EmployeeDetails = employeeDetails;
            this.PropertyChanged += ChangeTracker.Do_Something;
        }       

        public EmployeeDetails EmployeeDetails { get; }

        public int EmpId { get { return EmployeeDetails.EmpId; } set { EmployeeDetails.EmpId = value; } }

        public Employee Employee { get { return EmployeeDetails.Employee; } }

        public string Description { get { return EmployeeDetails.Description; }
            set {
                EmployeeDetails.Description = value;
                RaisePropertyChanged();
                ValidateProperty(nameof(Description));
            }
        }

        public int HoursWorked { get { return EmployeeDetails.HoursWorked; }
        set {
                EmployeeDetails.HoursWorked = value;
                RaisePropertyChanged();
                ValidateProperty(nameof(HoursWorked));
            }
        }

        public DateTime WorkDate {
            get { return EmployeeDetails.WorkDate; }
        }

        private void ValidateProperty(string propertyName)
        {
            clearErrors(propertyName);
            if (propertyName.Equals("HoursWorked"))
            {
                if (HoursWorked < 1 || HoursWorked > 600)
                {
                    AddError(propertyName, "Hours Worked should be between 1 and 600!!!");
                }
            }
            else if (propertyName.Equals("Description"))
            {
                Match match = DESCRIPTION_REGULAR_EXPRESSION.Match(Description);
                if (!match.Success)
                {
                    AddError(propertyName, "Description field can only Have Shift-A, Shift-B, Shift-C or Shift-D separated with ;");
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
