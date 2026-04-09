class programa01
{
    static void Main(string[] args)
    {
        // --- CONSTANTES DE CÁLCULO Y CONTROL ---
        const decimal PRECIO_HORA = 800.00m;
        const int TOLERANCIA_MINUTOS = 15;
        const string NOMBRE_PLAYA = "Parking Central";

        Console.WriteLine("--- " + NOMBRE_PLAYA + " ---");
        Console.WriteLine("Regla: Tolerancia de " + TOLERANCIA_MINUTOS + " minutos sin cargo.");

        int horasEstadia = 3;
        decimal subtotal = horasEstadia * PRECIO_HORA;
        decimal descuentoFidelidad = 150.00m; // Descuento fijo
        decimal totalAPagar = subtotal - descuentoFidelidad;

        Console.WriteLine("\nResumen de estadía:");
        Console.WriteLine("Tiempo: " + horasEstadia + " horas.");
        Console.WriteLine("Subtotal: $" + subtotal);
        Console.WriteLine("Total final (con descuento aplicado): $" + totalAPagar);

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();
    }
}