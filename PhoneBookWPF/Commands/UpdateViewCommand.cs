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
                case "Прочитать":
                    {
                        _pbWindowViewModel.LeftCurrentView = App.RecordsView;
                        break;
                    }
                case "Добавить":
                case "Детали":
                case "Изменить":
                case "Удалить":
                    {
                        _pbWindowViewModel.RightCurrentView = App.ActionsWithRecordView;
                        break;
                    }
                default:break;
            }
        }
    }
}
