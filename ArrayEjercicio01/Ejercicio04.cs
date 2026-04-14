namespace ArrayEjercicio01;

class Ejercicio04
{
    static void Mian(string[] args)
    {
        bool[] respuestas = new bool[3];

        respuestas[0] = true;
        respuestas[1] = false;
        respuestas[2] = true;

        Console.WriteLine("Respuestas almacenados en el arreglo:");
        Console.WriteLine("1. " + respuestas[0]);
        Console.WriteLine("2. " + respuestas[1]);
        Console.WriteLine("3. " + respuestas[2]);
    }
}