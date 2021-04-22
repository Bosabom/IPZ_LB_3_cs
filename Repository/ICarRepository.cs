﻿using System;
using System.Collections.Generic;
using System.Text;
using IPZ_Proj.Model;
using MySql.Data.MySqlClient;

namespace IPZ_Proj.Repository
{
    interface ICarRepository
    {
        List<Car> GetCars(MySqlConnection connection);
    }
}
