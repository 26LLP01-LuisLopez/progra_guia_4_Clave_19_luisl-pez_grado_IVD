internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        Console.WriteLine("Ingrese un número mayor a 20:");
        num = Convert.ToInt32(Console.ReadLine());
       int i = 21;
        while (i <= num)
        {
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
    }
}
