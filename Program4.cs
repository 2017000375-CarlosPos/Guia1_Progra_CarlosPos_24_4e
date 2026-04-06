internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Pon un mes del 1 al 12:");
        int mes = int.Parse(Console.ReadLine());
        if (mes == 3 || mes == 4 || mes == 5) Console.WriteLine("primavera");
        else if (mes == 6 || mes == 7 || mes == 8) Console.WriteLine("verano");
        else if (mes == 9 || mes == 10 || mes == 11) Console.WriteLine("otoño");
        else Console.WriteLine("invierno");
    }
}