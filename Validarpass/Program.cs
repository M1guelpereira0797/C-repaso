bool ValidarContraseña(string contrasenia)
{
    return contrasenia.Equals("");
}
string OcultarPass(string Pass)
{
    char [] caracteres = Pass.ToCharArray();
    for( int i = 0; i < caracteres.Length; i++)
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

    Console.WriteLine("Ingrese contraseña: ");
    
    while (ingreso)
    {
        

        contrasenia = Console.ReadLine();
        intentos++;

        if (ValidarContraseña(contrasenia))
        {
            string Ocultar = OcultarPass(contrasenia);
            Console.WriteLine("Bienvenido, te has logeado; ");
            Console.WriteLine("Tu contraseña es {0} ", Ocultar);
            break;

        }
        else if( intentos >= 5)
        {
            Console.WriteLine("Su contraseña no fue valida y agoto los intentos ");

        }
        int IntentoFallidos = 5 - intentos;

        Console.WriteLine("Su contraseña no fue valida, le quedan {0} ", IntentoFallidos);



    }
}


ValidarIngreso();