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

        private void IngresoBtn_Click(object sender, EventArgs e)
        {
            LblError.Visible = false;
            LblError.Text = "";

            if (string.IsNullOrWhiteSpace(TxtUsuario.Text))
            {
                LblError.Visible = true;
                LblError.ForeColor = Color.Red;
                LblError.Text = "Debe ingresar un correo electrónico.";
                
                
                TxtUsuario.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(ContraseniaTxt.Text))
            {
                LblError.Visible = true;
                LblError.ForeColor = Color.Red;
                LblError.Text = "Debe ingresar una contraseña.";
                ContraseniaTxt.Focus();
                return;
            }

            Usuario usuariologin = new Usuario
            {
                CorreoElectronico = TxtUsuario.Text,
                Contraseña = Convert.ToInt32(ContraseniaTxt.Text)
            };

            bool acceso = AppNegocio.UsuarioNegocio.ValidarUsuario(usuariologin);

            if (acceso)
            {
                FormProducto formProducto = new FormProducto();
                formProducto.Show();
                this.Hide();
            }
            else
            {
                LblError.Visible = true;
                LblError.ForeColor = Color.Red;
                LblError.Text = "Correo o contraseña incorrectos.";

                TxtUsuario.BackColor = Color.MistyRose;
                ContraseniaTxt.BackColor = Color.MistyRose;
            }
        }
    }
}
