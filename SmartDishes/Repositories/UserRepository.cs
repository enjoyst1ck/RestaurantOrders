using SmartDishes.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SmartDishes.Repositories
{
    public class UserRepository : RepositoryBase, IUserRepository
    {
        public void Add(UserModel userModel)
        {
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO users VALUES (NEWID(), '@login' , '@password', '@name' , '@email')\r\n";

                command.Parameters.AddWithValue("@Name", userModel.Name);
                command.Parameters.AddWithValue("@login", userModel.Login); 
                command.Parameters.AddWithValue("@password", userModel.Password);
                command.Parameters.AddWithValue("@email", userModel.Email);
            }
        }

        public bool AuthenticateUser(NetworkCredential credentiel)
        {
            bool validUser;
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {

                connection.Open();
                command.Connection = connection;
                command.CommandText = "select *from [users] where Login=@login and [password]=@password";
                command.Parameters.Add("@login", System.Data.SqlDbType.NVarChar).Value = credentiel.UserName;
                command.Parameters.Add("@password", System.Data.SqlDbType.NVarChar).Value = credentiel.Password;
                
                validUser = command.ExecuteScalar() == null ? false : true;
            }

            return validUser;
        }

        public void Edit(UserModel userModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserModel> GetByAll()
        {
            throw new NotImplementedException();
        }

        public UserModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public UserModel GetByLogin(string login)
        {
            UserModel user = null;
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {

                connection.Open();
                command.Connection = connection;
                command.CommandText = "select *from [users] where Login=@login";
                command.Parameters.Add("@login", System.Data.SqlDbType.NVarChar).Value = login;
                using (var reader = command.ExecuteReader())
                {
                    if(reader.Read())
                    {
                        user = new UserModel()
                        {
                            UserId = (int)reader[0],
                            Login = reader[1].ToString(),
                            Password = string.Empty,
                            Name = reader[3].ToString(),
                            Email = reader[4].ToString(),
                        };
                    }
                }
            }
            return user;
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
