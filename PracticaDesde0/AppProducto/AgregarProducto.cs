using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AppEntidades;
using AppProducto;

namespace AppProducto
{
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
        }

        public void ConfirmarBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1" || textBox1.Text == "2" || textBox1.Text == "3" || textBox1.Text == "4")
            {

                PRODUCTO ProductoConfirmado = new PRODUCTO
                {
                    Centro_ID = Convert.ToInt32(textBox1.Text),
                    Sku = Convert.ToInt32(textBox2.Text),
                    Nombre_Producto = textBox3.Text.ToString(),
                    Litros = Convert.ToInt32(textBox4.Text),
                    Precio_Costo = Convert.ToInt32(textBox5.Text),
                    Precio_Venta = Convert.ToInt32(textBox6.Text),
                    Stock = Convert.ToInt32(textBox7.Text)

                };
                AppNegocio.Class1.ConfirmarProducto(ProductoConfirmado);
                MessageBox.Show("Producto agregado correctamente");
            }
            else
            {
                MessageBox.Show("El Centro ID debe ser 1, 2, 3 o 4");
            };


        }

        private void VolverAtrasBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            FormProducto formProducto = new FormProducto();
            formProducto.Show();


        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarBtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();           
        }
    }
}
