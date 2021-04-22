using System;
using System.Collections.Generic;
using System.Text;
using IPZ_Proj.Model;
using MySql.Data.MySqlClient;

namespace IPZ_Proj.Repository
{
    class UserRepository : IUserRepository
    {
        private string SQL_GET_USERS = "SELECT * FROM users";

        public List<User> GetUsers(MySqlConnection connection)
        {
            MySqlCommand command = new MySqlCommand(SQL_GET_USERS, connection);
            List<User> users = new List<User>();

            using (MySqlDataReader mySqlDataReader = command.ExecuteReader())
            {
                while (mySqlDataReader.Read())
                {
                    User user = new User();

                    user.Id = mySqlDataReader.GetInt32(0);
                    user.Mail = mySqlDataReader.GetString(1);
                    user.Login = mySqlDataReader.GetString(2);
                    user.Password = mySqlDataReader.GetString(3);
                    user.Hash = mySqlDataReader.GetString(4);
                    user.IP = mySqlDataReader.GetInt32(5);
                    user.Number = mySqlDataReader.GetInt32(6);
                    user.Role = mySqlDataReader.GetString(7);

                    users.Add(user);
                }
            }

            return users;
        }
    }
}
