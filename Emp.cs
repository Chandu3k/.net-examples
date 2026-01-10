using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopsexample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // In lopps we have mainly 3 types
            // 1. for loop
            
            // for (int i = 0; i <= 6; i++)
            // {
            //    Console.WriteLine("Happy New Year ");
            //    for (int j = 0; j < 1; j++)
            //    {
            //        Console.WriteLine("Welcome to 2026");
            //    }
            // }


            // print a pattern exmaple;
            // for (int i=0; i<=5; i++)
            // {
            //    for(int j = 0; j <= 5; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            // }

            // While loop 
            // int count = 1;
            // while (count <= 10)
            // {
            //     Console.WriteLine("Count is: " + count);
            //     count++;
            // }

            // for(int i = 1; i <= 3; i++)
            // {
            //     for(int j = 1; j <= 3; j++)
            //     {
            //         Console.WriteLine(i+" "+j);
            //     }
            // }
            // Console.ReadLine();

            int i= 1;
            while (i <= 5)
            {
            int j =1;
            while(j<=i)
            {
            Console.Write("* ");
            j++;
            }
            Console.WriteLine();
        i++;
            }
            Console.ReadLine();
        }
    }
}
