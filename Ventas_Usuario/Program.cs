using System.ComponentModel;
using System.Numerics;
using System.Runtime.InteropServices.Marshalling;
using System.Timers;

string Nombre_Usuario;
string Contrasenia_Usuario;
int Edad_Usuario;

string Registrar_Usuario()
{
    Console.WriteLine("Bienvenido, por favor registrese");
    Console.WriteLine(" Ingrese el nombre del usuario: ");
    Nombre_Usuario= Console.ReadLine();
    Console.WriteLine(" Ingrese la clave del usuario: ");
    Contrasenia_Usuario = Console.ReadLine();
    Console.WriteLine(" Ingrese la edad del usuario: ");
    Edad_Usuario = int.Parse(Console.ReadLine());
    if(Edad_Usuario < 18)
    {
        Console.WriteLine("No se puede registrar en el sistema");
        Environment.Exit(0);
    }

    return $"Usuario {Nombre_Usuario}, Contraseña: {Contrasenia_Usuario}, Edad: {Edad_Usuario}";


}

bool Validar_Usuario(string Usuario)
{
    return Usuario.Equals(Nombre_Usuario);
}


bool Validar_Contrasenia(string Contrasenia)
{
    return Contrasenia.Equals(Contrasenia_Usuario);
}

string Ocultar_Contrasenia(string Password)
{
    char[] caracteres = Password.ToCharArray();
    for(int i= 0; i < caracteres.Length; i++)
    {
        caracteres[i] = '*';
    }

    string guardar_Contraseña = new string (caracteres);
    return guardar_Contraseña;

}

void ingreso()
{
    int intentos = 0;
    string Nombre_Usuario;
    string Contrasenia_Usuario;
    int Edad;
    int cantidad_Intento = 5;
   
        Console.WriteLine("Ingrese el nombre del usuario para iniciar sesion: ");
        Nombre_Usuario = Console.ReadLine();
        Console.WriteLine("Ingrese la clave para iniciar sesion: ");
        Contrasenia_Usuario = Console.ReadLine();
        intentos++;

        if (Validar_Usuario(Nombre_Usuario) && Validar_Contrasenia(Contrasenia_Usuario))
        {
            string asterisco = Ocultar_Contrasenia(Contrasenia_Usuario);
            Console.WriteLine("Felicitaciones has ingresado al sistema");
            Console.WriteLine("Tu contraseña es {0} ", asterisco);
        }
        else if (intentos >= cantidad_Intento)
        {
            Console.WriteLine("Usted ha alcanzado el maximo de intentos.");
            
        }
        else
        {
            int repeticiones = intentos - cantidad_Intento;
            Console.WriteLine("$Siga intentando, le queda un maximo de intentos de {0} ", repeticiones);

        }
    }


void ventas()
{
    string opcion;
    int total = 0, precio, subtotal, cantidad_lavaplatos = 0, cantidad_jabon = 0, cantidad_detergente = 0;
    int detergente = 1000, total_detergente = 0; ;
    int jabon = 2000, total_jabon = 0;
    int lavaplatos = 3000, total_lavaplatos = 0;
    bool salir = false;

    Console.WriteLine("Has iniciado sesion correctamente");

    while (true)
    {
        Console.WriteLine("Selcciona el producto que desees comprar: ");
        Console.WriteLine("--- 1)Detergente ---  2)Jabon  ---  3)Lavaplatos --- 0) Salir");
        opcion = Console.ReadLine();
        switch (opcion.ToLower())
        {
            case "1":
            case "detergente":
                Console.WriteLine(" El precio del detergente es de 1000 ");
                Console.WriteLine(" Que cantidad desea llevar: ");
                cantidad_detergente = int.Parse(Console.ReadLine());
                total_detergente += detergente * cantidad_detergente;
                break;
            case "2":
            case "jabon":
                Console.WriteLine(" El precio del jabon es de 2000 ");
                Console.WriteLine(" Que cantidad desea llevar: ");
                cantidad_jabon = int.Parse(Console.ReadLine());
                total_jabon += jabon * cantidad_jabon;
                break;

            case "3":
            case "lavaplatos":
                Console.WriteLine(" El precio del detergente es de 3000 ");
                Console.WriteLine(" Que cantidad desea llevar: ");
                cantidad_lavaplatos = int.Parse(Console.ReadLine());
                total_lavaplatos += lavaplatos * cantidad_lavaplatos;
                break;
            case "4":
            case "pagar":
                total = total_detergente + total_jabon + total_lavaplatos;
                Console.WriteLine($"El total a pagar de todos sus productos que se lleva {cantidad_detergente} detergentes, {cantidad_jabon} jabon, {cantidad_lavaplatos} lavaplatos, total a pagar es:{total} ");
                return;

            case "0":
            case "salir":
                return;
            default:
                Console.WriteLine("Opcion no valida");
                break;
               

        }
       
       

    }
}
Registrar_Usuario();



ingreso();

ventas();   