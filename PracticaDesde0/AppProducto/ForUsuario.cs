using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppProducto
{
    public partial class ForUsuario : Form
    {
        public ForUsuario()
        {
            InitializeComponent();
        }

        private void ForUsuario_Load(object sender, EventArgs e)
        {

        }

        private void RegistrarseLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormRegistrodeUsuario formRegistroUsuario = new FormRegistrodeUsuario();
            formRegistroUsuario.Show();
            
        }
    }
}
