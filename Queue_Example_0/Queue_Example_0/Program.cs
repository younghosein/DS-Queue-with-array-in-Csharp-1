using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Example_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue s = new Queue(10);

            s.enqueue(21);
            s.enqueue(92);
            s.enqueue(61);
            s.enqueue(88);
            s.enqueue(43);
            s.enqueue(75);
            s.enqueue(59);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Queue Is : ");
            s.print();
            Console.ResetColor();
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.Red;
            s.dequeue();
            Console.WriteLine("Now Queue Is : ");
            s.print();
            Console.ResetColor();
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            int a = s.avg();
            Console.WriteLine("Average Is : ");
            Console.WriteLine(a);
            Console.ResetColor();
            Console.WriteLine("\n");


            Console.ReadKey();
        }
    }
}
