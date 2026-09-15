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
    public partial class ActualizarProducto : Form
    {
        public ActualizarProducto()
        {
            InitializeComponent();
        }

        private void VolverAtrasBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            FormProducto formProducto = new FormProducto();
            formProducto.Show();

        }

        private void ConfirmarBtn_Click(object sender, EventArgs e)
        {
            PRODUCTO ModificarProducto = new PRODUCTO();
            ModificarProducto.Centro_ID = Convert.ToInt32(textBox1.Text);
            ModificarProducto.Sku = Convert.ToInt32(textBox2.Text);
            ModificarProducto.Nombre_Producto = textBox3.Text;
            ModificarProducto.Litros = Convert.ToInt32(textBox4.Text);
            ModificarProducto.Precio_Costo = Convert.ToInt32(textBox5.Text);
            ModificarProducto.Precio_Venta = Convert.ToInt32(textBox6.Text);
            ModificarProducto.Stock = Convert.ToInt32(textBox7.Text);
            AppNegocio.Class1.ActualizarProducto(ModificarProducto);
            MessageBox.Show("El Producto se ha actualizado completamente");
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
