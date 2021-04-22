using System;
using System.Collections.Generic;
using System.Text;

namespace IPZ_Proj.Model
{
    class AuctionCar
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public int Price { get; set; }
        public int HP { get; set; }
        public int Volume { get; set; }
        public string Fuel { get; set; }
        public int Distance { get; set; }
        public string Condition { get; set; }
        public string Description { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return $"Id = {Id} \n" +
                   $"Brand = {Brand} \n" +
                   $"Price = {Price} \n" +
                   $"HP = {HP} \n" +
                   $"Volume = {Volume} \n" +
                   $"Fuel = {Fuel} \n" +
                   $"Distance = {Distance} \n" +
                   $"Condition = {Condition} \n" +
                   $"Description = {Description} \n" +
                   $"Model = {Model} \n" +
                   $"Year = {Year}";
        }
    }
}