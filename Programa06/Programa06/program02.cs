class programa01
{
    static void Main(string[] args)
    {
        // --- CONSTANTES DE IDENTIDAD Y REGLAS ---
        const string STORE_ID = "QuickShop-AR";
        const double DESCUENTO_BIENVENIDA = 15.5; // Porcentaje
        const int ENVIO_GRATIS_MINIMO = 50000;

        Console.WriteLine("--- " + STORE_ID + " Marketplace ---");
        Console.WriteLine("Promoción: Tenés un " + DESCUENTO_BIENVENIDA + "% de descuento en tu primer carrito.");
        Console.WriteLine("Regla de envío: Compras mayores a $" + ENVIO_GRATIS_MINIMO + " tienen envío sin cargo.");

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();
    }
}