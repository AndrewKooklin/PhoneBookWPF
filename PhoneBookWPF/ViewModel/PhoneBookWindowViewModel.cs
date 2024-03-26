﻿using Microsoft.AspNet.Identity.EntityFramework;
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
        Records records = new Records();
        Roles roles = new Roles();
        Users users = new Users();

        public PhoneBookWindowViewModel()
        {
            ReadRecordsCommand = new ReadRecordsCommand(this);
            UpdateViewCommand = new UpdateViewCommand(this);
            PhoneBooks = new List<PhoneBookRecord>();
            Roles = new List<IdentityRole>();
            PhoneBooks = records.GetRecords().GetAwaiter().GetResult();
            Roles = roles.GetRoles().GetAwaiter().GetResult();
            Users = users.GetUsers().GetAwaiter().GetResult();
            RightCurrentView = new UserControl();
            OpenRegisterWindowCommand = new OpenRegisterWindowCommand();
            OpenLogInWindowCommand = new OpenLogInWindowCommand();
            LogOutCommand = new LogOutCommand();
            AddRecordCommand = new AddRecordCommand();
            DeleteRecordCommand = new DeleteRecordCommand(this);
            ChangeRecordCommand = new ChangeRecordCommand();
            ClearTextCommand = new ClearTextCommand();
            AddRoleCommand = new AddRoleCommand();
            DeleteRoleCommand = new DeleteRoleCommand();
            AddUserCommand = new AddUserCommand();
            DeleteUserCommand = new DeleteUserCommand();
        }

        public ICommand UpdateViewCommand { get; set; }

        public ICommand OpenRegisterWindowCommand { get; set; }

        public ICommand OpenLogInWindowCommand { get; set; }

        public ICommand LogOutCommand { get; set; }

        public ICommand ReadRecordsCommand { get; set; }

        public ICommand AddRecordCommand { get; set; }

        public ICommand DeleteRecordCommand { get; set; }

        public ICommand ChangeRecordCommand { get; set; }

        public ICommand ClearTextCommand { get; set; }

        public ICommand AddRoleCommand { get; set; }

        public ICommand DeleteRoleCommand { get; set; }

        public ICommand AddUserCommand { get; set; }

        public ICommand DeleteUserCommand { get; set; }


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

        private List<IdentityRole> _roles;

        public List<IdentityRole> Roles
        {
            get
            {
                return _roles;
            }
            set
            {
                _roles = value;
                OnPropertyChanged(nameof(Roles));
            }
        }

        private List<IdentityUser> _users;

        public List<IdentityUser> Users
        {
            get
            {
                return _users;
            }
            set
            {
                _users = value;
                OnPropertyChanged(nameof(Users));
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

                    App.ActionsWithRecordView.tbResult.Text = "";
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

        private IdentityRole _selectedRole;

        public IdentityRole SelectedRole
        {
            get
            {
                if (_selectedRole == null)
                {
                    return null;
                }
                else
                {
                    App.ActionsWithRoleView.tbRoleId.Text = _selectedRole.Id;
                    App.ActionsWithRoleView.tbRoleName.Text = _selectedRole.Name;
                    App.ActionsWithRecordView.tbResult.Text = "";
                }

                return _selectedRole;
            }
            set
            {
                _selectedRole = value;
                OnPropertyChanged(nameof(SelectedRole));
            }
        }

        private IdentityUser _selectedUser;

        public IdentityUser SelectedUser
        {
            get
            {
                if (_selectedUser == null)
                {
                    return null;
                }
                else
                {
                    App.ActionDeleteUserView.tbUserId.Text = _selectedUser.Id;
                    App.ActionDeleteUserView.tbEmail.Text = _selectedUser.Email;
                    App.ActionsWithRecordView.tbResult.Text = "";
                }

                return _selectedUser;
            }
            set
            {
                _selectedUser = value;
                OnPropertyChanged(nameof(SelectedUser));
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

