internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Pon tu contraseña:");
        string contra = Console.ReadLine();

        if (contra == "Password123") {
            Console.WriteLine("Bienvenido");
        } else
        {
            Console.WriteLine("El ingreso esta prohibido");
        }
    }
}