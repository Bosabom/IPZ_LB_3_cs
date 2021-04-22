using System;
using System.Collections.Generic;
using System.Text;

namespace IPZ_Proj.Model
{
    class UsersPhotos
    {
        public int FidCar { get; set; }
        public string PachPoto { get; set; }
        public int Id { get; set; }
        
        public override string ToString()
        {
            return $"FidCar = {FidCar} \n" +
                   $"PachPoto = {PachPoto} \n" +
                   $"Id = {Id}";
        }
    }
}