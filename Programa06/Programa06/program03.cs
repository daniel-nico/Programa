class programa01
{
    static void Main(string[] args)
    {
        // --- CONSTANTES DE IDENTIDAD Y REGLAS ---
        const string SISTEMA_ID = "SecureGuard-Home-V3";
        const int TIEMPO_ALERTA_SEG = 30;
        const string NIVEL_ENCRIPTACION = "AES-256";

        Console.WriteLine("Estado del Sistema: " + SISTEMA_ID);
        Console.WriteLine("Seguridad de datos: Protocolo " + NIVEL_ENCRIPTACION + " activo.");
        Console.WriteLine("Regla: Si no hay respuesta en " + TIEMPO_ALERTA_SEG + " segundos, se dispara la alarma.");

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();
    }
}