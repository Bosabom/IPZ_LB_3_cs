using IPZ_Proj.Model;
using System;
using System.Collections.Generic;
using System.Text;
using IPZ_Proj.DataBase;
using IPZ_Proj.Repository;
using MySql.Data.MySqlClient;

namespace IPZ_Proj.Service
{
    class OrderService : IOrderService
    {
        private ConnectionFactory connectionFactory = new ConnectionFactory();
        IOrderRepository orderRepository = new OrderRepository();
        public List<Order> GetOrders()
        {
            MySqlConnection connection = connectionFactory.ConnectionUsers;
            try
            {
                return orderRepository.GetOrders(connection);
            }
            catch (Exception e)
            {
                connection.CancelQuery(100);
                throw e;
            }
        }
    }
}
