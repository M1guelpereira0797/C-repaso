using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AppEntidades;
using AppNegocio;

namespace AppProducto
{
    public partial class FormRegistrodeUsuario : Form
    {
        public FormRegistrodeUsuario()
        {
            InitializeComponent();
        }

        private void SalirBn_Click(object sender, EventArgs e)
        {

        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistrarseBtn_Click(object sender, EventArgs e)
        {
            var SexoUsuario = SexoCmb.SelectedItem?.ToString();
            Usuario usuarioRegistrar = new Usuario {  
                if (SexoUsuario == "Masculino" || SexoUsuario == "Femenino")
            {
                ID_Usuario = Convert.ToInt32(Id_UsuarioTxt.Text),
                    Nombres = NombresTxt.Text.ToString(),
                    Apellido_Paterno = ApellidoPaternoTxt.Text.ToString(),
                    Apellido_Materno = ApellidoMaternoTxt.Text.ToString(),
                    CorreoElectronico = CorreoElectronicoTxt.Text.ToString(),
                    Contraseña = ContraseñaTxt.Text.ToString(),
                    Fecha_de_Nacimiento = Convert.ToInt32(FechaNacmientoTxt),
                    Sexo = SexoCmb.SelectedItem();

            }
        };




             

        



        }



        private void FormRegistrodeUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}











