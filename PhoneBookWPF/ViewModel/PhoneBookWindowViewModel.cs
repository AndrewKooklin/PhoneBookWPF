using Newtonsoft.Json;
using PhoneBookWPF.Commands;
using PhoneBookWPF.HelpMethods;
using PhoneBookWPF.Model;
using PhoneBookWPF.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace PhoneBookWPF.ViewModel
{
    public class PhoneBookWindowViewModel : BaseViewModel
    {
        private HttpClient _httpClient { get; set; }
        private string url = @"https://localhost:44379/api/";
        private string urlRequest = "";
        private HttpResponseMessage response = new HttpResponseMessage();
        private bool apiResponseConvert;

        CheckInputFieldsRecord checkInputFieldsRecord = new CheckInputFieldsRecord();

        public PhoneBookWindowViewModel()
        {
            ReadRecordsCommand = new ReadRecordsCommand(this);
            UpdateViewCommand = new UpdateViewCommand(this);
            PhoneBooks = new List<PhoneBookRecord>();
            PhoneBooks = records.GetRecords().GetAwaiter().GetResult();
            RightCurrentView = new UserControl();
            OpenRegisterWindowCommand = new OpenRegisterWindowCommand();
            OpenLogInWindowCommand = new OpenLogInWindowCommand();
            LogOutCommand = new LogOutCommand();
            AddRecordCommand = new RelayCommand(Execute, CanExecute);
            DeleteRecordCommand = new DeleteRecordCommand(this);
        }

        private bool CanExecute(object parameter)
        {
            if (parameter == null)
            {
                return false;
            }
            return checkInputFieldsRecord.CheckFields(App.ActionsWithRecordView, parameter);
        }

        private async void Execute(object parameter)
        {
            if (parameter == null)
            {
                return;
            }
            CheckInputFieldsRecord checkInputFieldsRecord = new CheckInputFieldsRecord();
            var resultCheck = checkInputFieldsRecord.CheckFields(App.ActionsWithRecordView, parameter);

            if (!resultCheck)
            {
                return;
            }
            else
            {
                var fieldElements = (object[])parameter;
                string recordId = fieldElements[0].ToString();
                string recordLastName = fieldElements[1].ToString();
                string recordFirstName = fieldElements[2].ToString();
                string recordFathersName = fieldElements[3].ToString();
                string recordPhoneNumber = fieldElements[4].ToString();
                string recordAddress = fieldElements[5].ToString();
                string recordDescription = fieldElements[6].ToString();

                PhoneBookRecord record = new PhoneBookRecord
                {
                    LastName = recordLastName,
                    FirstName = recordFirstName,
                    FathersName = recordFathersName,
                    PhoneNumber = recordPhoneNumber,
                    Address = recordAddress,
                    Description = recordDescription
                };

                urlRequest = $"{url}" + "CreateRecordAPI/CreateRecord/" + $"{record}";
                using (_httpClient = new HttpClient())
                {
                    _httpClient.DefaultRequestHeaders.Accept.Clear();
                    _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    using (response = await _httpClient.PostAsJsonAsync(urlRequest, record))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        apiResponseConvert = JsonConvert.DeserializeObject<bool>(apiResponse);
                    }
                }

                if (!apiResponseConvert)
                {
                    App.ActionsWithRecordView.tbResult.Text = "Ошибка, проверьте работу" +
                                                              "\nAPI сервера!";
                    return;
                }
                else
                {
                    App.PhoneBookWindow.ccLeftPartPage = null;
                    App.PhoneBookWindow.ccLeftPartPage = new RecordsView();
                    App.ActionsWithRecordView.tbResult.Text = "Запись добавлена!";
                }
            }
        }

        Records records = new Records();

        public ICommand UpdateViewCommand { get; set; }

        public ICommand OpenRegisterWindowCommand { get; set; }

        public ICommand OpenLogInWindowCommand { get; set; }

        public ICommand LogOutCommand { get; set; }

        public ICommand ReadRecordsCommand { get; set; }

        public ICommand AddRecordCommand { get; set; }

        public ICommand DeleteRecordCommand { get; set; }

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
                    actions.tbRecordId.Text = _selectedRecord.Id.ToString();
                    actions.tbLastName.Text = _selectedRecord.LastName;
                    actions.tbFirstName.Text = _selectedRecord.FirstName;
                    actions.tbFathersName.Text = _selectedRecord.FathersName;
                    actions.tbPhoneNumber.Text = _selectedRecord.PhoneNumber;
                    actions.tbAddress.Text = _selectedRecord.Address;
                    actions.tbDescription.Text = _selectedRecord.Description;
                }

                return _selectedRecord;
            }
            set
            {
                //_selectedRecord = new PhoneBookRecord();
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

        private string _resultOperation = "";

        public string ResultOperation
        {
            get
            {
                return _resultOperation;
            }
            set
            {
                _resultOperation = value;
                OnPropertyChanged(nameof(ResultOperation));
            }
        }
    }
}

