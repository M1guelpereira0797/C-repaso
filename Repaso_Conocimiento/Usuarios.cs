using System;
using System.Collections.Generic;
using System.Text;

namespace Repaso_Conocimiento
{
    internal class Usuarios
    {

        private string _Nombre { get; set; }
        private string _Apellido { get; }
        private string _Correo { get; set;  }   
        private string _Direccion { get; set; } 
        private string _Rut { get; set; }
        private int _Edad { get; set; }

        public Usuarios(string nombre, string apellido, string correo, string direccion, string rut, int edad)
        {
            this._Nombre = nombre;
            this._Apellido = apellido;
            this._Correo = correo;
            this._Direccion = direccion;
            this._Rut = rut;
            this._Edad = edad;
        }


    
    public bool EsMayorEdad()
        {
            return this._Edad >= 18;  
        }

    public string Mail
        {
            get
            {
                return this._Correo;
            }
            set
            {
                this._Correo = value;

            }
        }
    public string Cambiar()
    {
            Console.WriteLine("Ingrese Nueva direccion: ");
            string nuevaDireccion = Console.ReadLine();
            this._Direccion = nuevaDireccion;
        return this._Direccion;
    }
        public bool gmail()
        {
            if (this._Correo.EndsWith("@gmail.com"))
            {
                return true;
            }
            else {
                return false;
            }

            
        }
    }
}