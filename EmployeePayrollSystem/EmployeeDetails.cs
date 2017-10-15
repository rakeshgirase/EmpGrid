using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeePayrollSystem
{
    [Table("EmployeeHours")]
    public class EmployeeDetails : BaseModel, ICloneable
    {
        private Employee _employee;
        [ForeignKey("EmpId")]
        public Employee Employee {
            get { return _employee; }
            set {
                _employee = value;
                RaisePropertyChanged();
            }
        }
                
        [Column(Order=0), Key]
        public int EmpId { get; set; }

        private DateTime _workDate;
        [Column(Order = 1), Key]
        public DateTime WorkDate
        {
            get { return _workDate; }
            set
            {
                _workDate = value;
                RaisePropertyChanged();

            }
        }

        private String _description;
        public String Description
        {
            get { return _description; }
            set
            {
                _description = value;
                RaisePropertyChanged();

            }
        }

        private int _hoursWorked;
        [Required]        
        public int HoursWorked
        {
            get { return _hoursWorked; }
            set
            {
                _hoursWorked = value;
                RaisePropertyChanged();

            }
        }

        public Object Clone()
        {
            EmployeeDetails cloned = new EmployeeDetails();
            cloned.Employee = this.Employee;
            cloned.EmpId = this.EmpId;
            cloned.WorkDate = this.WorkDate;
            cloned.HoursWorked = this.HoursWorked;
            cloned.Description = this.Description;
            return cloned;
        }
    }
}