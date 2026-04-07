namespace Programa04;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("--- BLOQUE 3: TEXTO Y CARACTERES ---");

            // Nombre de la asignatura (string) - Siempre con comillas dobles ""
            string materia = "Programación I";
            Console.WriteLine("4. TIPO CADENA DE TEXTO (string):");
            Console.WriteLine("   Se usa para palabras, frases o párrafos completos.");
            Console.WriteLine("   Materia actual: " + materia);

            // Calificación o sección (char) - Siempre con comillas simples ''
            char nivel = 'S'; 
            Console.WriteLine("\n5. TIPO CARÁCTER ÚNICO (char):");
            Console.WriteLine("   ¡Ojo! Solo guarda UN símbolo, letra o número.");
            Console.WriteLine("   Nivel de dificultad: '" + nivel + "' (S de Superior)");

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

    }
}
