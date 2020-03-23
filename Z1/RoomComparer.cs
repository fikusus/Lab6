using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z1
{
    class RoomComparer : IComparer<Room>
    {
        public int Compare(Room x, Room y)
        {
            if (x.Windows == y.Windows) return 0;
            else if (x.Windows > y.Windows) return 1;
            else return -1;
        }
    }
}
