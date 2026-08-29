using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaBD
{
    public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Costo { get; set; }
        public double PrecioVenta { get; set; }


        public Producto(int id, string descripcion, double costo, double precioVenta)
        {
            Id = id;
            Descripcion = descripcion;
            Costo = costo;
            PrecioVenta = precioVenta;
        }

        public Producto() { }
    }
}
