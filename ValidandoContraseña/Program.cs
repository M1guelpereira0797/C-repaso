string ContraseniaUsuario = " ";

string RegistroContrasenia()
{
    Console.WriteLine("Ingrese su contraseña: ");
    ContraseniaUsuario = Console.ReadLine();
    /*ContraseniaUsuario.PasswordChar = "*";*/
    return ContraseniaUsuario;

}

bool ValidarcContrasenia(string contrasenia)
{
    return contrasenia.Equals(ContraseniaUsuario);
}

string OcultarContrasenia(string Ocultar)
{
    char[] caracteres = Ocultar.ToCharArray();
    for(int i = 0; i < caracteres.Length; i++)
    {
        caracteres[i] = '*';
    }
    string contraseniaOculta = new string(caracteres);
    return contraseniaOculta;
}

string InformacionUsuario()
{
    Console.WriteLine("Ingrese su nombre de usuario: ");
    string Usuario = Console.ReadLine();
    Console.WriteLine("Ingresse su correo electrónico: ");
    string Correo = Console.ReadLine();
    Console.WriteLine(" Ingrese su edad: ");
    int Edad = Convert.ToInt32(Console.ReadLine());

    if (Edad >= 18)
    {
        Console.WriteLine("Puede registrarse");
    }
    else
    {
        Console.WriteLine(" Aun no es mayor de edad");
    }
    return $"Usuario: {Usuario}, Correo: {Correo}, Edad: {Edad}";
}

void Ingreso()
{
    string contrasenia;
    int intentos = 0;
    bool ingreso = true;

    while (ingreso) { 

    Console.WriteLine("Ingrese su contraseña para iniciar sesión: ");
    contrasenia = Console.ReadLine();
        intentos++;

    if (ValidarcContrasenia(contrasenia))
    {
        string Ocultar = OcultarContrasenia(contrasenia);
            Console.WriteLine("Inicio de sesión exitoso");
            Console.WriteLine("Tu contraseña es {0} ", Ocultar);
            break;
        
    }
    else if (intentos >= 5)
        {
            Console.WriteLine("Intentos alcanzados");
            break;
        }
    else
    {
        Console.WriteLine("Contraseña incorrecta");
        Console.WriteLine("Intentos restantes: {0}", 5 - intentos);
        }
    }
}

InformacionUsuario();
RegistroContrasenia();
Ingreso();