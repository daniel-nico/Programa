class programa01
{
    static void Main(string[] args)
    {
        // --- CONSTANTES DE CÁLCULO Y CONTROL ---
        const double LIMITE_IMC_SOBREPESO = 25.0;
        const string UNIDAD_MEDIDA = "kg/m2";
        const bool ENVIAR_ALERTA_MEDICA = true;

        Console.WriteLine("--- ANALIZADOR DE SALUD ---");

        double peso = 85.5; // en kg
        double altura = 1.75; // en metros
        double imc = peso / (altura * altura);
        bool estaExcedido = imc > LIMITE_IMC_SOBREPESO;

        Console.WriteLine("\nResultado del análisis:");
        Console.WriteLine("Su IMC es: " + Math.Round(imc, 1) + " " + UNIDAD_MEDIDA);
        Console.WriteLine("¿Supera el límite recomendado de " + LIMITE_IMC_SOBREPESO + "?: " + estaExcedido);

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();
    }
}