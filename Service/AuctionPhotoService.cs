using System;
using System.Collections.Generic;
using System.Text;
using IPZ_Proj.DataBase;
using IPZ_Proj.Model;
using IPZ_Proj.Repository;
using MySql.Data.MySqlClient;

namespace IPZ_Proj.Service
{
    class AuctionPhotoService : IAuctionPhotoService
    {
        private ConnectionFactory connectionFactory = new ConnectionFactory();
        IAuctionPhotoRepository auctionPhotoRepository = new AuctionPhotoRepository();
        public List<AuctionPhoto> GetPhotos()
        {
            MySqlConnection connection = connectionFactory.ConnectionCar;
            try
            {
                return auctionPhotoRepository.GetPhotos(connection);
            }
            catch (Exception e)
            {
                connection.CancelQuery(100);
                throw e;
            }
        }
    }
}
