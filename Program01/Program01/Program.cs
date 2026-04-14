namespace Program01;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("--- SISTEMA DE REGISTRO DE USUARIO ---");

            Console.Write("Ingresa tu nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingresa tu apellido: ");
            string apellido = Console.ReadLine();

            Console.Write("Ingresa tu edad: ");
            string edadTexto = Console.ReadLine();
            int edad = int.Parse(edadTexto); 

            Console.Write("Ingresa tu Direccion: ");
            string direccion = Console.ReadLine();

            Console.Write("Ingresa tu Correo Electronico: ");
            string correoElectronico = Console.ReadLine();

            Console.Write("Ingresa tu Numero de Telefono: ");
            string numeroTelefono = Console.ReadLine();

            Console.WriteLine("\n--- INFORMACION DEL USUARIO ---");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine($"Apellido: {apellido}");
            Console.WriteLine($"Edad: {edad}");
            Console.WriteLine($"Direccion: {direccion}");
            Console.WriteLine($"Correo Electronico: {correoElectronico}");
            Console.WriteLine($"Numero de Telefono: {numeroTelefono}");

            Console.WriteLine("\nPresiona ENTER para salir.");
            Console.ReadLine();
    }
}
