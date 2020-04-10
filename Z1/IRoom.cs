using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z1
{
    interface IRoom:IComparable<IRoom>
    {
        uint Windows { get; set; }
        double A_side { get; }
        double B_side { get; }
        double Area();


    }
}
