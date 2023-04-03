using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDishes.Models
{
    public class UserModel
    {
        public int UserId {get;set;}
        public string Login {get;set;}
        public string Password {get;set;}
        public string Name {get;set;}
        public string Email {get;set;}
        
        public UserModel()
        {

        }

        public UserModel(string Login, string Password, string Name, string Email)
        {
            this.Login = Login;
            this.Password = Password;
            this.Name = Name;
            this.Email = Email;
        }

        public UserModel(UserModel user)
        {
            this.Login = user.Login;
            this.Password = user.Password;
            this.Name = user.Name;
            this.Email = user.Email;
        }
    }
}
