using System;
using System.Collections.Generic;
using System.Text;

namespace formulario.Entidades
{
    public class Producto
    {   
        public int Sku { get; set; }
        public string Descripcion { get; set; }
        public double Litros { get; set; }
        public double Kilogramos { get; set; }
        public double PrecioVenta  { get; set; }




        public Producto(int id, string descripciones, double litros, double precioVenta, double  kilogramos)
        {
            Sku = id;
            Descripcion = descripciones;
            Litros = litros;
            Kilogramos = kilogramos;
            PrecioVenta = precioVenta;
              
        }
        public Producto() { }
    }
}
