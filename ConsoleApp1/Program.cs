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
             //ask the user the amount of pizza
            Console.WriteLine("How many pizzas would you like?");
            double answer = double.Parse(Console.ReadLine());

             //loop for no. times you wanted pizza
            for (double i = 0; i < answer; i++);
            {
                Console.WriteLine("Eat Pizza number " + answer);
            }


            Console.ReadLine();
        }
    }
}
