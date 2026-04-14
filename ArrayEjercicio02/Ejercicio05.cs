namespace ArrayEjercicio02;

class Ejercicio05
{
    static void Main(string[] args)
    {
        int[] temperaturas = { 25, 30, 28, 22, 27 };

        Console.WriteLine("Temperaturas");

        foreach (int temperatura in temperaturas)
        {
            Console.WriteLine("- " + temperatura + "°C");
        }
    }
}