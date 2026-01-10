using System;
internal class preogram1
{
    static void Main(string[] args)
    {
        for(int i = 1; i <= 10; i++){
            if (i == 5)
            {
                Console.WriteLine(i);
                Console.WriteLine("The value has reached its limit");
                break;
                // continue;
            }
            Console.WriteLine(i);
        }
    }
}