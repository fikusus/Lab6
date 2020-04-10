using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z1
{
    class MyRoom:IRoom
    {
        public MyRoom(uint windows, double a_side, double b_side, uint beds)
        {
            Windows = windows;
            A_side = a_side;
            B_side = b_side;
            Beds = beds;
        }

        public uint Windows { get; set; }

        public double A_side { get; }

        public double B_side { get; }

        public uint Beds { get; }

        public double Area()
        {
            return A_side * B_side;
        }

        public int CompareTo(IRoom obj)
        {
            if (this.Area() == obj.Area()) return 0;
            else if (this.Area() > obj.Area()) return 1;
            else return -1;
        }
        public override string ToString()
        {
            return "Моя комната сторонами " + A_side + "*" + B_side + " площадью:" + Area() + " количество окон:" + Windows + " количество кроватей:" + Beds;
        }
    }
}
