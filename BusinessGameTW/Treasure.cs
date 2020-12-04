using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessGameTW
{
    class Treasure : ISquare
    {
        public Treasure()
        {
            this.SquareName = 'T';
        }
        public char SquareName { get; set; }
    }
}
