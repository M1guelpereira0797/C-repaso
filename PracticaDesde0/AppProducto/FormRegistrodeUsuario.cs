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
            FechaNacimientoDtp.Format = DateTimePickerFormat.Custom;
            FechaNacimientoDtp.CustomFormat = "dd/MM/yyyy";
            FechaNacimientoDtp.MaxDate = DateTime.Today;
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
            DateTime fechaNacimiento = FechaNacimientoDtp.Value.Date;

            if (SexoUsuario != "Masculino" && SexoUsuario != "Femenino")
            {

                MessageBox.Show("Escoga un dato indicado");
                return;

            }
            if (fechaNacimiento > DateTime.Today.AddYears(-18))
            {
                MessageBox.Show("El es menor de edad");
            }




            Usuario usuarioRegistrar = new Usuario
            {


                ID_Usuario = Convert.ToInt32(Id_UsuarioTxt.Text),
                Nombres = NombresTxt.Text.ToString(),
                Apellido_Paterno = ApellidoPaternoTxt.Text.ToString(),
                Apellido_Materno = ApellidoMaternoTxt.Text.ToString(),
                CorreoElectronico = CorreoElectronicoTxt.Text.ToString(),
                Contraseña = Convert.ToInt32(ContraseñaTxt.Text),
                Fecha_de_Nacimiento = fechaNacimiento,
                Sexo = SexoUsuario,
                Rut = Convert.ToInt32(RutTxt.Text)

            };
            AppNegocio.UsuarioNegocio.AgregarUsuario(usuarioRegistrar);

            MessageBox.Show("El usuario a sido registrado");

        }

        private void FormRegistrodeUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}











