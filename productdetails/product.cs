﻿using System;
using System.Collections.Generic;
using System.Text;

namespace productdetails
{
    public class product
    {
        public int ProId { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; }

        public int Discount { get; set; }


        public int disco()
        {
            int total = Quantity * Price;
            int FinalPrice = total - Discount;
            return FinalPrice;
        }

    }
}
