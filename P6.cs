using System;
using System.Diagnostics;
class P6
{
    static void Main()
    {
        Console.WriteLine("Enter the value: ");
        int a=int.Parse(Console.ReadLine());
        if(a % 5==0 && a% 11 == 0)
        {
            Console.WriteLine("divisible by 5 and 11");
        }
        else
        {
            Console.WriteLine("Not divisible by 5 and 11");
           
        }
    }
}