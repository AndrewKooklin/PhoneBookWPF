using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace PhoneBookWPF.Commands
{
    public class ClearTextCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter == null)
            {
                return;
            }
            else
            {
                var fieldElements = (object[])parameter;
                TextBox tbrecordId = (TextBox)fieldElements[0];
                TextBox tbRecordLastName = (TextBox)fieldElements[1];
                TextBox tbRecordFirstName = (TextBox)fieldElements[2];
                TextBox tbRecordFathersName = (TextBox)fieldElements[3];
                TextBox tbRecordPhoneNumber = (TextBox)fieldElements[4];
                TextBox tbRecordAddress = (TextBox)fieldElements[5];
                TextBox tbRecordDescription = (TextBox)fieldElements[6];

                tbrecordId.Text = "";
                tbRecordLastName.Text = "";
                tbRecordFirstName.Text = "";
                tbRecordFathersName.Text = "";
                tbRecordPhoneNumber.Text = "";
                tbRecordAddress.Text = "";
                tbRecordDescription.Text = "";

                App.ActionsWithRecordView.tbResult.Text = "";
            }
        }
    }
}
