namespace ArrayEjercicio01;

class Ejercicio02
{
    static void Main(string[] args)
    {
        double[] precios = new double[3];

        precios[0] = 19.99;
        precios[1] = 5.49;
        precios[2] = 12.75;

        Console.WriteLine("Precios almacenados en el arreglo:");
        Console.WriteLine("1. $" + precios[0]);
        Console.WriteLine("2. $" + precios[1]);
        Console.WriteLine("3. $" + precios[2]);
    }
}