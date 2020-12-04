using BusinessGameTW.Contarcts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessGameTW.Services
{
    class HotelService : ISquareService
    {
        public void UpdateSquare(ref Player player, Square square)
        {
            Hotel hotel = (Hotel)square.SquareType;
           if(hotel.Owned && hotel.Owner !=player)
            {
                hotel.Owner.Balance += 50;
                player.Balance -= 50;
               
            }
            else
            {
                player.Balance -= 200;
                hotel.Owner = player;
                hotel.Owned = true;
            }
          
        }
    }
}
