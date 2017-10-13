﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace EmployeePayrollSystem
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<Employee> employees;
        private int index = 0;
        private EmployeeService employeeService;
        private List<EmployeeDetails> employeeDetails;

        public MainWindow()
        {
            employeeService = new EmployeeService();
            InitializeComponent();
            Load();
            pay_start_date.SelectedDate = getLastDay(DayOfWeek.Sunday);
            pay_end_date.SelectedDate = pay_start_date.SelectedDate.Value.AddDays(14);
        }

        public DateTime getLastDay(DayOfWeek day) {
            DateTime lastDay = DateTime.Now;
            while (lastDay.DayOfWeek != day)
                lastDay = lastDay.AddDays(-1);
            return lastDay;
        }

        private async void Load() {
            employees = await employeeService.GetEmployeesAsync();
            empShortDetails.ItemsSource = employees;
            empShortDetails.SelectedItem = employees[index];            
        }

        private void Next_Button_Click(object sender, RoutedEventArgs e)
        {
            if (index == employees.Count - 1)
            {
                index = 0;                
            }
            else
            {
                ++index;
            }
            empShortDetails.SelectedItem = employees[index];
        }

        private void Previous_Button_Click(object sender, RoutedEventArgs e)
        {
            if (index == 0)
            {
                index = employees.Count - 1;                
            }
            else
            {

                --index;
            }
            empShortDetails.SelectedItem = employees[index];             
        }

        private async void Refresh_Data_Grid(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            Employee selectedEmployee = (Employee)empShortDetails.SelectedItem;
            if (selectedEmployee == null) {
                selectedEmployee = employees[0];
            }
            DateTime from = pay_start_date.SelectedDate.Value;
            DateTime to = pay_end_date.SelectedDate.Value;
            employeeDetails = await employeeService.GetPayDetail(selectedEmployee, from, to);
            List<EmployeeDetails> enrichedEmployeeDetails = new EmployeeDetailsEnrichService().enrich(employeeDetails, selectedEmployee, from, to);
            totalHours.Content = 0;
            List<int> numbers = new List<int>();
            totalHours.Content = sumWorkHours(enrichedEmployeeDetails);
            employeePayGrid.ItemsSource = enrichedEmployeeDetails;
        }

        private int sumWorkHours(List<EmployeeDetails> enrichedEmployeeDetails)
        {
            int totalWorkHours = 0;
            foreach (var empDetails in enrichedEmployeeDetails ) {
                totalWorkHours += empDetails.HoursWorked;
            }
            return totalWorkHours;
        }

        public void Pay_Start_Date_Changed(object sender, EventArgs e)
        {
            if (pay_end_date.SelectedDate!=null && (pay_end_date.SelectedDate.Value - pay_start_date.SelectedDate.Value).Days != 14) {
                pay_end_date.SelectedDate = pay_start_date.SelectedDate.Value.AddDays(14);
            }
            
        }

        public void Pay_End_Date_Changed(object sender, EventArgs e)
        {
            if (pay_end_date.SelectedDate != null && (pay_end_date.SelectedDate.Value - pay_start_date.SelectedDate.Value).Days != 14)
            {
                pay_start_date.SelectedDate = pay_end_date.SelectedDate.Value.AddDays(-14);
            }            
        }

        private void Save(object sender, RoutedEventArgs e)
        {

        }
    }
}