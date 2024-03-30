using PhoneBookWPF.ViewModel;
using System;
using System.Windows.Input;

namespace PhoneBookWPF.Commands
{
    public class UpdateViewCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private PhoneBookWindowViewModel _pbWindowViewModel;

        public UpdateViewCommand(PhoneBookWindowViewModel pbWindowViewModel)
        {
            _pbWindowViewModel = pbWindowViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if(parameter == null)
            {
                return;
            }

            switch (parameter.ToString())
            {
                case "Прочитать записи":
                    {
                        _pbWindowViewModel.LeftCurrentView = App.RecordsView;
                        break;
                    }
                case "Детали записи":
                case "Добавить запись":
                case "Изменить запись":
                case "Удалить запись":
                    {
                        _pbWindowViewModel.RightCurrentView = App.ActionsWithRecordView;
                        break;
                    }
                case "Список пользователей":
                    {
                        _pbWindowViewModel.LeftCurrentView = App.UsersView;
                        break;
                    }
                case "Добавить пользователя":
                    {
                        _pbWindowViewModel.LeftCurrentView = App.UsersView;
                        _pbWindowViewModel.RightCurrentView = App.ActionAddUserView;
                        break;
                    }
                case "Удалить пользователя":
                    {
                        _pbWindowViewModel.LeftCurrentView = App.UsersView;
                        _pbWindowViewModel.RightCurrentView = App.ActionDeleteUserView;
                        break;
                    }
                case "Добавить роль пользователю":
                case "Удалить роль у пользователя":
                    {
                        _pbWindowViewModel.LeftCurrentView = App.UsersView;
                        _pbWindowViewModel.RightCurrentView = App.ActionsRoleUserView;
                        break;
                    }
                case "Список ролей":
                    {
                        _pbWindowViewModel.LeftCurrentView = App.RolesView;
                        break;
                    }
                case "Добавить роль":
                case "Удалить роль":
                    {
                        _pbWindowViewModel.LeftCurrentView = App.RolesView;
                        _pbWindowViewModel.RightCurrentView = App.ActionsWithRoleView;
                        break;
                    }
                default:break;
            }
        }
    }
}
