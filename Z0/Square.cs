using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z0
{
    class Square : IMeasurable, ICircumcircleIncircle, IComparable<Square>
    {
       public double A { get; set; }
       public double R// радіус описаного кола
        {                 
            get
            {
                return A / Math.Sqrt(2);
            }
        } 
       public double r// радіус вписаного кола
        {
            get
            {
                return A / 2;
            }
        }
        

        
        public double Area()
        {
            return A * A;
        }

        public double Perimeter()
        {
            return 4 * A;
        }

        public override string ToString()
        {
            return "Квадрат со сторонами а = " + A + " площадью:" + Area() + " периметром:" + Perimeter() + " радиус описаного круга:" + R + " вписаного:" + r; 
        }

        public int CompareTo(Square obj)
        {
            if (this.Perimeter() == obj.Perimeter()) return 0;
            else if (this.Perimeter() > obj.Perimeter()) return 1;
            else return -1;
        }

        public Square(double a)
        {
            A = a;
        }

    }
}
