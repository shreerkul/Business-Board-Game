using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessGameTW
{
    class Jail : ISquare
    {
        public Jail()
        {
            this.SquareName = 'J';
        }
        public char SquareName { get; set; }

    }
}
