class programa01
{
    static void Main(string[] args)
    {
        // --- CONSTANTES DE IDENTIDAD Y REGLAS ---
        const string INSTITUCION = "Instituto Técnico Superior";
        const double NOTA_APROBACION = 7.0;
        const int ASISTENCIA_MINIMA = 75; // Porcentaje

        Console.WriteLine("Portal del Alumno - " + INSTITUCION);
        Console.WriteLine("Requisito Académico: La nota mínima para aprobar es " + NOTA_APROBACION);
        Console.WriteLine("Regla de cursada: Se requiere un " + ASISTENCIA_MINIMA + "% de asistencia para rendir el final.");

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();
    }
}