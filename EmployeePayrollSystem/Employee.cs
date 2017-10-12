﻿using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeePayrollSystem
{
   public class Employee : INotifyPropertyChanged
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