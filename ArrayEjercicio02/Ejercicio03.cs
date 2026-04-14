namespace ArrayEjercicio02;

class Ejercicio03
{
    static void Main(string[] args)
    {
        double[] precios = { 19.99, 5.49, 3.75, 12.00 };

        Console.WriteLine("Precios");
        foreach (double precio in precios)
        {
            Console.WriteLine("- $" + precio);
        }
    }
}