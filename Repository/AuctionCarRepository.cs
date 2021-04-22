using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IPZ_Proj.Model;
using MySql.Data.MySqlClient;

namespace IPZ_Proj.Repository
{
    class AuctionCarRepository : IAuctionCarRepository
    {
        private string SQL_GET_CARS = "SELECT * FROM auction_car";
        public List<AuctionCar> GetCars(MySqlConnection connection)
        {
            MySqlCommand command = new MySqlCommand(SQL_GET_CARS, connection);
            List<AuctionCar> cars = new List<AuctionCar>();

            using (MySqlDataReader mySqlDataReader = command.ExecuteReader())
            {
                while (mySqlDataReader.Read())
                {
                    AuctionCar car = new AuctionCar();

                    car.Id = mySqlDataReader.GetInt32(0);
                    car.Brand = mySqlDataReader.GetString(1);
                    car.Price = mySqlDataReader.GetInt32(2);
                    car.HP = mySqlDataReader.GetInt32(3);
                    car.Volume = mySqlDataReader.GetInt32(4);
                    car.Fuel = mySqlDataReader.GetString(5);
                    car.Distance = mySqlDataReader.GetInt32(6);
                    car.Condition = mySqlDataReader.GetString(7);
                    car.Description = mySqlDataReader.GetString(8);
                    car.Model = mySqlDataReader.GetString(9);
                    car.Year = mySqlDataReader.GetInt32(10);

                    cars.Add(car);
                }
            }

            return cars;
        }
    }
}
