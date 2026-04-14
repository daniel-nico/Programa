class programa01
{
    static void Main(string[] args)
    {
        // --- CONSTANTES DE CÁLCULO Y CONTROL ---
        const decimal TIPO_CAMBIO_USD = 950.25m;
        const decimal COMISION_SERVICIO = 0.05m; // 5% de comisión
        const string MONEDA_ORIGEN = "ARS";

        Console.WriteLine("--- EXCHANGE SERVICE (" + MONEDA_ORIGEN + " to USD) ---");

        decimal montoPesos = 50000m;
        decimal comisionCalculada = montoPesos * COMISION_SERVICIO;
        decimal montoNeto = montoPesos - comisionCalculada;
        decimal dolaresFinales = montoNeto / TIPO_CAMBIO_USD;

        Console.WriteLine("Monto a cambiar: $" + montoPesos);
        Console.WriteLine("Comisión aplicada: $" + comisionCalculada);
        Console.WriteLine("Total recibido: U$D " + Math.Round(dolaresFinales, 2));

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();
    }
}