using Newtonsoft.Json;
using PhoneBookWPF.HelpMethods;
using PhoneBookWPF.Model;
using PhoneBookWPF.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PhoneBookWPF.Commands
{
    public class AddRecordCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private HttpClient _httpClient { get; set; }
        private string url = @"https://localhost:44379/api/";
        string urlRequest = "";
        HttpResponseMessage response = new HttpResponseMessage();
        bool result;

        CheckInputFieldsRecord checkInputFieldsRecord = new CheckInputFieldsRecord();

        public bool CanExecute(object parameter)
        {
            if (parameter == null)
            {
                return false;
            }
            return checkInputFieldsRecord.CheckFields(App.ActionsWithRecordView, parameter);
        }

        public async void Execute(object parameter)
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

            urlRequest = $"{url}" + "CreateRecord/CreateRecord/" + $"{record}";
            using (response = await _httpClient.PostAsJsonAsync(urlRequest, record))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<bool>(apiResponse);
            }

            if (!result)
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
}
