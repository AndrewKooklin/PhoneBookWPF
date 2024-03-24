using PhoneBookWPF.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PhoneBookWPF.Commands
{
    public class RedirectToLogInCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (!App.MainWindow.IsInitialized)
            {
                App.MainWindow = new MainWindow();
                App.MainWindow.Show();
            }
            if (!App.MainWindow.IsLoaded)
            {
                App.MainWindow = new MainWindow();
                App.MainWindow.Show();
            }
            else
            {
                App.MainWindow.InitializeComponent();
                App.MainWindow.Show();
                App.MainWindow.Activate();
                App.MainWindow.Focus();
            }
        }
    }
}
