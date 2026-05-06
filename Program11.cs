using System;

class Program
{
    static void Main()
    {
        int autos = 0;

        do
        {
            autos++;
            Console.WriteLine("Auto ingresado. Total: " + autos);
        } while (autos < 200);

        Console.WriteLine("Estacionamiento lleno");
    }
}