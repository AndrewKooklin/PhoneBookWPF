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
            ReadRecordsCommand = new ReadRecordsCommand(this);
            UpdateViewCommand = new UpdateViewCommand(this);
            PhoneBooks = new List<PhoneBookRecord>();
            PhoneBooks = records.GetRecords().GetAwaiter().GetResult();
            GetRecordCommand = new GetRecordCommand();
            RightCurrentView = new UserControl();
        }

        PhoneBookRecord bookRecord = new PhoneBookRecord();

        Records records = new Records();

        public ICommand ReadRecordsCommand { get; set; }

        public ICommand GetRecordCommand { get; set; }

        public ICommand UpdateViewCommand { get; set; }

        private UserControl _leftCurrentView;

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

        private UserControl _rightCurrentView;

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

        private List<PhoneBookRecord> _phoneBooks;

        public List<PhoneBookRecord> PhoneBooks
        {
            get
            {
                return _phoneBooks;
            }
            set
            {
                _phoneBooks = value;
                OnPropertyChanged(nameof(PhoneBooks));
            }
        }

        private PhoneBookRecord _selectedRecord;

        public PhoneBookRecord SelectedRecord
        {
            get
            {
                if (_selectedRecord == null)
                {
                    return null;
                }
                else
                {
                    
                    this.RightCurrentView = App.ActionsWithRecordView;
                    var actions = (ActionsWithRecordView)this.RightCurrentView;
                    //this.RightCurrentView.Content.
                    //var view = (ActionsWithRecordView)RightCurrentView;
                    actions.tbRecordId.Text = _selectedRecord.Id.ToString();
                    actions.tbLastName.Text = _selectedRecord.LastName;
                    actions.tbFirstName.Text = _selectedRecord.FirstName;
                    actions.tbFathersName.Text = _selectedRecord.FathersName;
                    actions.tbPhoneNumber.Text = _selectedRecord.PhoneNumber;
                    actions.tbAddress.Text = _selectedRecord.Address;
                    actions.tbDescription.Text = _selectedRecord.Description;
                    
                    //actions.InitializeComponent();
                }

                return _selectedRecord;
            }
            set
            {
                _selectedRecord = new PhoneBookRecord();
                _selectedRecord = value;
                OnPropertyChanged(nameof(SelectedRecord));
            }
        }

        private string _errorSelection = "";

        public string ErrorSelection
        {
            get
            {
                return _errorSelection;
            }
            set
            {
                _errorSelection = value;
                OnPropertyChanged(nameof(ErrorSelection));
            }
        }
    }
}

