using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using AppEntidades;
using Azure.Core;
using Microsoft.Data.SqlClient;

namespace AppDataBase
{
    public class ProductoData
    {

        public string ConnectionString = @"Server=(localdb)\MSSQLLocalDB;Database=BASEDEDATONEW;Trusted_Connection=True;";

        public List<PRODUCTO> GetProducto()
        {
            List<PRODUCTO> Productos = new List<PRODUCTO>();
            var ConsultaQuery = "SELECT * FROM PRODUCTO";
            using (SqlConnection ConectarBD = new SqlConnection(ConnectionString))
            {
                ConectarBD.Open();
                using (SqlCommand ManejadorBD = new SqlCommand(ConsultaQuery, ConectarBD))
                {
                    using (SqlDataReader LeerDatos = ManejadorBD.ExecuteReader())
                    {
                        if (LeerDatos.HasRows)
                        {
                            while(LeerDatos.Read())
                            {
                                PRODUCTO producto = new PRODUCTO();
                                producto.Centro_ID = Convert.ToInt32(LeerDatos["CENTRO_ID"]);
                                producto.Sku = Convert.ToInt32(LeerDatos["Sku"]);
                                producto.Nombre_Producto = LeerDatos["Nombre_Producto"].ToString();
                                producto.Litros = Convert.ToInt32(LeerDatos["Litros"]);
                                producto.Precio_Costo = Convert.ToInt32(LeerDatos["Precio_Costo"]);
                                producto.Precio_Venta = Convert.ToInt32(LeerDatos["Precio_Venta"]);
                                producto.Stock = Convert.ToInt32(LeerDatos["Stock"]);
                                Productos.Add(producto);
                            }
                        }

                    }
                    ConectarBD.Close();
                }
                return Productos;
            }
        }
        public static PRODUCTO ProductoById(int sku)
        {
             string ConnectionString = @"Server=(localdb)\MSSQLLocalDB;Database=BASEDEDATONEW;Trusted_Connection=True;";
             var ConsultaQuery = "SELECT * FROM PRODUCTO WHERE Sku = @Sku";
            using (SqlConnection ConectarBD = new SqlConnection(ConnectionString))
            {
                ConectarBD.Open();
                using (SqlCommand ManejadorBD = new SqlCommand(ConsultaQuery, ConectarBD))
                {
                    ManejadorBD.Parameters.AddWithValue("@Sku", sku);
                    using (SqlDataReader LeerDatos = ManejadorBD.ExecuteReader())
                    {
                        if (LeerDatos.Read())
                        {
                           
                           
                                PRODUCTO producto = new PRODUCTO();
                                producto.Centro_ID = Convert.ToInt32(LeerDatos["Centro_ID"]);
                                producto.Sku = Convert.ToInt32(LeerDatos["Sku"]);
                                producto.Nombre_Producto = LeerDatos["Nombre_Producto"].ToString();
                                producto.Litros = Convert.ToInt32(LeerDatos["Litros"]);
                                producto.Precio_Costo = Convert.ToInt32(LeerDatos["Precio_Costo"]);
                                producto.Precio_Venta = Convert.ToInt32(LeerDatos["Precio_Venta"]);
                                producto.Stock = Convert.ToInt32(LeerDatos["Stock"]);
                                
                                return producto;
                           
                        }
                        throw new Exception("ID NO ENCONTRADO");

                    }
                    
                }
                
            }
        }  

        public static void AgregarBotonProducto(PRODUCTO producto)
        {
            string ConnectionString = @"Server=(localdb)\MSSQLLocalDB;Database=BASEDEDATONEW;Trusted_Connection=True;";
            var QueryAgregar = "INSERT INTO PRODUCTO(CENTRO_ID, Sku, Nombre_Producto, Litros, Precio_Costo, Precio_Venta, Stock) VALUES (@CENTRO_ID, @Sku, @Nombre_Producto, @Litros, @Precio_Costo, @Precio_Venta, @Stock)";
            using (SqlConnection ConectarBD = new SqlConnection(ConnectionString))
            {
                ConectarBD.Open();
                using (SqlCommand ComandoAgregrar = new SqlCommand(QueryAgregar, ConectarBD))
                {
                    ComandoAgregrar.Parameters.AddWithValue("Centro_Id", producto.Centro_ID);
                    ComandoAgregrar.Parameters.AddWithValue("Sku", producto.Sku);
                    ComandoAgregrar.Parameters.AddWithValue("Nombre_Producto", producto.Nombre_Producto);
                    ComandoAgregrar.Parameters.AddWithValue("Litros", producto.Litros);
                    ComandoAgregrar.Parameters.AddWithValue("Precio_Costo", producto.Precio_Costo);
                    ComandoAgregrar.Parameters.AddWithValue("Precio_Venta", producto.Precio_Venta);
                    ComandoAgregrar.Parameters.AddWithValue("Stock", producto.Stock);
                    ComandoAgregrar.ExecuteNonQuery();
                    
                }
            }

        }
        public static void EliminarBotonProducto(PRODUCTO producto)
        {
            string ConnectionString = @"Server=(localdb)\MSSQLLocalDB;Database=BASEDEDATONEW;Trusted_Connection=True;";
            var QueryEliminar = "DELETE FROM PRODUCTO WHERE SKU = @SKU";
            using (SqlConnection ConectarBD = new SqlConnection(ConnectionString))
            {
                ConectarBD.Open();
                using (SqlCommand ComandoElimnar = new SqlCommand(QueryEliminar, ConectarBD))
                {
                    ComandoElimnar.Parameters.AddWithValue("Sku", producto.Sku);
                    
                    ComandoElimnar.ExecuteNonQuery();
                }
            }
        }
       public static void ActulizarBotonProducto(PRODUCTO producto)
        {
            string ConnectionString = @"Server=(localdb)\MSSQLLocalDB;Database=BASEDEDATONEW;Trusted_Connection=True;";
            var QueryActualizar = " UPDATE PRODUCTO SET  Nombre_Producto = @Nombre_Producto, Litros = @Litros, Precio_Costo = @Precio_Costo, Precio_Venta = @Precio_Venta, Stock = @Stock WHERE Centro_ID = @Centro_ID AND SKU = @SKU";
            using (SqlConnection ConectarBD = new SqlConnection(ConnectionString))
            {
                ConectarBD.Open();
                using (SqlCommand ComandoActulizar = new SqlCommand(QueryActualizar, ConectarBD))
                {
                    ComandoActulizar.Parameters.AddWithValue("Centro_Id", producto.Centro_ID);
                    ComandoActulizar.Parameters.AddWithValue("Sku", producto.Sku);
                    ComandoActulizar.Parameters.AddWithValue("Nombre_Producto", producto.Nombre_Producto);
                    ComandoActulizar.Parameters.AddWithValue("Litros", producto.Litros);
                    ComandoActulizar.Parameters.AddWithValue("Precio_Costo", producto.Precio_Costo);
                    ComandoActulizar.Parameters.AddWithValue("Precio_Venta", producto.Precio_Venta);
                    ComandoActulizar.Parameters.AddWithValue("Stock", producto.Stock);
                    ComandoActulizar.ExecuteNonQuery();
                }
            }
        }
    }
}
