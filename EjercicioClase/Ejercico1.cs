namespace EjercicioClase;

class Ejercicio1
{
    static void Main(string[] args)
    {
        string[] nombre = new string[20];
        int[] edad = new int[20];

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Ingrese el nombre de la persona " + (i + 1) + ":");
            nombre[i] = Console.ReadLine();

            Console.WriteLine("Ingrese la edad de la persona " + (i + 1) + ":");
            edad[i] = int.Parse(Console.ReadLine());

            if (edad[i] >= 30)
            {
                Console.WriteLine(nombre[i] + " es mayor de edad.");
            }
            else
            {
                Console.WriteLine(nombre[i] + " A la casa");
            }
        }

    }
}