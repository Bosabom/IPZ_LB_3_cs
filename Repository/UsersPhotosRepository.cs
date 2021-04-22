using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IPZ_Proj.Model;
using MySql.Data.MySqlClient;

namespace IPZ_Proj.Repository
{
    class UsersPhotosRepository : IUsersPhotosRepository
    {
        private string SQL_GET_USERS_PHOTOS = "SELECT * FROM users_photos";
        public List<UsersPhotos> GetUsersPhotos(MySqlConnection connection)
        {
            MySqlCommand command = new MySqlCommand(SQL_GET_USERS_PHOTOS, connection);
            List<UsersPhotos> usersPhotos = new List<UsersPhotos>();

            using (MySqlDataReader mySqlDataReader = command.ExecuteReader())
            {
                while (mySqlDataReader.Read())
                {
                    UsersPhotos photo = new UsersPhotos();

                    photo.FidCar = mySqlDataReader.GetInt32(0);
                    photo.PachPoto = mySqlDataReader.GetString(1);
                    photo.Id = mySqlDataReader.GetInt32(2);
                    
                    usersPhotos.Add(photo);
                }
            }

            return usersPhotos;
        }
    }
}
