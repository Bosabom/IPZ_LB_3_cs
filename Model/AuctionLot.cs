using System;
using System.Collections.Generic;
using System.Text;

namespace IPZ_Proj.Model
{
    class AuctionLot
    {
        public int Id { get; set; }
        public int Fid { get; set; }
        public int TimeEnd { get; set; }
        public int TopPrice { get; set; }
        public int CurrentPrice { get; set; }
        public int MinBet { get; set; }

        public override string ToString()
        {
            return $"Id = {Id} \n" +
                   $"Fid = {Fid} \n" +
                   $"TimeEnd = {TimeEnd} \n" +
                   $"TopPrice = {TopPrice} \n" +
                   $"CurrentPrice = {CurrentPrice} \n" +
                   $"MinBet = {MinBet}";
        }
    }
}
