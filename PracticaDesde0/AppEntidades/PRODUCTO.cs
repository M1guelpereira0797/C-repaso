namespace AppEntidades
{
    public class PRODUCTO
    {
        public int Centro_ID { get; set; } 
        public int Sku { get; set; }
        
        public string Nombre_Producto { get; set; }
        public int Litros { get; set; }
        public int Precio_Costo { get; set; }
        public int Precio_Venta { get; set; }
        public int Stock { get; set; } 


        public PRODUCTO(int centroId, int sku, string nombreProducto, int litros, int precioCosto, int precioVenta, int stock)
        {
            Centro_ID = centroId;
            Sku = sku;
            Nombre_Producto = nombreProducto;
            Litros = litros;
            Precio_Costo = precioCosto;
            Precio_Venta = precioVenta;
            Stock = stock;
        }

        public PRODUCTO() { }

    }
}
