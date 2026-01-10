using System;
class P2
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter first number:");
        int a= int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int b= int.Parse(Console.ReadLine());

        int sum = a+b;
        int difference= a-b;
        int product=a*b;
        double quotient= (double)a/b;
        Console.WriteLine("sum: "+sum);
        Console.WriteLine("Difference: "+ difference);
        Console.WriteLine("product: " + product);
        Console.WriteLine("quotient: "+ quotient);

        Console.ReadLine();




    }
}