using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many pizzas would you like?");
            int answer = int.Parse(Console.ReadLine());

            for (int i = 0, i < answer; i++)
            {
                Console.WriteLine("Eat Pizza number" + answer);
            }

            Console.ReadLine();
        }
    }
}
