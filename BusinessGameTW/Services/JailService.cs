using BusinessGameTW.Contarcts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessGameTW.Services
{
    class JailService : ISquareService
    {
        public void UpdateSquare(ref Player player, Square square)
        {
            player.Balance -= 150;
        }
    }
}
