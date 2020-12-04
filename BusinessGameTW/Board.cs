using BusinessGameTW.Contarcts;
using BusinessGameTW.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessGameTW
{
    class Board
    {
        IPlayerService PlayerService;
        //ISquareService squareService;
        List<Player> Players;
        List<int> Dices;



        public Board(IPlayerService _PlayerService)
        {
            PlayerService = _PlayerService;
        }
        public void InitiateGame()
        {
            RollDiceService roll = new RollDiceService();
            Dices= roll.RollDice();
            List<char> lstPositions = LoadPositions();
            Square start = DesignBoard(lstPositions);
            Players = PlayerService.LoadPlayers(start);
        }

        private List<char> LoadPositions()
        {
            List<char> Positions = new List<char>();
            string pos = "EEJHETJTEEHJTHEEJHETJTEEHJTHJEEJHETJTEEHJTEHE";
            for (int i = 0; i < pos.Length; i++)
            {
                Positions.Add(pos[i]);
            }
            return Positions;
        }

        public void Play()
        {
            Player currentplayer;
            ISquareService service;
            SquareClient client = new SquareClient();
            int count = 0;
            while (count < 10)
            {
                for (int i = 0; i < Players.Count; i++)
                {

                    currentplayer = Players[i];
                    int dice = Dices[count + i];
                    currentplayer.TotalMoves += dice;
                    if(currentplayer.TotalMoves > 40)
                    {
                        currentplayer.TotalMoves = 0;
                        currentplayer.TotalRounds += 1;
                    }
                    currentplayer.CurrentSquare = PlayerService.MovePlayer(currentplayer, currentplayer.CurrentSquare, dice);
                    if (currentplayer.CurrentSquare.SquareType != null)
                    {
                        service = client.GetServiceInstance(currentplayer.CurrentSquare.SquareType.SquareName);
                        if (service != null)
                            service.UpdateSquare(ref currentplayer, currentplayer.CurrentSquare);
                    }

                    
                }
                count++;
            }
            string winner = GetWinner(Players);
            Console.WriteLine("Winner is {0}", winner);
        }
       
        private string GetWinner(List<Player> players)
        {
            if (players[0].Balance > players[1].Balance && players[0].Balance > players[2].Balance)
                return players[0].Name;
            if (players[1].Balance > players[0].Balance && players[1].Balance > players[2].Balance)
                return players[1].Name;

                return players[2].Name;

        }

        public Square DesignBoard(List<char> lstPositions)
        {
            Square square = new Square();
            square.SquareType = new Start();
            Square temp = square;
            for (int i = 0; i < lstPositions.Count; i++)
            {
                Square sq = new Square();
                switch (lstPositions[i])
                {
                    case 'E':
                        sq.SquareType = null;
                        break;
                    case 'J':
                        sq.SquareType = new Jail();
                        break;
                    case 'T':
                        sq.SquareType = new Treasure();
                        break;
                    case 'H':
                        sq.SquareType = new Hotel();
                        break;
                    default:
                        break;

                }
                sq.NextSquare = square;
                square = sq;
            }
            temp.NextSquare = square;
            return square;
        }
    }
}
