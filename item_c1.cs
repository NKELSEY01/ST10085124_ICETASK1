using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace icetask1
{
    class item_c1
    {
        public item_c1(string NameOfItem, double PriceOfItem)
        {
            NameOfItems 
                = NameOfItem;
            PriceOfItems 
                = PriceOfItem;
        }
        public string NameOfItems { get; set; }
        public double PriceOfItems { get; set; }
    }
}