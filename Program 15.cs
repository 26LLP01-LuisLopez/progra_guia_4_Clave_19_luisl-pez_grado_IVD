using System;
class Program
{
    static void Main()
    {
        int sumaPares = 0, contadorPrimos = 0;
        for (int i = 300; i >= 1; i--)
        {
            if (i % 2 == 0) sumaPares += i;
            bool esPrimo = true;
            if (i < 2) esPrimo = false;
            else
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0) { esPrimo = false; break; }
                }
            }
            if (esPrimo) contadorPrimos++;
        }
        Console.WriteLine(contadorPrimos);
        Console.WriteLine(sumaPares);
    }
}