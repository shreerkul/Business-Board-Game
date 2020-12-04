using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessGameTW
{
    class Property
    {
        public int PropertyId { get; set; }
        public string PropertyName { get; set; }
        public int Value { get; set; }
        public int rent { get; set; }
        public bool Owned { get; set; }
        public Player Owner { get; set; }
    }
}
