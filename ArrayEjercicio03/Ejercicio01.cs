namespace ArrayEjercicio03;

class Ejercicio01
{
    static void Main(string[] args)
    {
        double[] precios = { 19.99, 5.49, 3.75, 12.00 };

        Console.WriteLine("Precios");

        for (int i = 0; i < precios.Length; i++)
        {
            Console.WriteLine("- $" + precios[i]);
        }
    }
}