internal class Program
{
    private static void Main(string[] args)
    {
        int monedas = 0;
        while (monedas < 350)
        {
            Console.WriteLine("Inserta tus moneda:");
            monedas= Convert.ToInt32(Console.ReadLine());    
        }
        Console.WriteLine("Nuevo nivel desbloqueado");
    }
}