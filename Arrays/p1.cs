using System;
class Program
{
    static void Main()
    {
        int r,c,i,j;
        Console.WriteLine("enter row size,column size values");
        r=int.Parse(Console.ReadLine());
        c=int.Parse(Console.ReadLine());
        int[,] a=new int[r,c];
        Console.WriteLine("enter array elements");
        for (i = 0; i < r; i++)
        {
            for (j = 0; j < c; j++)
            {
                a[i,j]=int.Parse(Console.ReadLine());

            }
        }
        Console.WriteLine("array elements are");
        for (i = 0; i < r; i++)
        {
            for (j = 0; j < c; j++)
            {
                Console.Write(a[i,j]+" ");
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }       
}