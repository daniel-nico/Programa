class program01
{
    static void Main(string[] args)
    {
        // --- CONSTANTES DE IDENTIDAD Y REGLAS ---
        const string GYM_NAME = "PowerFit Center";
        const string SUBCRIPCION_TIPO = "Premium";
        const int MAX_AFORO = 50;

        Console.WriteLine(">>> Bienvenido a: " + GYM_NAME + " <<<");
        Console.WriteLine("Tipo de acceso actual: " + SUBCRIPCION_TIPO);
        Console.WriteLine("Alerta de seguridad: No ingresar más de " + MAX_AFORO + " personas simultáneamente.");

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();
    }
}