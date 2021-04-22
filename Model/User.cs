using System;
using System.Collections.Generic;
using System.Text;

namespace IPZ_Proj.Model
{
    class User
    {
        public int Id { get; set; }
        public string Mail { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Hash { get; set; }
        public int IP { get; set; }
        public int Number { get; set; }
        public string Role { get; set; }

        public override string ToString()
        {
            return $"Id = {Id} \n" +
                   $"Mail = {Mail} \n" +
                   $"Login = {Login} \n" +
                   $"Password = {Password} \n" +
                   $"Hash = {Hash} \n" +
                   $"IP = {IP} \n" +
                   $"Number = {Number} \n" +
                   $"Role = {Role}";
        }
    }
}
