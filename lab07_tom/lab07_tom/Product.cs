using System;
using System.Collections.Generic;
using System.Text;

namespace lab07_tom
{
    class Product
    {
        public int Price { get; set; }
        public string Model { get; set; }
        public Brand TvBrand { get; set; }

        public bool Is4K()
        {
            if(TvBrand == Brand.Panasonic || TvBrand == Brand.Sharp)
            {
                return false;
            }
            return true;
        }

        public bool InStock()
        {
            return true;
        }
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
