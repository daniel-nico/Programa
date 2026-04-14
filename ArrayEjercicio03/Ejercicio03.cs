namespace ArrayEjercicio03;

class Ejercicio03
{
    static void Main(string[] args)
    {
        bool[] estados = { true, false, true };

            Console.WriteLine("--- ESTADO DE RED ---");

            for (int i = 0; i < estados.Length; i++)
            {
                Console.WriteLine("Servidor [" + i + "] activo: " + estados[i]);
}
    }
}