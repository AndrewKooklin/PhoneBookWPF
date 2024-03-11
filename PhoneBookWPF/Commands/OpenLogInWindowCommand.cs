using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PhoneBookWPF.Commands
{
    public class OpenLogInWindowCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (!App.Current.MainWindow.IsActive)
            {
                App.Current.MainWindow.Show();
            }
            else
            {
                App.Current.MainWindow.Activate();
            }
        }
    }
}
