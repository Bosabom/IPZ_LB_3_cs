using System;
using System.Collections.Generic;
using System.Text;
using IPZ_Proj.DataBase;
using IPZ_Proj.Model;
using IPZ_Proj.Repository;
using MySql.Data.MySqlClient;

namespace IPZ_Proj.Service
{
    class CarOwnerService : ICarOwnerService
    {
        private ConnectionFactory connectionFactory = new ConnectionFactory();
        ICarOwnerRepository carOwnerRepository = new CarOwnerRepository();
        public List<CarOwner> GetCarOwners()
        {
            MySqlConnection connection = connectionFactory.ConnectionCar;
            try
            {
                return carOwnerRepository.GetCarOwners(connection);
            }
            catch (Exception e)
            {
                connection.CancelQuery(100);
                throw e;
            }
        }
    }
}
