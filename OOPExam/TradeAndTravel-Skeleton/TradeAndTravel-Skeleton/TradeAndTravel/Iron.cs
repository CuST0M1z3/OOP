using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
    public class Iron : Item
    {
        private const int generalIronValue = 3;

        public Iron(string name, Location location = null)
            : base(name, Iron.generalIronValue, ItemType.Iron, location)
        {
        }
    }
}
