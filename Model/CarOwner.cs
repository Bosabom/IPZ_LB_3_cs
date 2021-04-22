using System;
using System.Collections.Generic;
using System.Text;

namespace IPZ_Proj.Model
{
    class CarOwner
    {
        public int UserId { get; set; }
        public int FkUsersCarId { get; set; }
        public int Id { get; set; }
        
        public override string ToString()
        {
            return $"UserId = {UserId} \n" +
                   $"FkUsersCarId = {FkUsersCarId} \n" +
                   $"Id = {Id} \n";
        }
    }
}