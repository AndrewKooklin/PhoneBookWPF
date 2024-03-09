using PhoneBookWPF.Commands;
using PhoneBookWPF.HelpMethods;
using PhoneBookWPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PhoneBookWPF.ViewModel
{
    public class PhoneBookRecordsViewModel : BaseViewModel
    {
        Records records = new Records();

        public PhoneBookRecordsViewModel()
        {
            PhoneBooks = new List<PhoneBookRecord>();
            PhoneBooks = records.GetRecords().GetAwaiter().GetResult();
            GetRecordCommand = new GetRecordCommand();
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
                return _selectedRecord;
            }
            set
            {
                _selectedRecord = new PhoneBookRecord();
                _selectedRecord = value;
                OnPropertyChanged(nameof(SelectedRecord));
            }
        }

        public ICommand GetRecordCommand { get; set; }

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

