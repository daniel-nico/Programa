namespace ArrayEjercicio03;

class Ejercicio05
{
    static void Main(string[] args)
    {
        int[] año = { 1998, 2003, 1995 };

        Console.WriteLine("Años");

        for (int i = 0; i < año.Length; i++)
        {
            Console.WriteLine("- " + año[i]);
        }
    }
}