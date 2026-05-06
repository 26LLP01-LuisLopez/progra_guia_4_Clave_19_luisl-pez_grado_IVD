using System;

class Program
{
    static void Main()
    {
        int suma = 0;
        for (int i = 1; i <= 22; i++)
        {
            bool Primo = true;
            if (i <= 1)
                Primo = false;
            else
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        Primo = false;
                        break;
                    }
                }
            }
            if (Primo)
                suma += i;
        }
        Console.WriteLine("La suma de primos es: " + suma);
    }
}