using System;
using System.Collections.Generic;
using System.Text;
using IPZ_Proj.Model;
using MySql.Data.MySqlClient;

namespace IPZ_Proj.Repository
{
    class AuctionPhotoRepository : IAuctionPhotoRepository
    {
        private string SQL_GET_PHOTOS = "SELECT * FROM auction_photos";
        public List<AuctionPhoto> GetPhotos(MySqlConnection connection)
        {
            MySqlCommand command = new MySqlCommand(SQL_GET_PHOTOS, connection);
            List<AuctionPhoto> photos = new List<AuctionPhoto>();

            using (MySqlDataReader mySqlDataReader = command.ExecuteReader())
            {
                while (mySqlDataReader.Read())
                {
                    AuctionPhoto photo = new AuctionPhoto();

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
