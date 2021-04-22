using IPZ_Proj.Model;
using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace IPZ_Proj.Repository
{
    class AuctionLotRepository : IAuctionLotRepository
    {
        private string SQL_GET_LOTS = "SELECT * FROM auction_lot";

        public List<AuctionLot> GetLots(MySqlConnection connection)
        {

            MySqlCommand command = new MySqlCommand(SQL_GET_LOTS, connection);
            List<AuctionLot> lots = new List<AuctionLot>();

            using (MySqlDataReader mySqlDataReader = command.ExecuteReader())
            {
                while (mySqlDataReader.Read())
                {
                    AuctionLot lot = new AuctionLot();

                    lot.Id = mySqlDataReader.GetInt32(0);
                    lot.Fid = mySqlDataReader.GetInt32(1);
                    lot.TimeEnd = mySqlDataReader.GetInt32(2);
                    lot.TopPrice = mySqlDataReader.GetInt32(3);
                    lot.CurrentPrice = mySqlDataReader.GetInt32(4);
                    lot.MinBet = mySqlDataReader.GetInt32(5);

                    lots.Add(lot);
                }
            }

            return lots;
        }
    }
}
