using System;

class P3
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a Number: ");
        int a= int.Parse(Console.ReadLine());
        if (a > 0)
        {
            Console.WriteLine("The Number you Entered is Positive");
        }
        else if (a < 0)
        {
            Console.WriteLine("The number You Entered is Negative");
        }
        else
        {
            Console.WriteLine("The number You Entered is Zero");
          
        }
        Console.ReadLine();

    }
}