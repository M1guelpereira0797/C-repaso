using System;
using System.Collections.Generic;
using System.Text;
using AppEntidades;
namespace AppNegocio
{
    public class UsuarioNegocio
    {

       public static void AgregarUsuario(Usuario usuario)
        {
            AppDataBase.UsuarioData.BontonAgregarUsuario(usuario);
        }
    }
}
