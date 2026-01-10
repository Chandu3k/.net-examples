using System;
class Leap_Year
{
    static void Main()
    {
        Console.Write("Enter the year: ");
        long year=long.Parse(Console.ReadLine());
        if(year % 400==0 ||( year % 4==0 && year % 100!=0))
        {
            Console.WriteLine("Leap Year");
        }
        else
        {
            Console.WriteLine("Not a Leap Year");
        }
    }   
}