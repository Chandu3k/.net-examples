using System;
class P5
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        int a=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number: ");
        int b=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter third number: ");
        int c=int.Parse(Console.ReadLine());

        if(a>=b && a >= c)
        {
            Console.WriteLine("Largest number is "+ a);
        }else if(b>=a && b >= c)
        {
            Console.WriteLine("Largest number is "+ b);
        }
        else
        {
            Console.WriteLine("Largest number is "+ c);

        }
        Console.ReadLine();

    }
}