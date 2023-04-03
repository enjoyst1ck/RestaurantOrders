using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Security.Principal;
using SmartDishes.Repositories;
using SmartDishes.Models;
using System.Net;
using System.Windows;
using SmartDishes.Views;

namespace SmartDishes.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        //Fields
        private string _login;
        private SecureString _password;
        private string _errorMessage;
        private bool _isViewVisible = true;
         
        private IUserRepository userRepository;

        //Properties
        public string Login
        {
            get
            {
                return _login;
            }
            set
            {
                _login = value;
                OnPropertyChanged(nameof(Login));
            }
        }

        public SecureString Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
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
        public ICommand LoginCommand { get; }

        //Constructor
        public LoginViewModel()
        {
            userRepository = new UserRepository();
            LoginCommand = new ViewModelCommand(ExecuteLoginCommand, CanExecuteCommand);
        }

        private bool CanExecuteCommand(object obj)
        {
            bool validData;
            if (string.IsNullOrWhiteSpace(Login) || Login.Length < 3 || Password == null || Password.Length < 6)
                validData = false;
            else
                validData = true;
            return validData;
        }

        private void ExecuteLoginCommand(object obj)
        {
            var isValidUser = userRepository.AuthenticateUser(new NetworkCredential(Login, Password));
            if(isValidUser)
            {
                Thread.CurrentPrincipal = new GenericPrincipal(
                new GenericIdentity(Login), null);

                if (Login == "admin")
                {
                    var adminView = new AdminView();
                    adminView.Show();
                    IsViewVisible = false;
                }
                else
                {
                    var loggedView = new LoggedView();
                    loggedView.Show();
                    IsViewVisible = false;
                }
            }
            else
            {
                ErrorMessage = "Nieprawidłowa nazwa użytkownika lub hasło";
            }
        }
    }
}
