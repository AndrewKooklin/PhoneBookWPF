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
using System.Windows.Media;

namespace PhoneBookWPF.Commands
{
    public class GetRecordCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        Records records = new Records();

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

            var values = (object[])parameter;
            var lbItems = (ListBox)values[0];
            var errorLabel = (Label)values[1];
            var spDetailsContent = (StackPanel)values[2];
            var spDetailsChildren = spDetailsContent.Children;

            if (lbItems.SelectedIndex == -1 || lbItems.SelectedItem == null)
            {
                errorLabel.Content = "Ошибка : Выберите запись !";
                return;
            }
            else
            {
                errorLabel.Content = "";
            }
            var selectedItem = (PhoneBookRecord)lbItems.SelectedItem;
            var recordId = selectedItem.Id;
            var record = records.GetRecord(recordId);

            var tbIdContent = (TextBlock)spDetailsChildren[0];
            var tbLastNameContent = (TextBlock)spDetailsChildren[1];
            var tbFirstNameContent = (TextBlock)spDetailsChildren[2];
            var tbFathersNameContent = (TextBlock)spDetailsChildren[3];
            var tbPhoneNumberContent = (TextBlock)spDetailsChildren[4];
            var tbAddressContent = (TextBlock)spDetailsChildren[5];
            var tbDescriptionContent = (TextBlock)spDetailsChildren[6];
            tbIdContent.Background = new SolidColorBrush(Colors.AliceBlue);
            tbIdContent.Text = record.Id.ToString();
            tbLastNameContent.Background = new SolidColorBrush(Colors.AliceBlue);
            tbLastNameContent.Text = record.LastName;
            tbFirstNameContent.Background = new SolidColorBrush(Colors.AliceBlue);
            tbFirstNameContent.Text = record.FirstName;
            tbFathersNameContent.Background = new SolidColorBrush(Colors.AliceBlue);
            tbFathersNameContent.Text = record.FathersName;
            tbPhoneNumberContent.Background = new SolidColorBrush(Colors.AliceBlue);
            tbPhoneNumberContent.Text = record.PhoneNumber;
            tbAddressContent.Background = new SolidColorBrush(Colors.AliceBlue);
            tbAddressContent.Text = record.Address;
            tbDescriptionContent.Background = new SolidColorBrush(Colors.AliceBlue);
            tbDescriptionContent.Text = record.Address;

        }
    }
}
