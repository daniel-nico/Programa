namespace ArrayEjercicio02;

class Ejercicio01
{
    static void Main(string[] args)
    {
        string[] juegos = { "FIFA 23", "Call of Duty: Modern Warfare II", "The Legend of Zelda: Breath of the Wild" };

        Console.WriteLine("Juegos");
         foreach (string juego in juegos)
        {
            Console.WriteLine("- " + juego);
        }
    }
}