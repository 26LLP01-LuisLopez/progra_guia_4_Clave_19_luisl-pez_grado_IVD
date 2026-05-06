using System;
class Program
{
    static void Main()
    {
        int contador = 0, suma = 0;
        for (int i = 2; i <= 100; i++)
        {
            bool esPrimo = true;
            for (int x = 2; x < i; x++)
            {
                if (i % x == 0) { esPrimo = false; break; }
            }
            if (esPrimo) { contador++; suma += i; }
        }
        Console.WriteLine("Cantidad: " + contador);
        Console.WriteLine("Suma: " + suma);
    }
}