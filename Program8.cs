internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Pon los tres angulos del triangulo");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (a + b + c == 180)
        {
            if (a < 90 && b < 90 && c < 90) Console.WriteLine("es acutangulo");
            else if (a == 90 || b == 90 || c == 90) Console.WriteLine("es rectangulo");
            else Console.WriteLine("es obtusangulo.");
        }
        else
        {
            Console.WriteLine("no es valido el triangulo");
        }
    }
}