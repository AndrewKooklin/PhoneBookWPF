using System;
using System.Windows;
using System.Windows.Input;
using PhoneBookWPF.HelpMethods;
using System.Net.Http;

namespace PhoneBookWPF.Commands
{
    public class LogOutCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        MyHttpClient MyHttp = new MyHttpClient();
        private string url = @"https://localhost:44379/api/";
        string urlRequest = "";

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public async void Execute(object parameter)
        {
            var bookWindow = App.PhoneBookWindow;

            bookWindow.miAddRecord.Visibility = Visibility.Collapsed;
            bookWindow.miChangeRecord.Visibility = Visibility.Collapsed;
            bookWindow.miDeleteRecord.Visibility = Visibility.Collapsed;
            bookWindow.miUsers.Visibility = Visibility.Collapsed;
            bookWindow.miRoles.Visibility = Visibility.Collapsed;
            bookWindow.miRegister.Visibility = Visibility.Visible;
            bookWindow.miLogIn.Visibility = Visibility.Visible;
            bookWindow.miUserName.Visibility = Visibility.Collapsed;
            bookWindow.miLogOut.Visibility = Visibility.Collapsed;

            App.ActionsWithRecordView.bAddRecord.Visibility = Visibility.Collapsed;
            App.ActionsWithRecordView.bChangeRecord.Visibility = Visibility.Collapsed;
            App.ActionsWithRecordView.bDeleteRecord.Visibility = Visibility.Collapsed;
            App.ActionsWithRecordView.bClearForm.Visibility = Visibility.Collapsed;

            bookWindow.UpdateDefaultStyle();

            urlRequest = $"{url}" + "Logout/LogoutUser";

            using (var client = MyHttp.GetHttpClient())
            {
                await client.PostAsync(urlRequest, null);
            }
        }
    }
}
