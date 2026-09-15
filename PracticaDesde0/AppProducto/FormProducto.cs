using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AppEntidades;

namespace AppProducto
{
    public partial class FormProducto : Form
    {
        public FormProducto()
        {
            InitializeComponent();
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            CargarDatosProductos();
        }
        public void CargarDatosProductos()
        {
            List<PRODUCTO> productos = AppNegocio.Class1.CargaDeProductos();
            dataGridView1.DataSource = productos;

        }
        public void CargarDatosCentro()
        {
            List<CENTRO_LOGISTICO> centros = AppNegocio.CentroNegocio.CargarCentros();
            dataGridView1.DataSource = centros;
            dataGridView1.AutoGenerateColumns = true;

        }

        private void AgregrarProductoBtn_Click(object sender, EventArgs e)
        {
            AgregarProducto FormAgregarProducto = new AgregarProducto();
            FormAgregarProducto.ShowDialog();
            this.Hide();
        }

        private void RefrescarBtn_Click(object sender, EventArgs e)
        {

            CargarDatosProductos();
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            AppNegocio.Class1.EliminarProducto((PRODUCTO)dataGridView1.CurrentRow.DataBoundItem);
        }

        private void Buscar_CentroBtn_Click(object sender, EventArgs e)
        {
            var centroId = CentrosCmb.SelectedItem?.ToString();
            if (centroId == "Renca")
            {
                List<PRODUCTO> productos = AppNegocio.Class1.CargaDeProductos();
                dataGridView1.DataSource = productos.FindAll(p => p.Centro_ID == 1);

            }
            else if (centroId == "Maipu")
            {
                List<PRODUCTO> productos = AppNegocio.Class1.CargaDeProductos();
                dataGridView1.DataSource = productos.FindAll(p => p.Centro_ID == 2);
            }
            else if (centroId == "Carlos Valdovinos")
            {
                List<PRODUCTO> productos = AppNegocio.Class1.CargaDeProductos();
                dataGridView1.DataSource = productos.FindAll(p => p.Centro_ID == 3);
            }
            else if (centroId == "Puente Alto")
            {
                List<PRODUCTO> productos = AppNegocio.Class1.CargaDeProductos();
                dataGridView1.DataSource = productos.FindAll(p => p.Centro_ID == 4);
            }
        }

        private void Actualizar_ProductoBtn_Click(object sender, EventArgs e)
        {
            ActualizarProducto FormActualizarProducto = new ActualizarProducto();
            FormActualizarProducto.ShowDialog();


        }

        private void Salirbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
