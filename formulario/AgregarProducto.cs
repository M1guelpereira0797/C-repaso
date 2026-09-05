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
    }
}
