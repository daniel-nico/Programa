namespace ArrayEjercicio02;

class Ejercicio02
{
    static void Main(string[] args)
    {
        int[] notas = {10,7,8,5,9};

        Console.WriteLine("Notas");

        foreach (int nota in notas)
        {
            Console.WriteLine("- " + nota);
        }
    }
}