using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessGameTW
{
    class Hotel : Property,ISquare
    {
        public Hotel()
        {
            this.SquareName = 'H';
        }
        public char SquareName { get; set; }

    }
}
