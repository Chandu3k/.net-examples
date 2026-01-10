using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            String name = Console.ReadLine();
            Console.WriteLine("Enter your Age:");
            int age = int.Parse(Console.ReadLine());
            int i= 1;
            int k = age + i;

            Console.WriteLine("Hello " + name + "," + "you will be " + k + " next year");

        }
    }
}
