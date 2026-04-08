namespace Programa04;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("--- BLOQUE 3: TEXTO Y CARACTERES ---");

            // Nombre de la asignatura (string) - Siempre con comillas dobles ""
            string materia = "Programación I";
            Console.WriteLine("1. TIPO CADENA DE TEXTO (string):");
            Console.WriteLine("   Se usa para palabras, frases o párrafos completos.");
            Console.WriteLine("   Materia actual: " + materia);

            // Calificación o sección (char) - Siempre con comillas simples ''
            char nivel = 'S'; 
            Console.WriteLine("\n2. TIPO CARÁCTER ÚNICO (char):");
            Console.WriteLine("   ¡Ojo! Solo guarda UN símbolo, letra o número.");
            Console.WriteLine("   Nivel de dificultad: '" + nivel + "' (S de Superior)");

            // Descripción de un producto (string)
            string descripcionProducto = "Laptop Gamer con pantalla de 15.6 pulgadas, procesador Intel i7, 16GB de RAM y tarjeta gráfica NVIDIA RTX 3060.";
            Console.WriteLine("\n3. TIPO CADENA DE TEXTO (string) - Ejemplo 3:");
            Console.WriteLine("   Se usa para describir productos, como en un catálogo.");
            Console.WriteLine("   Descripción del producto: " + descripcionProducto);

            // Inicial de un nombre (char)
            char inicialNombre = 'S';
            Console.WriteLine("\n4. TIPO CARÁCTER ÚNICO (char) - Ejemplo 4:");
            Console.WriteLine("   Se usa para representar la inicial de un nombre.");
            Console.WriteLine("   Inicial del nombre: '" + inicialNombre + "'");

            // Genero de una persona (char)
            char genero = 'F';
            Console.WriteLine("\n5. TIPO CARÁCTER ÚNICO (char) - Ejemplo 5:");
            Console.WriteLine("   Se usa para representar el género de una persona.");
            Console.WriteLine("   Género: '" + genero + "' (F de Femenino)");

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

    }
}
