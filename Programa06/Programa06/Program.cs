namespace Programa06;

class Program
{
    static void Main(string[] args)
    {
        // --- CONSTANTES DE IDENTIDAD Y REGLAS ---
            const string NOMBRE_APP = "GameMaster Pro";
            const string VERSION = "v1.0.2";
            const int EDAD_MINIMA = 18;

            Console.WriteLine("=== " + NOMBRE_APP + " (" + VERSION + ") ===");
            Console.WriteLine("Cargando reglas del sistema...");
            Console.WriteLine("Restricción: Prohibida la venta a menores de " + EDAD_MINIMA + " años.");
            
            // Intento de uso con constantes (sin estructuras de control)
            const int EDAD_CLIENTE = 20;
            const bool PUEDE_INGRESAR = EDAD_CLIENTE >= EDAD_MINIMA; // expresión booleana

            Console.WriteLine("\nVerificando cliente de " + EDAD_CLIENTE + " años...");
            Console.WriteLine("Edad mínima: " + EDAD_MINIMA);
            Console.WriteLine("Acceso permitido (valor bool constante): " + PUEDE_INGRESAR);

            // Mostrar constantes para reforzar concepto
            Console.WriteLine("Constante NOMBRE_APP = " + NOMBRE_APP);
            Console.WriteLine("Constante VERSION = " + VERSION);


            // Pi
            const double PI = 3.14159;
            Console.WriteLine("Constante PI = " + PI);

            // Iva
            const decimal IVA = 0.21m;
            Console.WriteLine("Constante IVA = " + IVA);

            // Dia de la semana
            const string DIA_SEMANA = "Lunes";
            Console.WriteLine("Constante DIA_SEMANA = " + DIA_SEMANA);

            //Horas del año
            const int HORAS_AÑO = 8760;
            Console.WriteLine("Constante HORAS_AÑO = " + HORAS_AÑO);

            // Maximo integrantes de un equipo
            const int MAX_INTEGRANTES_EQUIPO = 5;
            Console.WriteLine("Constante MAX_INTEGRANTES_EQUIPO = " + MAX_INTEGRANTES_EQUIPO);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();
    }
}
