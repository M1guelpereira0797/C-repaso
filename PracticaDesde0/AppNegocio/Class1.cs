using AppDataBase;
using AppEntidades;

namespace AppNegocio
{
    public class Class1
    {
        public static List<PRODUCTO> CargaDeProductos()
        {
            return new ProductoData().GetProducto();
        }

        public static void ConfirmarProducto(PRODUCTO producto)
        {
            ProductoData.AgregarBotonProducto(producto);
        }
        public static void EliminarProducto(PRODUCTO producto)
        {
            ProductoData.EliminarBotonProducto(producto);
        }
        public static void ActualizarProducto(PRODUCTO producto)
        {
            ProductoData.ActulizarBotonProducto(producto);
        }   
    }
}