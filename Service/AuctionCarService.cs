using IPZ_Proj.Model;
using System;
using System.Collections.Generic;
using System.Text;
using IPZ_Proj.DataBase;
using IPZ_Proj.Repository;
using MySql.Data.MySqlClient;

namespace IPZ_Proj.Service
{
    class AuctionCarService : IAuctionCarService
    {
        private ConnectionFactory connectionFactory = new ConnectionFactory();
        IAuctionCarRepository auctionCarRepository = new AuctionCarRepository();
        public List<AuctionCar> GetCars()
        {
            MySqlConnection connection = connectionFactory.ConnectionCar;
            try
            {
                return auctionCarRepository.GetCars(connection);
            }
            catch (Exception e)
            {
                connection.CancelQuery(100);
                throw e;
            }
        }
    }
}
