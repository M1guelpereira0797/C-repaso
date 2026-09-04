using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace formulario
{
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string LlamadoSSMS = @"Server=(localdb)\MSSQLLocalDB;Database=PruebaBD;Trusted_Connection=True;";
            var QueryProducto = "INSERT INTO Producto (Descripciones, Costo, PrecioVenta )" + "VALUES (@Descripciones, @Costo, @PrecioVenta)";
            using (SqlConnection ConectarBD = new SqlConnection(LlamadoSSMS))
            {
                ConectarBD.Open();
                using (SqlCommand AgregarDatoBD = new SqlCommand(QueryProducto, ConectarBD))
                {
                   
                    AgregarDatoBD.Parameters.AddWithValue("@Descripciones", DescripcionTxt.Text);
                    AgregarDatoBD.Parameters.AddWithValue("@Costo", Convert.ToDouble(CostoTxt.Text));
                    AgregarDatoBD.Parameters.AddWithValue("@PrecioVenta", Convert.ToDouble(PrecioVentaTxt.Text));
                    AgregarDatoBD.Parameters.AddWithValue("@Stock", Convert.ToInt32(StockTxt.Text));
                    AgregarDatoBD.Parameters.AddWithValue("@IdUsuario", Convert.ToInt32(IdUsuarioTxt.Text));
                    AgregarDatoBD.ExecuteNonQuery();
                }
                ConectarBD.Close();
            }
            MessageBox.Show("Producto agregado correctamente");
        }
    }
}
