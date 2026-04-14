namespace ArrayEjercicio03;

class Ejercicio02
{
    static void Main(string[] args)
    {
        string[] materias = { "Programacion III", "Ingles", "Base de Datos II"};

        Console.WriteLine("Materias");

        for (int i = 0; i < materias.Length; i++)
        {
            Console.WriteLine("- " + materias[i]);
        }
    }
}