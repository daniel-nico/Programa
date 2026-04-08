namespace Programa03;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- BLOQUE 2: NÚMEROS CON DECIMALES ---");

            // Temperatura corporal (double)
            double temperatura = 36.6; 
            Console.WriteLine("1. TIPO DECIMAL ESTÁNDAR (double):");
            Console.WriteLine("   Se usa para medidas como peso, distancia o clima.");
            Console.WriteLine("   Tu temperatura actual es: " + temperatura + "°C");

            // Saldo de cuenta (decimal)
            decimal saldoBilletera = 15450.75m; 
            Console.WriteLine("\n2. TIPO DECIMAL DE ALTA PRECISIÓN (decimal) - Ejemplo 2:");
            Console.WriteLine("   ¡Es el que debés usar para dinero y finanzas!");
            Console.WriteLine("   Saldo disponible: $" + saldoBilletera);

            // Vuelto de una compra (decimal)
            decimal precioProducto = 1987.33;
            decimal pago = 5000;
            decimal vuelto = pago - precioProducto;
            Console.WriteLine("\n3. TIPO DECIMAL DE ALTA PRECISIÓN (decimal) - Ejemplo 3:");
            Console.WriteLine("   Se usa para calcular el vuelto de una compra.");
            Console.WriteLine("   Precio del producto: $" + precioProducto);
            Console.WriteLine("   Pago realizado: $" + pago);
            Console.WriteLine("   Vuelto a recibir: $" + vuelto);

            // Promedio de calificaciones (double)
            double calificacion1 = 8.5;
            double calificacion2 = 9.0;
            double calificacion3 = 7.5;
            double promedioCalificaciones = (calificacion1 + calificacion2 + calificacion3) / 3;
            Console.WriteLine("\n4. TIPO DECIMAL ESTÁNDAR (double) - Ejemplo 4:");
            Console.WriteLine("   Se usa para calcular promedios, como el de calificaciones.");
            Console.WriteLine("   Calificaciones: " + calificacion1 + ", " + calificacion2 + ", " + calificacion3);
            Console.WriteLine("   Promedio de calificaciones: " + promedioCalificaciones);

            // Altura de una persona (double)
            double altura = 1.75;
            Console.WriteLine("\n5. TIPO DECIMAL ESTÁNDAR (double) - Ejemplo 5:");
            Console.WriteLine("   Se usa para representar la altura de una persona.");
            Console.WriteLine("   Altura: " + altura + " metros");

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

    }
}
