namespace Programa03;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- BLOQUE 2: NÚMEROS CON DECIMALES ---");

            // Temperatura corporal (double)
            // Ideal para mediciones físicas y científicas
            double temperatura = 36.6; 
            Console.WriteLine("2. TIPO DECIMAL ESTÁNDAR (double):");
            Console.WriteLine("   Se usa para medidas como peso, distancia o clima.");
            Console.WriteLine("   Tu temperatura actual es: " + temperatura + "°C");

            // Saldo de cuenta (decimal)
            // El sufijo 'm' es fundamental para que el compilador no se confunda
            decimal saldoBilletera = 15450.75m; 
            Console.WriteLine("\n3. TIPO DECIMAL DE ALTA PRECISIÓN (decimal):");
            Console.WriteLine("   ¡Es el que debés usar para dinero y finanzas!");
            Console.WriteLine("   Saldo disponible: $" + saldoBilletera);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

    }
}
