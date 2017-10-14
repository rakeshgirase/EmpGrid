using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeePayrollSystem
{
    [Table("EmployeeHours")]
    public class EmployeeDetails : BaseModel
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

        [Column("EmpId")]
        public int EmpId { get; set; }

        private DateTime _workDate;
        [Key]
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
   }
}