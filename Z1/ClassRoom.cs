﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z1
{
    class ClassRoom : IRoom
    {
        public ClassRoom(uint windows, double a_side, double b_side, uint school_desks)
        {
            Windows = windows;
            A_side = a_side;
            B_side = b_side;
            School_desks = school_desks;
        }

        public uint Windows { get; set; }

        public double A_side { get; }

        public double B_side { get; }

        public uint School_desks { get; }

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
            return "Класная комната сторонами " + A_side + "*" + B_side + " площадью:" + Area() + " количество окон:" + Windows + " количество досок:" + School_desks;
        }
    }
}
