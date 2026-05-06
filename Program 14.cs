using System;
class Program
{
    static void Main()
    {
        int suma = 0, pares = 0;
        for (int i = 1; i <= 20; i++)
        {
            int num = i * 7;
            suma += num;
            if (num % 2 == 0) pares++;
        }
        Console.WriteLine(suma);
        Console.WriteLine(pares);
    }
}