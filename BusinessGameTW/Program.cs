using BusinessGameTW.Services;
using System;

namespace BusinessGameTW
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(new PlayerService());
            board.InitiateGame();
            board.Play();
        }
    }
}
