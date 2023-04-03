using SmartDishes.Repositories;
using SmartDishes.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using SmartDishes.Models;
using System.Data.SqlClient;


namespace SmartDishes.ViewModels
{
    public class RegisterViewModel : ViewModelBase
    {
        //Fields
        private string _name;
        private string _email;
        private string _login;
        private string _password;
        private string _confirmPassword;

        private string _errorMessage;

        public bool _isViewVisible = true;

        //Properties
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged(Name);
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                OnPropertyChanged(Email);
            }
        }

        public string Login
        {
            get
            {
                return _login;
            }
            set
            {
                _login = value;
                OnPropertyChanged(Login);
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                OnPropertyChanged(Password);
            }
        }

        public string ConfirmPassword
        {
            get
            {
                return _confirmPassword;
            }
            set
            {
                _confirmPassword = value;
                OnPropertyChanged(ConfirmPassword);
            }
        }

        public string ErrorMessage
        {
            get
            {
                return _errorMessage;
            }
            set
            {
                _errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
            }
        }

        public bool IsViewVisible
        {
            get
            {
                return _isViewVisible;
            }
            set
            {
                _isViewVisible = value;
                OnPropertyChanged(nameof(IsViewVisible));
            }
        }

        //Commands
        public ICommand RegisterCommand { get; }

        public MessageViewModel ErrorMessageViewModel { get; }

        public RegisterViewModel()
        {
            ErrorMessageViewModel = new MessageViewModel();
            RegisterCommand = new ViewModelCommand(ExecuteLoginCommand, CanExecuteCommand);
        }

        private bool CanExecuteCommand(object obj)
        {
            bool validData;
            if (string.IsNullOrWhiteSpace(Name) || Name.Length < 3 ||
                    string.IsNullOrWhiteSpace(Login) || Login.Length < 3 ||
                    Password == null || Password.Length < 6 ||
                    Password != ConfirmPassword)
                validData = false;
            else
                validData = true;
            return validData;
        }

        private void ExecuteLoginCommand(object obj)
        {
       
        }
    }
}