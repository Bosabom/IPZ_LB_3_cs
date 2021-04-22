using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IPZ_Proj.Model;
using MySql.Data.MySqlClient;

namespace IPZ_Proj.Repository
{
    class PhotosRepository : IPhotosRepository
    {
        private string SQL_GET_PHOTOS = "SELECT * FROM photos";
        public List<Photos> GetPhotos(MySqlConnection connection)
        {
            MySqlCommand command = new MySqlCommand(SQL_GET_PHOTOS, connection);
            List<Photos> photos = new List<Photos>();

            using (MySqlDataReader mySqlDataReader = command.ExecuteReader())
            {
                while (mySqlDataReader.Read())
                {
                    Photos photo = new Photos();

                    photo.FidCar = mySqlDataReader.GetInt32(0);
                    photo.PachPoto = mySqlDataReader.GetString(1);
                    photo.Id = mySqlDataReader.GetInt32(2);
                    
                    photos.Add(photo);
                }
            }

            return photos;
        }
    }
}
