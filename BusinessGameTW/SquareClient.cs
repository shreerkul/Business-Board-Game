using BusinessGameTW.Contarcts;
using BusinessGameTW.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessGameTW
{
    class SquareClient
    {
        public ISquareService GetServiceInstance(char type)
        {
            switch(type)
            {
               
                case 'J':
                    return new JailService();
                case 'T':
                    return new TreasureService();
                case 'H':
                    return new HotelService();
                default:
                    break;
            }
            return null;
        }
    }
}
