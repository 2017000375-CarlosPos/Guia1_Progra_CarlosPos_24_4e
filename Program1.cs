using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Pon tus 5 calificaciones:");
        double n1, n2, n3, n4, n5, promedio;

        n1 = double.Parse(Console.ReadLine());
        n2 = double.Parse(Console.ReadLine());
        n3 = double.Parse(Console.ReadLine());
        n4 = double.Parse(Console.ReadLine());
        n5 = double.Parse(Console.ReadLine());

        promedio = (n1 + n2 + n3 + n4 + n5) / 5;

        Console.WriteLine("Promedio: " +promedio);

        if (promedio >= 70)
        {
            Console.WriteLine("Aprobado");
        }
        else
        {
            Console.WriteLine("Reprobado");
        }

        Console.ReadKey();
    }
}