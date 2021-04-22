using System;
using System.Collections.Generic;
using System.Text;

namespace IPZ_Proj.Model
{
    class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CarId { get; set; }

        public override string ToString()
        {
            return $"Id = {Id} \n" +
                   $"UserId = {UserId} \n" +
                   $"CarId = {CarId}";
        }
    }
}
