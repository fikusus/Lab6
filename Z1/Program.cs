/*Створіть інтерфейс "Room". Реалізуйте його в класах «ClassRoom», «MyRoom». Реалізуйте інтерфейс
"IComparable". В якості параметра для сортування використовуйте площу кімнати. Реалізуйте інтерфейс
"IComparer", в якості порівняння використовуйте поле «Кількість вікон».
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = rnd.Next(4, 10);
            Room[] rooms = new Room[n];
            for (int i = 0; i < n; i++)
            {
                if (rnd.Next(0, 2) == 0)
                {
                    rooms[i] = new ClassRoom((uint)rnd.Next(1, 5), rnd.Next(2, 10), rnd.Next(1, 10), (uint)rnd.Next(1, 4));
                }
                else
                {
                    rooms[i] = new MyRoom((uint)rnd.Next(1, 5), rnd.Next(2, 10), rnd.Next(1, 10), (uint)rnd.Next(1, 3));
                }
            }
            Console.WriteLine("До сортировки:");
            foreach (Room item in rooms)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Сортировка по площади(IComparable):");
            Array.Sort(rooms);
            foreach (Room item in rooms)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Сортировка по количеству окон(IComparer):");
            Array.Sort(rooms, new RoomComparer());
            foreach (Room item in rooms)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
