using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using SmartDishes.Models;
using SmartDishes.Repositories;

namespace SmartDishes.ViewModels
{
    public class LoggedViewModel : ViewModelBase
    {
        //Fields
        private UserAccountModel _currentUserAccount;
        private IUserRepository userRepository;
        private float _allCost;

        public UserAccountModel CurrentUserAccount
        {
            get
            {
                return _currentUserAccount;
            }
            set
            {
                _currentUserAccount = value;
                OnPropertyChanged(nameof(CurrentUserAccount));
            }
        }

        public LoggedViewModel()
        {
            userRepository = new UserRepository();
            CurrentUserAccount = new UserAccountModel();
            LoadCurrentUserData();
        }

        private void LoadCurrentUserData()
        {
            var user = userRepository.GetByLogin(Thread.CurrentPrincipal.Identity.Name);
            if(user!=null)
            {

                CurrentUserAccount.Login = user.Login;
                CurrentUserAccount.DisplayName = $"Welcome {user.Name} !";
            }
            else
            {
                CurrentUserAccount.DisplayName = "Invalid user, not logged in";
            }
        }

        public float AllCost
        {
            get
            {
                return _allCost;
            }
            set
            {
                _allCost = value;
                OnPropertyChanged(nameof(AllCost));
            }
        }
    }
}
