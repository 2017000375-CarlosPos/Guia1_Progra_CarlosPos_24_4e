internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Pon un numero de la semana del 1 al 7:");
        int d = int.Parse(Console.ReadLine());

        if (d >= 1 && d <= 5)
        {
            Console.WriteLine("entre semana");
        }
        else if (d == 6 || d == 7)
        {
            Console.WriteLine("fin de semana");
        }
        else
        {
            Console.WriteLine("dia no existente");
        }
    }
}