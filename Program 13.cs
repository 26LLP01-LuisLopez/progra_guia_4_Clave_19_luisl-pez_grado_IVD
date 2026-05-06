using System;
class Program
{

    static void Main()
    {
        int total = 0, cont = 0;
        for (int i = 1; i <= 1000; i++)
        {
            int billete = int.Parse(Console.ReadLine());
            total += billete;
            if (billete == 100) cont++;
        }
        Console.WriteLine(cont);
        Console.WriteLine(total);
    }
}