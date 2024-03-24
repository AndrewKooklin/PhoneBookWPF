using PhoneBookWPF.View;
using PhoneBookWPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                        _pbWindowViewModel.LeftCurrentView = null;
                        _pbWindowViewModel.LeftCurrentView = new RecordsView();
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
                        _pbWindowViewModel.LeftCurrentView = null;
                        _pbWindowViewModel.RightCurrentView = null;
                        //_pbWindowViewModel.LeftCurrentView = 
                        break;
                    }
                default:break;
            }
        }
    }
}
