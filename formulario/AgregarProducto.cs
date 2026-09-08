using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using formulario.Entidades;
using System.Linq;
using formulario;

namespace formulario
{
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            AgregarProductos();

            this.Close();


        }

        private void LimpiarBtn_Click(object sender, EventArgs e)
        {
            SkuTxt.Clear();
            DescripcionTxt.Clear();
            LitrosTxt.Clear();
            KilogramosTxt.Clear();
            PrecioVentaTxt.Clear();
        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void AgregarProductos()
        {
            string LlamadoSSMS = @"Server=(localdb)\MSSQLLocalDB;Database=PROYECTOBD;Trusted_Connection=True;";
            var QueryProducto = "INSERT INTO PRODUCTOS (Sku, Descripcion, Litros, Kilogramos, PrecioVenta )" + "VALUES (@Sku, @Descripcion, @Litros, @Kilogramos, @PrecioVenta)";
            using (SqlConnection ConectarBD = new SqlConnection(LlamadoSSMS))
            {
                ConectarBD.Open();
                using (SqlCommand AgregarDatoBD = new SqlCommand(QueryProducto, ConectarBD))
                {

                    AgregarDatoBD.Parameters.AddWithValue("@Sku", SkuTxt.Text);
                    AgregarDatoBD.Parameters.AddWithValue("@Descripcion", DescripcionTxt.Text);
                    AgregarDatoBD.Parameters.AddWithValue("@Litros", Convert.ToDouble(LitrosTxt.Text));
                    AgregarDatoBD.Parameters.AddWithValue("@Kilogramos", Convert.ToDouble(KilogramosTxt.Text));
                    AgregarDatoBD.Parameters.AddWithValue("@PrecioVenta", Convert.ToDouble(PrecioVentaTxt.Text));

                    AgregarDatoBD.ExecuteNonQuery();
                }
                ConectarBD.Close();
            }
            MessageBox.Show("Producto agregado correctamente");
        }
        public void ModificarProducto(Producto producto)
        {
            string ConectarString = @"Server=(localdb)\MSSQLLocalDB;Database=PROYECTOBD;Trusted_Connection=True;";
            var query = "UPDATE Productos SET Descripcion = @Descripcion, Litros = @Litros, Kilogramos = @Kilogramos, PrecioVenta = @PrecioVenta WHERE SKU = @SKU";
            using (SqlConnection ConectarBD = new SqlConnection(ConectarString))
            {
                ConectarBD.Open();
                using (SqlCommand ActualizarProdcuto = new SqlCommand(query, ConectarBD))
                {
                    ActualizarProdcuto.Parameters.AddWithValue("@SKU", producto.Sku);
                    ActualizarProdcuto.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                    ActualizarProdcuto.Parameters.AddWithValue("@Litros", producto.Litros);
                    ActualizarProdcuto.Parameters.AddWithValue("@Kilogramos", producto.Kilogramos);
                    ActualizarProdcuto.Parameters.AddWithValue("@PrecioVenta", producto.PrecioVenta);
                    ActualizarProdcuto.ExecuteNonQuery();
                }
            }
        }

        private void ProductoActualizar_Click(object sender, EventArgs e)
        {
            Producto ModificaProducto = new Producto();
            ModificaProducto.Sku = Convert.ToInt32(SkuTxt.Text);
            ModificaProducto.Descripcion = DescripcionTxt.Text;
            ModificaProducto.Litros = Convert.ToDouble(LitrosTxt.Text);
            ModificaProducto.Kilogramos = Convert.ToDouble(KilogramosTxt.Text);
            ModificaProducto.PrecioVenta = Convert.ToDouble(PrecioVentaTxt.Text);
            ModificarProducto(ModificaProducto);

            MessageBox.Show("Producto actualizado correctamente");
  

        }
    }
}

    

        


