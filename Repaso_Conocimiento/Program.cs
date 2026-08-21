namespace Repaso_Conocimiento
{
    class Program
    {
        static void Main(string[] args)
        {
            string nuevaDireccion = Usuarios.Cambiar();
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Ingrese la nueva direccion " + nuevaDireccion);
            nuevaDireccion = Console.ReadLine();
            Cambiar modficar = new Cambiar();
            modficar.Cambiar(nuevaDireccion);

            Console.WriteLine("La nueva direccion es: " + nuevaDireccion);

        }
    }
}
