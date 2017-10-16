using System;
using System.Windows;

namespace EmployeePayrollSystem
{
    public partial class App : Application
    {
        private void Application_DispatcherUnhandledExceptionHandler(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e) {
            MessageBox.Show("Unexpected error occurred. Please inform the admin." + Environment.NewLine + e.Exception.Message, "Unexpected Error");
            e.Handled = true;
            ChangeTracker.Clear();
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
             var mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
