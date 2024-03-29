﻿using PhoneBookWPF.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PhoneBookWPF.Commands
{
    public class RedirectRegistrationCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (!App.RegistrationWindow.IsInitialized)
            {
                App.RegistrationWindow = new RegistrationWindow();
                App.RegistrationWindow.Show();
            }
            if (!App.RegistrationWindow.IsLoaded)
            {
                App.RegistrationWindow = new RegistrationWindow();
                App.RegistrationWindow.Show();
            }
            else
            {
                App.RegistrationWindow.InitializeComponent();
                App.RegistrationWindow.Show();
                App.RegistrationWindow.Activate();
                App.RegistrationWindow.Focus();
            }
        }
    }
}
