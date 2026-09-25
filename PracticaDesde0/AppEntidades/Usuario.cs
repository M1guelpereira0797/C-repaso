using System;
using System.Collections.Generic;
using System.Text;
using Azure.Core.Pipeline;

namespace AppEntidades
{
    public class Usuario
    {
        public int ID_Usuario { get; set; }
        public string Nombres { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string CorreoElectronico { get; set; }
        public string Contraseña { get; set; }
        public DateTime Fecha_de_Nacimiento { get; set; }

        public string Sexo { get; set; }

        public int Rut { get; set; }

        public Usuario() { }

        public Usuario( int id_usuario, string nombres, string apellido_paterno, string apellido_materno, 
            string correoElectronico, string contraseña, DateTime fechadenacimiento, string sexo, int rut)
        {
            ID_Usuario = id_usuario;
            Nombres = nombres;
            Apellido_Paterno = apellido_paterno;
            Apellido_Materno = apellido_materno;
            CorreoElectronico = correoElectronico;
            Contraseña = contraseña;
            Fecha_de_Nacimiento = fechadenacimiento;
            Sexo = sexo;
            Rut = rut;

        }

    }
}
