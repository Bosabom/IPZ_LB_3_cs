using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IPZ_Proj.Model;
using MySql.Data.MySqlClient;

namespace IPZ_Proj.Repository
{
    class UsersCarRepository : IUsersCarRepository
    {
        private string SQL_GET_USERS_CARS = "SELECT * FROM users_car";
        public List<UsersCar> GetUsersCars(MySqlConnection connection)
        {
            MySqlCommand command = new MySqlCommand(SQL_GET_USERS_CARS, connection);
            List<UsersCar> usersCars = new List<UsersCar>();

            using (MySqlDataReader mySqlDataReader = command.ExecuteReader())
            {
                while (mySqlDataReader.Read())
                {
                    UsersCar usersCar = new UsersCar();

                    usersCar.IdCar = mySqlDataReader.GetInt32(0);
                    usersCar.Brand = mySqlDataReader.GetString(1);
                    usersCar.Price = mySqlDataReader.GetInt32(2);
                    usersCar.HP = mySqlDataReader.GetInt32(3);
                    usersCar.Volume = mySqlDataReader.GetInt32(4);
                    usersCar.Fuel = mySqlDataReader.GetString(5);
                    usersCar.Distance = mySqlDataReader.GetInt32(6);
                    usersCar.Condition = mySqlDataReader.GetString(7);
                    usersCar.Description = mySqlDataReader.GetString(8);
                    usersCar.Model = mySqlDataReader.GetString(9);
                    usersCar.Year = mySqlDataReader.GetInt32(10);

                    usersCars.Add(usersCar);
                }
            }

            return usersCars;
        }
    }
}
