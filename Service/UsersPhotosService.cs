using IPZ_Proj.Model;
using System;
using System.Collections.Generic;
using System.Text;
using IPZ_Proj.DataBase;
using IPZ_Proj.Repository;
using MySql.Data.MySqlClient;

namespace IPZ_Proj.Service
{
    class UsersPhotosService : IUsersPhotosService
    {
        private ConnectionFactory connectionFactory = new ConnectionFactory();
        IUsersPhotosRepository usersPhotosRepository = new UsersPhotosRepository();
        public List<UsersPhotos> GetUsersPhotos()
        {
            MySqlConnection connection = connectionFactory.ConnectionCar;
            try
            {
                return usersPhotosRepository.GetUsersPhotos(connection);
            }
            catch (Exception e)
            {
                connection.CancelQuery(100);
                throw e;
            }
        }
    }
}
