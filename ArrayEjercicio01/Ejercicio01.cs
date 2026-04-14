namespace ArrayEjercicio01
{
    class Ejerciio01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Ejercicio 1: Fundamentos de arreglos");

            string[] nombres = new string[3];

            nombres[0] = "Juan";
            nombres[1] = "María";
            nombres[2] = "Carlos";

            Console.WriteLine("\nNombres almacenados en el arreglo:");
            Console.WriteLine("1. " + nombres[0]);
            Console.WriteLine("2. " + nombres[1]); 
            Console.WriteLine("3. " + nombres[2]);


        }
    }
}