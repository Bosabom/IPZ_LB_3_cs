using System;
using System.Collections.Generic;
using System.Text;
using IPZ_Proj.Model;
using MySql.Data.MySqlClient;

namespace IPZ_Proj.Repository
{
    class OrderRepository : IOrderRepository
    {
        private string SQL_GET_ORDERS = "SELECT * FROM orders";

        public List<Order> GetOrders(MySqlConnection connection)
        {

            MySqlCommand command = new MySqlCommand(SQL_GET_ORDERS, connection);
            List<Order> orders = new List<Order>();

            using (MySqlDataReader mySqlDataReader = command.ExecuteReader())
            {
                while (mySqlDataReader.Read())
                {
                    Order order = new Order();

                    order.Id = mySqlDataReader.GetInt32(0);
                    order.UserId = mySqlDataReader.GetInt32(1);
                    order.CarId = mySqlDataReader.GetInt32(2);

                    orders.Add(order);
                }
            }

            return orders;
        }
    }
}
