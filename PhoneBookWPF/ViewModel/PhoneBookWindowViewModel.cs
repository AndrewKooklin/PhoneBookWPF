using PhoneBookWPF.Commands;
using PhoneBookWPF.HelpMethods;
using PhoneBookWPF.Model;
using PhoneBookWPF.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace PhoneBookWPF.ViewModel
{
    public class PhoneBookWindowViewModel : BaseViewModel
    {
        public PhoneBookWindowViewModel()
        {
            ReadRecordsCommand = new ReadRecordsCommand();
            UpdateViewCommand = new UpdateViewCommand(this);
        }

        public ICommand ReadRecordsCommand { get; set; }

        public ICommand UpdateViewCommand { get; set; }

        private UserControl _leftCurrentView = null;

        public UserControl LeftCurrentView
        {
            get
            {
                return _leftCurrentView;
            }
            set
            {
                _leftCurrentView = value;
                OnPropertyChanged(nameof(LeftCurrentView));
            }
        }

        private UserControl _rightCurrentView = null;

        public UserControl RightCurrentView
        {
            get
            {
                return _rightCurrentView;
            }
            set
            {
                _rightCurrentView = value;
                OnPropertyChanged(nameof(RightCurrentView));
            }
        }
    }
}

