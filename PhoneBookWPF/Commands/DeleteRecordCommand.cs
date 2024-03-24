using PhoneBookWPF.HelpMethods;
using PhoneBookWPF.View;
using PhoneBookWPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace PhoneBookWPF.Commands
{
    public class DeleteRecordCommand : ICommand
    {
        private PhoneBookWindowViewModel _phoneBookWindowModel;

        public DeleteRecordCommand(PhoneBookWindowViewModel phoneBookWindowModel)
        {
            _phoneBookWindowModel = phoneBookWindowModel;
        }

        public event EventHandler CanExecuteChanged;
        private HttpClient _httpClient { get; set; }
        private string url = @"https://localhost:44379/api/";
        string urlRequest = "";
        HttpResponseMessage response = new HttpResponseMessage();
        bool result;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public async void Execute(object parameter)
        {
            if(parameter != null)
            {
                var fieldElements = (object[])parameter;
                string recordId = fieldElements[0].ToString();
                TextBox tbRecordLastName = (TextBox)fieldElements[1];
                TextBox tbRecordFirstName = (TextBox)fieldElements[2];
                TextBox tbRecordFathersName = (TextBox)fieldElements[3];
                TextBox tbRecordPhoneNumber = (TextBox)fieldElements[4];
                TextBox tbRecordAddress = (TextBox)fieldElements[5];
                TextBox tbRecordDescription = (TextBox)fieldElements[6];

                urlRequest = $"{url}" + "DeleteRecord/DeleteRecord/" + $"{recordId}";
                using (_httpClient = new HttpClient())
                {
                    _httpClient.DefaultRequestHeaders.Accept.Clear();
                    _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    response = await _httpClient.DeleteAsync(urlRequest);
                }
                if (!response.IsSuccessStatusCode)
                {
                    App.ActionsWithRecordView.tbResult.Text = "Ошибка, проверьте работу" +
                                                              "\nAPI сервера!";
                    return;
                }
                else
                {
                    tbRecordLastName.Text = "";
                    tbRecordFirstName.Text = "";
                    tbRecordFathersName.Text = "";
                    tbRecordPhoneNumber.Text = "";
                    tbRecordAddress.Text = "";
                    tbRecordDescription.Text = "";

                    //Records records1 = new Records();
                    //var window = App.Current.Windows.OfType<PhoneBookWindow>().SingleOrDefault(w => w.IsActive);

                    //var records = (RecordsView)window.ccLeftPartPage;

                    //records.lbPhoneBookRecords.ItemsSource = null;
                    //records.lbPhoneBookRecords.ItemsSource = records1.GetRecords().GetAwaiter().GetResult();

                    App.ActionsWithRecordView.tbResult.Text = "Запись удалена!";
                }
            }
        }
    }
}
