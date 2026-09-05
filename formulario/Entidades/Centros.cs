using System;
using System.Collections.Generic;
using System.Text;

namespace formulario.Entidades
{
    public class Centros
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
