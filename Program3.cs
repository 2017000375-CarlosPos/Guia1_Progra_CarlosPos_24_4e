internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Menú de atención:");
        Console.WriteLine("1.direccion\n2.secretaria\n3.maestros\n4.pagos");
        Console.Write("Pon el numero de buzon: ");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Redirigido a direccion");
                break;
            case 2:
                Console.WriteLine("Redirigido a secretaria");
                break;
            case 3:
                Console.WriteLine("Redirigido a maestros");
                break;
            case 4:
                Console.WriteLine("Redirigido a pagos");
                break;
            default:
                Console.WriteLine("No existe.");
                break;
        }
    }
}