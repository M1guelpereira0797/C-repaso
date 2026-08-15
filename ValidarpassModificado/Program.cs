string ContraseniaNueva = " ";
string RegistroDeContrasenia()
{
    Console.WriteLine("Ingrese una contraseña para el registro");
    ContraseniaNueva = Console.ReadLine();
    ContraseniaNueva.PasswordChar = "*";
    return ContraseniaNueva;


}


bool ValidarContraseña(string contrasenia)
{
    return contrasenia.Equals(ContraseniaNueva);
}
string OcultarPass(string Pass)
{
    char[] caracteres = Pass.ToCharArray();
    for (int i = 0; i < caracteres.Length; i++)
    {
        caracteres[i] = '*';
    }
    string NewPass = new string(caracteres);

    return NewPass;
}

void ValidarIngreso()
{
    int intentos = 0;
    string contrasenia;
    bool ingreso = true;



    while (ingreso)
    {
        Console.WriteLine("Ingrese contraseña: ");

        contrasenia = Console.ReadLine();
        intentos++;

        if (ValidarContraseña(contrasenia))
        {
            string Ocultar = OcultarPass(contrasenia);
            Console.WriteLine("Bienvenido, te has logeado; ");
            Console.WriteLine("Tu contraseña es {0} ", Ocultar);
            break;

        }
        else if (intentos >= 5)
        {
            Console.WriteLine("Su contraseña no fue valida y agoto los intentos ");

        }
        int IntentoFallidos = 5 - intentos;

        Console.WriteLine("Su contraseña no fue valida, le quedan {0} ", IntentoFallidos);



    }
}

RegistroDeContrasenia();
ValidarIngreso();



/* 
 string LeerContrasenia()
{
    string contrasenia = "";
    ConsoleKeyInfo tecla;

    do
    {
        tecla = Console.ReadKey(true); // true = no muestra la tecla

        if (tecla.Key != ConsoleKey.Enter)
        {
            contrasenia += tecla.KeyChar;
            Console.Write("*"); // muestra * en pantalla
        }
    } while (tecla.Key != ConsoleKey.Enter);

    Console.WriteLine(); // salto de línea
    return contrasenia;
} 
*/