using System;
using System.Collections;
using System.Text;
class Program
{
    public static string Black()
    {
        string a ="SAI CHANDU";
        string b="Konka";
        string original= string.Concat(a," ", b);
        // lower=original.ToLower();
        return original.ToLower();
    }

    static void Main(String[] args)
    {
        string value =Black();
        Console.WriteLine(value);
        
    }


}