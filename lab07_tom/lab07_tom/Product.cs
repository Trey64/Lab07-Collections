using System;
using System.Collections.Generic;
using System.Text;

namespace lab07_tom
{
    class Product
    {
        public Brand TvBrand { get; set; }
    }

    enum Brand : int
    {
        Samsung = 1,
        Sony,
        LG,
        Panasonic,
        Insignia,
        Sharp,
        Vizio
    }
}
