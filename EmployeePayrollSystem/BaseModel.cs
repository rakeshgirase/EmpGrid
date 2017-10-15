using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EmployeePayrollSystem
{
    public class BaseModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged([CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(caller));
            }
        }
    }
}