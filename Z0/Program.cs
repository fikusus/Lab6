/*Описати клас Square (геометрична фігура квадрат) та навести в цьому класі реалізацію
інтерфейса IMeasurable
Реалізувати підтримку інтерфейсу System.IСomparable у класі Square із завдання вище. Слід мати на
увазі, що при реалізації методу CompareTo програміст самостійно визначає критерій порівняння
об’єктів. Порівнювати квадрати за величиною периметру.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z0
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int n = rnd.Next(3, 10);
            Square[] squares = new Square[n];
            for (int i = 0; i < n; i++)
            {
                squares[i] = new Square(rnd.Next(1, 20));
            }
            Console.WriteLine("До сортировки:");
            foreach (Square item in squares)
            {
                Console.WriteLine(item);
            }
            Array.Sort(squares);
            Console.WriteLine("После сортировки:");
            foreach (Square item in squares)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }


    }
}
