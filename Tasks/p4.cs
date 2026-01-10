using System;

class P4
{
    public static void Main()
    {
        Console.WriteLine("Enter a Number");
        long a= long.Parse(Console.ReadLine());
        // odd or even
        if (a % 2 == 0)
        {
            Console.WriteLine("The Number is Even");
        }
        else
        {
            Console.WriteLine("The Number is Odd");

        }
    }
}