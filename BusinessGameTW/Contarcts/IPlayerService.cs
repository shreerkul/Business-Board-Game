using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessGameTW.Contarcts
{
    interface IPlayerService
    {
        List<Player> Players { get; set; }
        List<Player> LoadPlayers(Square start);
        Square MovePlayer(Player player, Square square, int count);
    }
}
