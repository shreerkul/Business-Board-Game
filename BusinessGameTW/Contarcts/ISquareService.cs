using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessGameTW.Contarcts
{
    interface ISquareService
    {
        void UpdateSquare(ref Player player, Square square);
    }
}
