class programa01
{
    static void Main(string[] args)
    {
        // --- CONSTANTES DE CÁLCULO Y CONTROL ---
        const int DANIO_BASE_ESPADA = 15;
        const double MULTIPLICADOR_CRITICO = 1.5;
        const char ICONO_ATAQUE = '⚔';

        Console.WriteLine("--- LOG DE COMBATE " + ICONO_ATAQUE + " ---");

        int nivelPersonaje = 5;
        bool esGolpeCritico = true; // Supongamos que el azar decidió esto
        double danioFinal = (DANIO_BASE_ESPADA * nivelPersonaje) * (esGolpeCritico ? MULTIPLICADOR_CRITICO : 1.0);

        Console.WriteLine("Atacando con Nivel: " + nivelPersonaje);
        Console.WriteLine("¿Fue golpe crítico?: " + esGolpeCritico);
        Console.WriteLine("Daño total causado: " + danioFinal + " puntos.");

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();
    }
}