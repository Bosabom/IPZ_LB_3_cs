using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IPZ_Proj.Model;
using MySql.Data.MySqlClient;

namespace IPZ_Proj.Repository
{
    class CarOwnerRepository : ICarOwnerRepository
    {
        private string SQL_GET_CAR_OWNER = "SELECT * FROM car_owner";
        public List<CarOwner> GetCarOwners(MySqlConnection connection)
        {
            MySqlCommand command = new MySqlCommand(SQL_GET_CAR_OWNER, connection);
            List<CarOwner> carOwners = new List<CarOwner>();

            using (MySqlDataReader mySqlDataReader = command.ExecuteReader())
            {
                while (mySqlDataReader.Read())
                {
                    CarOwner carOwner = new CarOwner();

                    carOwner.UserId = mySqlDataReader.GetInt32(0);
                    carOwner.FkUsersCarId = mySqlDataReader.GetInt32(1);
                    carOwner.Id = mySqlDataReader.GetInt32(2);
                    

                    carOwners.Add(carOwner);
                }
            }

            return carOwners;
        }
    }
}
