using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(5,2,3);

            box.Show();

            int x = box.Volum();

            Console.WriteLine($"объем коробки {x}");

            Console.ReadKey();
        }
    }
}
