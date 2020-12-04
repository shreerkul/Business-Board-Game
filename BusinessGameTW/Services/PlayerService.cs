using BusinessGameTW.Contarcts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessGameTW.Services
{
    class PlayerService : IPlayerService
    {
        public List<Player> Players { get; set; }

        public List<Player> LoadPlayers(Square start)
        {
            List<Player> players = new List<Player>();
            Player player = new Player();
            player.PlayerId = 1;
            player.Name = "ABC";
            player.Balance = 1000;
            player.CurrentSquare = start;
            players.Add(player);

             player = new Player();
            player.PlayerId = 2;
            player.Name = "XYZ";
            player.Balance = 1000;
            player.CurrentSquare = start;
            players.Add(player);

            player = new Player();
            player.PlayerId = 3;
            player.Name = "CDE";
            player.Balance = 1000;
            player.CurrentSquare = start;
            players.Add(player);

            return players;
        }

        public Square MovePlayer(Player player, Square square, int count)
        {
            for (int i = 0; i < count; i++)
            {
                square = square.NextSquare;
            }
            square.CurrentPlayer = player;
            return square;
        }
    }
}
