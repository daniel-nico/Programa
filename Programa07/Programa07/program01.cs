class programa01
{
    static void Main(string[] args)
    {
        // --- CONSTANTES DE CÁLCULO Y CONTROL ---
        const int STOCK_MINIMO = 10;
        const bool PERMITIR_SOBREVENTA = false; 
        const string CATEGORIA_DEFAULT = "General";

        Console.WriteLine("--- SISTEMA DE INVENTARIO ---");
        Console.WriteLine("Configuración: Permitir sobreventa = " + PERMITIR_SOBREVENTA);

        int stockActual = 8;
        bool necesitaReposicion = stockActual < STOCK_MINIMO;

        Console.WriteLine("\nProducto: Teclado Mecánico (" + CATEGORIA_DEFAULT + ")");
        Console.WriteLine("Stock disponible: " + stockActual + " unidades.");
        Console.WriteLine("¿Necesita pedido al proveedor?: " + necesitaReposicion);

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();
    }
}