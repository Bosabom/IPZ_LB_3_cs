using System;
using System.Collections.Generic;
using System.Text;
using IPZ_Proj.DataBase;
using IPZ_Proj.Model;
using IPZ_Proj.Repository;
using MySql.Data.MySqlClient;

namespace IPZ_Proj.Service
{
    class CarService : ICarService
    {
        private ConnectionFactory connectionFactory = new ConnectionFactory();
        ICarRepository carRepository = new CarRepository();
        public List<Car> GetCars()
        {
            MySqlConnection connection = connectionFactory.ConnectionCar;
            try
            {
                return carRepository.GetCars(connection);
            }
            catch (Exception e)
            {
                connection.CancelQuery(100);
                throw e;
            }
        }
    }
}
