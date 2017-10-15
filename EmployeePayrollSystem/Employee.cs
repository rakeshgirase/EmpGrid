using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeePayrollSystem
{
    public class Employee : BaseModel
    {
        
        private int _empId;
        [Key]
        public int EmpId
        {
            get { return _empId; }
            set
            {
                _empId = value;
                RaisePropertyChanged();
            }
        }

        private String _firstName;
        [Column("EmpFirstName")]
        public String FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                RaisePropertyChanged();
            }
        }
        
        private String _lastName;
        [Column("EmpLastName")]
        public String LastName
        {
            get { return _lastName; }
            set
            {
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
   }
}