using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessGameTW
{
    public class Square
    {

        public ISquare SquareType { get; set; }
        public Square NextSquare { get; set; }
        public Player CurrentPlayer { get; set; }

    }
}
