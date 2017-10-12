using System;
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

        public MainWindow()
        {
            employeeService = new EmployeeService();
            InitializeComponent();
            Load();            
        }

        private async void Load() {
            employees = await employeeService.GetEmployeesAsync();
            employeePayGrid.ItemsSource = employees;
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
            }
            empShortDetails.SelectedItem = employees[index];
                --index;             
        }

        private async void Refresh_Data_Grid(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            Employee selectedEmployee = (Employee)empShortDetails.SelectedItem;
            DateTime from = new DateTime();
            DateTime to = new DateTime();
            List<EmployeeDetails> employeeDetails = await employeeService.GetPayDetail(selectedEmployee, from, to);
            employeePayGrid.ItemsSource = employeeDetails;
        }
    }
}