using Newtonsoft.Json;
using PhoneBookWPF.HelpMethods;
using PhoneBookWPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PhoneBookWPF.Commands
{
    public class DeleteUserCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private HttpClient _httpClient { get; set; }
        private string url = @"https://localhost:44379/api/";
        private string urlRequest = "";
        private HttpResponseMessage response = new HttpResponseMessage();
        private bool apiResponseConvert;
        private Users users = new Users();
        private CheckInputFields checkInputFields = new CheckInputFields();

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public async void Execute(object parameter)
        {
            if (parameter == null)
            {
                return;
            }
            var checkInput = checkInputFields.CheckFieldsDeleteUser(App.ActionDeleteUserView, parameter);
            if (!checkInput)
            {
                return;
            }
            else
            {
                var fieldElements = (object[])parameter;
                string userId = fieldElements[0].ToString();

                urlRequest = $"{url}" + "UsersAPI/DeleteUser/" + $"{userId}";
                using (_httpClient = new HttpClient())
                {
                    _httpClient.DefaultRequestHeaders.Accept.Clear();
                    _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    using (response = await _httpClient.PostAsJsonAsync(urlRequest, userId))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        apiResponseConvert = JsonConvert.DeserializeObject<bool>(apiResponse);
                    }
                }

                if (!apiResponseConvert)
                {
                    App.ActionDeleteUserView.tbResult.Text = "Пользователя не существует!";
                    return;
                }
                else
                {
                    App.UsersView.lbUsers.ItemsSource = null;
                    App.UsersView.lbUsers.ItemsSource = users.GetUsers().GetAwaiter().GetResult();
                    App.ActionDeleteUserView.tbErrorEmail.Text = "";
                    App.ActionDeleteUserView.tbEmail.Text = "";
                    App.ActionDeleteUserView.tbResult.Text = "Пользователь удален!";
                }
            }
        }
    }
}
