using IPZ_Proj.Model;
using System;
using System.Collections.Generic;
using System.Text;
using IPZ_Proj.DataBase;
using IPZ_Proj.Repository;
using MySql.Data.MySqlClient;

namespace IPZ_Proj.Service
{
    class UsersCarService : IUsersCarService
    {
        private ConnectionFactory connectionFactory = new ConnectionFactory();
        IUsersCarRepository usersCarRepository = new UsersCarRepository();
        public List<UsersCar> GetUsersCars()
        {
            MySqlConnection connection = connectionFactory.ConnectionCar;
            try
            {
                return usersCarRepository.GetUsersCars(connection);
            }
            catch (Exception e)
            {
                connection.CancelQuery(100);
                throw e;
            }
        }
    }
}
