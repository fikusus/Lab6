using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z1
{
    class RoomComparer : IComparer<IRoom>
    {
        public int Compare(IRoom x, IRoom y)
        {
            if (x.Windows == y.Windows) return 0;
            else if (x.Windows > y.Windows) return 1;
            else return -1;
        }
    }
}
