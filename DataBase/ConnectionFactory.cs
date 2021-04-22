using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using MySql.Data.MySqlClient;

namespace IPZ_Proj.DataBase
{
    class ConnectionFactory
    {
        public MySqlConnection ConnectionCar { get; }
        public MySqlConnection ConnectionUsers { get; }

        public ConnectionFactory()
        {
            string connStringCar = @"user=root;" +
                                "password=root;" +
                                "server=127.0.0.1;" +
                                "database=car";
            ConnectionCar = new MySqlConnection(connStringCar);
            try
            {
                ConnectionCar.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            string connStringUsers = @"user=root;" +
                                "password=root;" +
                                "server=127.0.0.1;" +
                                "database=users";
            ConnectionUsers = new MySqlConnection(connStringUsers);
            try
            {
                ConnectionUsers.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
