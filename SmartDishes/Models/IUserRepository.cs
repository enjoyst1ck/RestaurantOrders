using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SmartDishes.Models
{
    public interface IUserRepository
    {
        bool AuthenticateUser(NetworkCredential credentiel);
        void Add(UserModel userModel);
        void Edit(UserModel userModel);
        void Remove(int id);

        UserModel GetById(int id);
        UserModel GetByLogin(string Login);
        IEnumerable<UserModel> GetByAll();

    }
}
