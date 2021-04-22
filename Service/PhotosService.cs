using IPZ_Proj.Model;
using System;
using System.Collections.Generic;
using System.Text;
using IPZ_Proj.DataBase;
using IPZ_Proj.Repository;
using MySql.Data.MySqlClient;

namespace IPZ_Proj.Service
{
    class PhotosService : IPhotosService
    {
        private ConnectionFactory connectionFactory = new ConnectionFactory();
        IPhotosRepository photosRepository = new PhotosRepository();
        public List<Photos> GetPhotos()
        {
            MySqlConnection connection = connectionFactory.ConnectionCar;
            try
            {
                return photosRepository.GetPhotos(connection);
            }
            catch (Exception e)
            {
                connection.CancelQuery(100);
                throw e;
            }
        }
    }
}
