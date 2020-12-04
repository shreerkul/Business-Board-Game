using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessGameTW
{
    class Start : ISquare
    {
        public Start()
        {
            this.SquareName = 'S';
        }
        public char SquareName { get; set; }
    }
}
