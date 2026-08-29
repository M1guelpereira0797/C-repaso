using System;
using System.Collections.Generic;
using System.Text;
using PruebaBD;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace PruebaBD
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Mail { get; set; }

        public Usuario(string nombre, string apellido, string nombreUsuario, string contraseña, string mail)
        {
            Nombre = nombre;
            Apellido = apellido;
            NombreUsuario = nombreUsuario;
            Contraseña = contraseña;
            Mail = mail;
        }
        public Usuario() { }
    }
}

