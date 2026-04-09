class programa01
{
    static void main(string[] args)
    {
        // --- CONSTANTES DE IDENTIDAD Y REGLAS ---
        const string MOTOR_SIMULACION = "PhysX-Turbo Engine";
        const int MAX_VELOCIDAD = 350; // KM/H
        const string REGION_SERVER = "South America - 1";

        Console.WriteLine("Iniciando simulación con: " + MOTOR_SIMULACION);
        Console.WriteLine("Servidor conectado: " + REGION_SERVER);
        Console.WriteLine("Límite de motor: La velocidad máxima permitida en pista es " + MAX_VELOCIDAD + " km/h.");

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();
    }
}