using PhoneBookWPF.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookWPF.HelpMethods
{
    public class CheckInputFields
    {
        public bool CheckFieldsRecord(ActionsWithRecordView recordView, object fields)
        {
            var fieldElements = (object[])fields;
            string recordId = fieldElements[0].ToString();
            string recordLastName = fieldElements[1].ToString();
            string recordFirstName = fieldElements[2].ToString();
            string recordFathersName = fieldElements[3].ToString();
            string recordPhoneNumber = fieldElements[4].ToString();
            string recordAddress = fieldElements[5].ToString();
            string recordDescription = fieldElements[6].ToString();

            //if (!String.IsNullOrEmpty(recordId))
            //{
            //    recordView.tbRecordId.Text = "";
            //    return false;
            //}

            if (String.IsNullOrEmpty(recordLastName))
            {
                recordView.tbErrorLastName.Text = "Заполните поле \"Фамилия\"";
                return false;
            }
            else if (!String.IsNullOrEmpty(recordLastName) && recordLastName.Length < 3)
            {
                recordView.tbErrorLastName.Text = "Длина не менее 3 символов";
                return false;
            }
            else
            {
                recordView.tbErrorLastName.Text = "";
            }
            if (String.IsNullOrEmpty(recordFirstName))
            {
                recordView.tbErrorLastName.Text = "Заполните поле \"Имя\"";
                return false;
            }
            else if (!String.IsNullOrEmpty(recordFirstName) && recordFirstName.Length < 3)
            {
                recordView.tbErrorFirstName.Text = "Длина не менее 3 символов";
                return false;
            }
            else
            {
                recordView.tbErrorFirstName.Text = "";
            }
            if (String.IsNullOrEmpty(recordFathersName))
            {
                recordView.tbErrorLastName.Text = "Заполните поле \"Отчество\"";
                return false;
            }
            else if (!String.IsNullOrEmpty(recordFathersName) && recordFathersName.Length < 3)
            {
                recordView.tbErrorFathersName.Text = "Длина не менее 3 символов";
                return false;
            }
            else
            {
                recordView.tbErrorFathersName.Text = "";
            }
            if (String.IsNullOrEmpty(recordPhoneNumber))
            {
                recordView.tbErrorLastName.Text = "Заполните поле \"Телефон\"";
                return false;
            }
            else if (!String.IsNullOrEmpty(recordPhoneNumber) && recordPhoneNumber.Length < 11)
            {
                recordView.tbErrorPhoneNumber.Text = "Длина не менее 11 символов";
                return false;
            }
            else
            {
                recordView.tbErrorLastName.Text = "";
                recordView.tbErrorFirstName.Text = "";
                recordView.tbErrorFathersName.Text = "";
                recordView.tbErrorPhoneNumber.Text = "";
                return true;
            }
        }

        public bool CheckFieldsRole(ActionsWithRoleView roleView, object fields)
        {
            var fieldElements = (object[])fields;
            string roleId = fieldElements[0].ToString();
            string roleName = fieldElements[1].ToString();

            //if (!String.IsNullOrEmpty(roleId))
            //{
            //    roleView.tbRoleName.Text = "";
            //    return false;
            //}

            if (String.IsNullOrEmpty(roleName))
            {
                roleView.tbErrorRoleName.Text = "Заполните поле \"Роль\"";
                return false;
            }
            else if (!String.IsNullOrEmpty(roleName) && roleName.Length < 3)
            {
                roleView.tbErrorRoleName.Text = "Длина не менее 3 символов";
                return false;
            }
            else
            {
                roleView.tbRoleName.Text = "";
                return true;
            }
        }
    }
}
