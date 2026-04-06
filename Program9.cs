internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Pon tu nota del 1 al 100:");
        int nota = int.Parse(Console.ReadLine());

        if (nota < 60) Console.WriteLine("Deficiente");
        else if (nota < 70) Console.WriteLine("Regular");
        else if (nota < 80) Console.WriteLine("Bien");
        else if (nota < 90) Console.WriteLine("Muy bien");
        else Console.WriteLine("Excelente");
    }
}