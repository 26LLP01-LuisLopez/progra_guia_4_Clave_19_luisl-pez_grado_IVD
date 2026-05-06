using System;

class Program
{
    static void Main()
    {
        int num;
        Console.WriteLine("Ingrese un número:");
        num = Convert.ToInt32(Console.ReadLine());
        bool esPrimo = true;
        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
                esPrimo = false;
        }
        if (esPrimo && num > 1)
            Console.WriteLine("Es primo");
        else
            Console.WriteLine("No es primo");
    }
}